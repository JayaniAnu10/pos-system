using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using PointOfSale.Production;




namespace PointOfSale.Production
{
    public partial class Dash_Production : Form
    {
        public Dash_Production()
        {
            InitializeComponent();
            txtSearch.TextChanged += txtSearch_TextChanged;
        }
        private void Dash_Production_Load(object sender, EventArgs e)
        {
            LoadProductData();
        }


        private void LoadProductData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            string query = @"SELECT ProductId, ProductName, Quantity, CostPrice, SellingPrice, Description, Status FROM ProductTable";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;

                // Add buttons only once
                if (!dataGridView1.Columns.Contains("DeleteButton"))
                    AddActionButtons();
            }
        }

        private void SearchProduct(string keyword)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            string query = @"SELECT ProductId, ProductName, Quantity, CostPrice, SellingPrice, Description, Status
                         FROM ProductTable
                         WHERE ProductName LIKE @keyword OR ProductId LIKE @keyword";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void AddActionButtons()
        {
            // DELETE Button
            DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn
            {
                Name = "DeleteButton",
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(deleteBtn);

            // UPDATE Button
            DataGridViewButtonColumn updateBtn = new DataGridViewButtonColumn
            {
                Name = "UpdateButton",
                HeaderText = "Update",
                Text = "Update",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(updateBtn);

            // DISPLAY Button
            DataGridViewButtonColumn displayBtn = new DataGridViewButtonColumn
            {
                Name = "DisplayButton",
                HeaderText = "Display",
                Text = "Display",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(displayBtn);

        }




        private void DeleteProduct(string productId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            string query = "DELETE FROM ProductTable WHERE ProductId = @ProductId";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@ProductId", productId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }




        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            DataGridViewColumn column = dataGridView1.Columns[e.ColumnIndex];
            string productId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(); // Column 0 = ProductId

            if (column.Name == "DeleteButton")
            {
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete Product {productId}?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        DeleteProduct(productId);
                        MessageBox.Show("Product deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProductData(); // Refresh the DataGridView
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (column.Name == "UpdateButton")
            {
                try
                {
                    Update_product updateForm = new Update_product(productId); // Ensure this constructor exists in your Update_product form
                    updateForm.ShowDialog(); // Open as a modal dialog
                    LoadProductData(); // Refresh data after possible update
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening update form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (column.Name == "DisplayButton")
            {
                try
                {
                    ProductView displayForm = new ProductView(productId); // Make sure constructor accepts productId
                    displayForm.ShowDialog(); // Open the form as a modal dialog
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error displaying product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void btnAddButton_Click(object sender, EventArgs e)
        {
            // Create an instance of your Add Product form
            Add_product addForm = new Add_product();

            // Show the form as a modal dialog
            addForm.ShowDialog();

            // Reload the product list after the Add form is closed
            LoadProductData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (!string.IsNullOrEmpty(keyword))
            {
                SearchProduct(keyword);
            }
            else
            {
                LoadProductData(); // Reload everything if search is empty
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProduct(txtSearch.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";     // Clear the search box
            LoadProductData();       // Reload all product data
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}