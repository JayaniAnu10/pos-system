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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
