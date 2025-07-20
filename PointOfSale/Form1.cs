using PointOfSale.Cashier;
using PointOfSale.Employee;
using PointOfSale.Production;
using PointOfSale.Report;
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

namespace PointOfSale
{
    public partial class Form1 : Form
    {

        private string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string EmployeeUserName = txtusername.Text.Trim();
            string EmployeePassword = txtpassword.Text.Trim();

            //string connectionString = "Server=DESKTOP-3JCF9S2\\SQLEXPRESS;Database=UserDB;Integrated Security=True;TrustServerCertificate=True;";
             
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT EmployeeRole FROM EmployeeTable WHERE EmployeeUserName = @username AND EmployeePassword = @password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", EmployeeUserName);
                    cmd.Parameters.AddWithValue("@password", EmployeePassword);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string role = reader["EmployeeRole"].ToString();

                        MessageBox.Show("Login successful as " + role);

                        this.Hide();

                        if (role == "admin")
                        {
                            Dash_Production af = new Dash_Production();
                             af.Show();
                        }
                        else if (role == "manager")
                        {
                             report mf = new report();
                            mf.Show();
                        }
                        else if (role == "cashier")
                        {
                            CashierMain cf = new CashierMain(EmployeeUserName); //edit by parindya to get username to cashiermain
                             cf.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}



