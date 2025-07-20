using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PointOfSale.Production
{
    public partial class Update_product : Form
    {
        private readonly string _productId;

        public Update_product(string productId)
        {
            InitializeComponent();
            _productId = productId;
            this.Load += Update_product_Load;
            this.Shown += Update_product_Shown;
        }

        private void Update_product_Shown(object sender, EventArgs e)
        {
            // Prevent editing of the ID field
            txtProductId.Enabled = false;
        }

        private void Update_product_Load(object sender, EventArgs e)
        {
            // Populate status dropdown
            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new[] { "Available", "Out of Stock", "Discontinued" });
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;

            LoadProductDetails();
        }

        private void LoadProductDetails()
        {
            var connectionString = ConfigurationManager
                .ConnectionStrings["MyConnectionString"]
                .ConnectionString;

            const string query = @"
                SELECT * 
                FROM ProductTable 
                WHERE ProductId = @ProductId";

            using (var con = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@ProductId", _productId);
                con.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                        return;
                    }

                    txtProductId.Text = reader["ProductId"].ToString();
                    txtProductName.Text = reader["ProductName"].ToString();
                    nudQuantity.Value = Convert.ToDecimal(reader["Quantity"]);
                    txtCostPrice.Text = reader["CostPrice"].ToString();
                    txtSellingPrice.Text = reader["SellingPrice"].ToString();
                    txtDescription.Text = reader["Description"].ToString();

                    var statusValue = reader["Status"].ToString();
                    if (cmbStatus.Items.Contains(statusValue))
                        cmbStatus.SelectedItem = statusValue;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Product Name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtCostPrice.Text, out var costPrice))
            {
                MessageBox.Show("Invalid cost price.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtSellingPrice.Text, out var sellingPrice))
            {
                MessageBox.Show("Invalid selling price.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select a status.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var connectionString = ConfigurationManager
                .ConnectionStrings["MyConnectionString"]
                .ConnectionString;

            const string query = @"
                UPDATE ProductTable
                SET ProductName   = @ProductName,
                    Quantity      = @Quantity,
                    CostPrice     = @CostPrice,
                    SellingPrice  = @SellingPrice,
                    Description   = @Description,
                    Status        = @Status
                WHERE ProductId    = @ProductId";

            using (var con = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@ProductId", _productId);
                cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                cmd.Parameters.AddWithValue("@Quantity", nudQuantity.Value);
                cmd.Parameters.AddWithValue("@CostPrice", costPrice);
                cmd.Parameters.AddWithValue("@SellingPrice", sellingPrice);
                cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString());

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }



        private void label6_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void panel1_Paint_2(object sender, PaintEventArgs e) { }
        private void Add_product_Load(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // You can write your logic here
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();

        }
    }
}

