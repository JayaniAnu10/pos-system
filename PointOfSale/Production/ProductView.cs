using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PointOfSale.Production
{
    public partial class ProductView : Form
    {
        private string _productId;

        public ProductView(string productId)
        {
            InitializeComponent();
            _productId = productId;
            this.Load += new EventHandler(ProductView_Load);
        }

       

        private void ProductView_Load(object sender, EventArgs e)
        {
            LoadProductDetails();
        }

        private void LoadProductDetails()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            string query = "SELECT * FROM ProductTable WHERE ProductId = @ProductId";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@ProductId", _productId);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtProductId.Text = reader["ProductId"].ToString();
                    txtProductName.Text = reader["ProductName"].ToString();
                    txtQuantity.Text = reader["Quantity"].ToString();
                    txtCostPrice.Text = reader["CostPrice"].ToString();
                    txtSellingPrice.Text = reader["SellingPrice"].ToString(); // Add if not yet displayed
                    txtDescription.Text = reader["Description"].ToString();

                    txtProductId.ReadOnly = true;
                    txtProductName.ReadOnly = true;
                    txtQuantity.ReadOnly = true;
                    txtCostPrice.ReadOnly = true;
                    txtSellingPrice.ReadOnly = true;
                    txtDescription.ReadOnly = true;
                    // Add if needed
                }
                else
                {
                    MessageBox.Show("Product not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

    }
}

        
    

