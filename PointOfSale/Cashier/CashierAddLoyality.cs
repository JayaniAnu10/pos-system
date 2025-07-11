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
using System.Configuration;
using System.Data.SqlTypes;

namespace PointOfSale.Cashier
{
    public partial class CashierAddLoyality : Form
    {
        private decimal totalAmount;
        private CashierMain mainForm;

        public CashierAddLoyality()
        {
            InitializeComponent();
        }
        

        public CashierAddLoyality(CashierMain form, decimal total)
        {
            InitializeComponent();
            mainForm = form;
            totalAmount = total;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            string IdNo = txt_add_point.Text.Trim();

            if (string.IsNullOrWhiteSpace(IdNo))
            {
                MessageBox.Show("Please enter ID number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           /* decimal totalAmount;
            if (!decimal.TryParse(txt_total.Text.Trim(), out totalAmount))
            {
                MessageBox.Show("Invalid total amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }*/

            int earnedPoints = (int)(totalAmount / 100);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string checkQuery = "SELECT Points FROM Loyality WHERE IdNo = @IdNo";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@IdNo", IdNo);
                        object result = checkCmd.ExecuteScalar();

                        if (result != null)
                        {
                            int currentPoints = Convert.ToInt32(result);
                            int newPoints = currentPoints + earnedPoints;

                            // ✅ Show popup: "You have X points. Do you want to use them?"
                            DialogResult usePointsDialog = MessageBox.Show(
                                $"This customer has {currentPoints} loyalty points.\nDo you want to use them?",
                                "Use Loyalty Points",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question
                            );

                            if (usePointsDialog == DialogResult.Yes)
                            {
                                decimal dis = Math.Min(currentPoints, (int)totalAmount);
                                decimal discount = -1 * dis;
                                decimal net = (totalAmount + discount);
                                mainForm.SetDiscount(discount,net);
                                newPoints = newPoints - (int)dis;
                                MessageBox.Show("Loyalty points is used.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                            }
                            else
                            {
                                MessageBox.Show("No loyalty points used.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            // ✅ Update points as usual
                            string updateQuery = "UPDATE Loyality SET Points = @Points WHERE IdNo = @IdNo";
                            using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                            {
                                updateCmd.Parameters.AddWithValue("@Points", newPoints);
                                updateCmd.Parameters.AddWithValue("@IdNo", IdNo);

                                int rowsAffected = updateCmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Points updated successfully! New total: " + newPoints, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Failed to update points.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("This user has no loyalty.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database connection failed!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_add_point.Text = " ";
        }

        private void CashierAddLoyality_Load(object sender, EventArgs e)
        {

        }
    }
}

