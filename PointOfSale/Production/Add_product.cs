using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace pos_system.Production
{
    public partial class Add_product : Form

    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        public Add_product()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Add_product_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Available");
            cmbStatus.Items.Add("Sold out");
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.SelectedIndex = 0; // Set default selection


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Read data from form controls
            string productId = txtProductId.Text.Trim();
            string productName = txtProductName.Text.Trim();
            int quantity = (int)nudQuantity.Value;
            string costPriceText = txtCostPrice.Text.Trim();
            string sellingPriceText = txtSellingPrice.Text.Trim();
            string description = txtDescription.Text.Trim();
            string status = cmbStatus.SelectedItem?.ToString();

            // Basic validation (optional)
            if (string.IsNullOrEmpty(productId) || string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(costPriceText) || string.IsNullOrEmpty(sellingPriceText) || string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(costPriceText, out decimal costPrice))
            {
                MessageBox.Show("Invalid Cost Price value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(sellingPriceText, out decimal sellingPrice))
            {
                MessageBox.Show("Invalid Selling Price value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string insertQuery = "INSERT INTO ProductTable (ProductId, ProductName, Quantity, CostPrice, SellingPrice, Description, Status) " +
                                         "VALUES (@ProductId, @ProductName, @Quantity, @CostPrice, @SellingPrice, @Description, @Status)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductId", productId);
                        cmd.Parameters.AddWithValue("@ProductName", productName);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@CostPrice", costPrice);
                        cmd.Parameters.AddWithValue("@SellingPrice", sellingPrice);
                        cmd.Parameters.AddWithValue("@Description", description);
                        cmd.Parameters.AddWithValue("@Status", status);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();
                        }
                        else
                        {
                            MessageBox.Show("Failed to save product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
                {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            // Optional helper method to clear form after saving
        private void ClearForm()
            {
            txtProductId.Clear();
            txtProductName.Clear();
            nudQuantity.Value = 0;
            txtCostPrice.Clear();
            txtSellingPrice.Clear();
            txtDescription.Clear();
            cmbStatus.SelectedIndex = -1;
            }

        
          



            

        

        private void txtSellingPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearForm(); // Reuse the method created earlier
        }

        private void txtProductId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCostPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }
    }
}
