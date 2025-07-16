using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.Cmp;

namespace pos_system.Production
{
    public partial class ProductView : Form
    {
        private string _productId;

        public ProductView(string productId)
        {
            InitializeComponent();
            _productId = productId;
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
                   
                }
                else
                {
                    MessageBox.Show("Product not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // Handle the event or leave it empty
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Handle the event or leave it empty
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Handle the event or leave it empty
        }

    }
}
