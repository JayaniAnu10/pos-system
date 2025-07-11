using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;

namespace PointOfSale.Cashier
{
    public partial class CashierCreateLoyality : Form
    {
        public CashierCreateLoyality()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)

        {

            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string IdNo = txt_id.Text.Trim();
                    string name = txt_name.Text.Trim();

                    // Validate Name & PhoneNo Not Empty
                    if (string.IsNullOrWhiteSpace(IdNo) )
                    {
                        MessageBox.Show("Please enter  Id number .", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    else if (string.IsNullOrWhiteSpace(name))
                    {
                        MessageBox.Show("Please enter  name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Validate idNo Format
                    bool isValidId = false;

                    // Case 1: 12-digit NIC
                    if (IdNo.Length == 12 && IdNo.All(char.IsDigit))
                    {
                        isValidId = true;
                    }
                    // Case 2: 10-digit NIC with V/v at the end
                    else if (IdNo.Length == 11 &&
                             IdNo.Substring(0, 10).All(char.IsDigit) &&
                             (IdNo.EndsWith("V", StringComparison.OrdinalIgnoreCase)))
                    {
                        isValidId = true;
                    }

                    if (!isValidId)
                    {
                        MessageBox.Show("Invalid NIC number! Enter 12-digit number or 9 digits + V", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    //is alreary exit id
                    string checkQuery = "SELECT COUNT(*) FROM Loyality WHERE IdNo = @IdNo";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@IdNo", IdNo);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("This ID already exists!", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    // Insert into database
                    try
                    {
                        string query = "INSERT INTO Loyality (IdNo, Name, Points) VALUES (@IdNo, @Name, @Points)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@IdNo", IdNo); // Keep as string
                            cmd.Parameters.AddWithValue("@Name", name);
                            cmd.Parameters.AddWithValue("@Points", 0);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Loyalty user added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Insert failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database connection failed!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_id.Text = "";
            txt_name.Text = "";
        }

        private void CashierCreateLoyality_Load(object sender, EventArgs e)
        {
            


        }
    }
}
