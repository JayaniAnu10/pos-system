using PointOfSale.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PointOfSale.Report
{
    public partial class report : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        public report()
        {
            InitializeComponent();
            comboBoxYear.SelectedIndexChanged += comboBoxYear_SelectedIndexChanged;
        }

        private void Report_Load(object sender, EventArgs e)
        {
            LoadYears();
            EmployeeSalesPieChart();
            RevenueBreakdown();
        }

        private void LoadYears()
        {
            comboBoxYear.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT DISTINCT YEAR(SaleDate) AS SaleYear FROM Sales ORDER BY SaleYear";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxYear.Items.Add(reader["SaleYear"].ToString());
                }
            }

            if (comboBoxYear.Items.Count > 0)
            {
                comboBoxYear.SelectedIndex = 0;
            }
        }




        private void comboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxYear.SelectedItem != null)
            {
                int selectedYear = int.Parse(comboBoxYear.SelectedItem.ToString());
                LoadMonthlySalesChart(selectedYear);
            }
        }

        //loading monthly sales
        public void LoadMonthlySalesChart(int year)
        {

            chart1.Series.Clear();
            chart1.ChartAreas.Clear();


            ChartArea chartArea = new ChartArea("SalesArea");
            chart1.ChartAreas.Add(chartArea);


            Series series = new Series("Total Sales");
            series.ChartType = SeriesChartType.Column;
            series.XValueType = ChartValueType.String;
            series.IsValueShownAsLabel = true;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    SELECT 
                        DATENAME(MONTH, SaleDate) AS MonthName,
                        MONTH(SaleDate) AS MonthNum,
                        SUM(Total) AS TotalSales
                    FROM Sales
                    WHERE YEAR(SaleDate) = @Year
                    GROUP BY DATENAME(MONTH, SaleDate), MONTH(SaleDate)
                    ORDER BY MonthNum";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Year", year);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string month = reader["MonthName"].ToString();
                    decimal total = Convert.ToDecimal(reader["TotalSales"]);

                    series.Points.AddXY(month, total);
                }

                chart1.Series.Add(series);
            }
        }

        private void EmployeeSalesPieChart()
        {
            chartEmpSales.Series.Clear();
            chartEmpSales.ChartAreas.Clear();
            chartEmpSales.Titles.Clear();


            ChartArea chartArea = new ChartArea("PieArea");
            chartEmpSales.ChartAreas.Add(chartArea);


            Series series = new Series("Employee Sales");
            series.ChartType = SeriesChartType.Pie;
            series.IsValueShownAsLabel = true;
            series.LabelForeColor = System.Drawing.Color.Black;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                   SELECT e.EmployeeID,e.EmployeeName,SUM(s.Total) AS TotalSales
                    FROM Sales s
                    INNER JOIN EmployeeTable e ON s.EmployeeID = e.EmployeeID
                    GROUP BY e.EmployeeID, e.EmployeeName
                    ORDER BY e.EmployeeID";


                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string employeeLabel = $"{reader["EmployeeID"]} - {reader["EmployeeName"]}";
                    decimal totalSales = Convert.ToDecimal(reader["TotalSales"]);

                    series.Points.AddXY(employeeLabel, totalSales);
                }

                chartEmpSales.Series.Add(series);
                chartEmpSales.Titles.Add("Sales by Employee");
            }
        }


        private void RevenueBreakdown()
        {
         
            DataTable originalTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
            SELECT 
                p.ProductName,
                ISNULL(SUM(o.Qty * p.SellingPrice), 0) AS TotalRevenue
            FROM ProductTable p
            LEFT JOIN Orders o ON p.ProductId = o.ProductId
            GROUP BY p.ProductName
            ORDER BY p.ProductName";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(originalTable);
            }

            decimal grandTotal = originalTable.AsEnumerable()
                .Sum(row => row.Field<decimal>("TotalRevenue"));

         
            DataTable transposedTable = new DataTable();

            
            transposedTable.Columns.Add("Metric");

           
            foreach (DataRow row in originalTable.Rows)
            {
                string product = row["ProductName"].ToString();
                transposedTable.Columns.Add(product);
            }

            // Revenue row
            DataRow revenueRow = transposedTable.NewRow();
            revenueRow["Metric"] = "Revenue";
            foreach (DataRow row in originalTable.Rows)
            {
                string product = row["ProductName"].ToString();
                decimal revenue = Convert.ToDecimal(row["TotalRevenue"]);
                revenueRow[product] = revenue.ToString("N2");
            }
            transposedTable.Rows.Add(revenueRow);

            // Percentage row
            DataRow percentageRow = transposedTable.NewRow();
            percentageRow["Metric"] = "Percentage";
            foreach (DataRow row in originalTable.Rows)
            {
                string product = row["ProductName"].ToString();
                decimal revenue = Convert.ToDecimal(row["TotalRevenue"]);
                decimal percent = (grandTotal > 0) ? (revenue / grandTotal) * 100 : 0;
                percentageRow[product] = percent.ToString("0.00") + " %";
            }
            transposedTable.Rows.Add(percentageRow);
            dataGridViewRevenue.DataSource = transposedTable;
            dataGridViewRevenue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewColumn column in dataGridViewRevenue.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

         
            dataGridViewRevenue.DataSource = transposedTable;
            dataGridViewRevenue.ReadOnly = true;
            dataGridViewRevenue.AllowUserToAddRows = false;

           
            dataGridViewRevenue.ScrollBars = ScrollBars.Both;
            dataGridViewRevenue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridViewRevenue.AutoResizeColumns();
            dataGridViewRevenue.AutoResizeRows();
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DownloadBtn_Click(object sender, EventArgs e)
        {
            IReportGenerator exporter = new ExportPdfReportGenerator();
            exporter.exportPdf(chart1, chartEmpSales, dataGridViewRevenue);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeeDetails employeeForm = new EmployeeDetails();
            employeeForm.Show();
            this.Hide(); // hide current form
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit(); // close entire app
        }

        private void button2_Click(object sender, EventArgs e)
        {
            report reportForm = new report();
            reportForm.Show();
            this.Hide(); // hide current form
        }
    }
}
