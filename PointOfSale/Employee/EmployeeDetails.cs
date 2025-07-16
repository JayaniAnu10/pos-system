using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Drawing.Imaging;


namespace PointOfSale.Employee
{
    public partial class EmployeeDetails : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;


        //private string connectionString;

       

        public EmployeeDetails()
        {
            InitializeComponent();
            dataviewbox.CellClick += dataviewbox_CellClick;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void EmployeeDetails_Load(object sender, EventArgs e)      
        {

           //string connectionString = @"Data Source=DESKTOP-3UCJTDT\SQLEXPRESS;Initial Catalog=POS;Integrated Security=True";


            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                
                    string query = "SELECT EmployeeId, EmployeeName, EmployeeNIC, EmployeeTeleNo, EmployeeAddress, EmployeeEmail, EmployeeRole, EmployeeGender, EmployeeSalary, EmployeeUserName, EmployeePassword FROM EmployeeTable";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataviewbox.DataSource = dt;
                }
            
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

     

        private void importimgbtn_Click(object sender, EventArgs e)   //insert image to the profile picture
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dlg.FileName);
            }
        }

      

        private void btnupdate_Click(object sender, EventArgs e)      //update records 
        {
            try
            {
                //string connectionString = @"Data Source=DESKTOP-3UCJTDT\SQLEXPRESS;Initial Catalog=POS;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"UPDATE EmployeeTable SET
                                EmployeeName = @Name,
                                EmployeeNIC = @NIC,
                                EmployeeTeleNo = @Tel,
                                EmployeeAddress = @Address,
                                EmployeeEmail = @Email,
                                EmployeeRole = @Role,
                                EmployeeGender = @Gender,
                                EmployeeSalary = @Salary,
                                EmployeeUserName = @Username,
                                EmployeePassword = @Password,
                                EmployeePhoto = @Image
                             WHERE EmployeeID = @ID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", idtxt.Text);
                        cmd.Parameters.AddWithValue("@Name", nametxt.Text);
                        cmd.Parameters.AddWithValue("@NIC", nictxt.Text);
                        cmd.Parameters.AddWithValue("@Tel", telenotxt.Text);
                        cmd.Parameters.AddWithValue("@Address", addresstxt.Text);
                        cmd.Parameters.AddWithValue("@Email", emailtxt.Text);
                        cmd.Parameters.AddWithValue("@Role", jobtxt.Text);
                        cmd.Parameters.AddWithValue("@Gender", gendertxt.Text);

                        if (decimal.TryParse(salarytxt.Text, out decimal salary))
                        {
                            cmd.Parameters.AddWithValue("@Salary", salary);
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid salary.");
                            return;
                        }

                        cmd.Parameters.AddWithValue("@Username", usernametxt.Text);
                        cmd.Parameters.AddWithValue("@Password", passwordtxt.Text);

                        byte[] imageBytes = null;
                        if (pictureBox1.Image != null)
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                pictureBox1.Image.Save(ms, ImageFormat.Png);
                                imageBytes = ms.ToArray();
                            }
                        }

                        cmd.Parameters.Add("@Image", SqlDbType.VarBinary).Value = (object)imageBytes ?? DBNull.Value;

                        conn.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Employee updated successfully!");
                            EmployeeDetails_Load(null, null); // Refresh data grid
                        }
                        else
                        {
                            MessageBox.Show("No employee found with the given ID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating employee:\n" + ex.Message);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)       //insert records to the database when this button clicked
        {
            try
            {
               // string connectionString = @"Data Source=DESKTOP-3UCJTDT\SQLEXPRESS;Initial Catalog=POS;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO EmployeeTable 
                            (EmployeeID,EmployeeName, EmployeeNIC, EmployeeTeleNo, EmployeeAddress, EmployeeEmail, EmployeeRole, EmployeeGender, EmployeeSalary, EmployeeUserName, EmployeePassword, EmployeePhoto) 
                            VALUES 
                            (@ID,@Name, @NIC, @Tel, @Address, @Email, @Role, @Gender, @Salary, @Username, @Password, @Image)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Collect form values
                        cmd.Parameters.AddWithValue("@ID", idtxt.Text);
                        cmd.Parameters.AddWithValue("@Name", nametxt.Text);
                        cmd.Parameters.AddWithValue("@NIC", nictxt.Text);
                        cmd.Parameters.AddWithValue("@Tel", telenotxt.Text);
                        cmd.Parameters.AddWithValue("@Address", addresstxt.Text);
                        cmd.Parameters.AddWithValue("@Email", emailtxt.Text);
                        cmd.Parameters.AddWithValue("@Role", jobtxt.Text);
                        cmd.Parameters.AddWithValue("@Gender", gendertxt.Text);

                        // Validate and parse salary
                        if (decimal.TryParse(salarytxt.Text, out decimal salary))
                        {
                            cmd.Parameters.AddWithValue("@Salary", salary);
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid salary.");
                            return;
                        }

                        cmd.Parameters.AddWithValue("@Username", usernametxt.Text);
                        cmd.Parameters.AddWithValue("@Password", passwordtxt.Text);

                        // Convert image to byte array
                        byte[] imageBytes = null;
                        if (pictureBox1.Image != null)
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                pictureBox1.Image.Save(ms, ImageFormat.Png);
                                imageBytes = ms.ToArray();
                            }
                        }

                        cmd.Parameters.Add("@Image", SqlDbType.VarBinary).Value = (object)imageBytes ?? DBNull.Value;

                        // Execute command
                        conn.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Employee added successfully!");
                            EmployeeDetails_Load(null, null); // Reload data grid
                        }
                        else
                        {
                            MessageBox.Show("Failed to add employee.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting employee:\n" + ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)    //delete the records when this button clicked
        {
            try
            {
                //string connectionString = @"Data Source=DESKTOP-3UCJTDT\SQLEXPRESS;Initial Catalog=POS;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM EmployeeTable WHERE EmployeeID = @ID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", idtxt.Text);

                        conn.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Employee deleted successfully!");
                            EmployeeDetails_Load(null, null); // Refresh data grid
                        }
                        else
                        {
                            MessageBox.Show("No employee found with the given ID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting employee:\n" + ex.Message);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)    //clear the form
        {
            idtxt.Clear();
            nametxt.Clear();
            nictxt.Clear();
            telenotxt.Clear();
            addresstxt.Clear();
            emailtxt.Clear();
            jobtxt.Clear();
            gendertxt.Clear();
            salarytxt.Clear();
            usernametxt.Clear();
            passwordtxt.Clear();
            pictureBox1.Image = null;
        }

        private void LoadEmployeeImage(string empId)
        {
            //string connectionString = @"Data Source=DESKTOP-3UCJTDT\SQLEXPRESS;Initial Catalog=POS;Integrated Security=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT EmployeePhoto FROM EmployeeTable WHERE EmployeeID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandTimeout = 60; // Increase timeout in case of large images
                        cmd.Parameters.AddWithValue("@ID", empId);
                        conn.Open();

                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            byte[] bytes = (byte[])result;
                            using (MemoryStream ms = new MemoryStream(bytes))
                            {
                                pictureBox1.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            pictureBox1.Image = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pictureBox1.Image = null;
            }
        }


        private void dataviewbox_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataviewbox.Rows[e.RowIndex];


                idtxt.Text = row.Cells[0].Value?.ToString();  // EmployeeId
                nametxt.Text = row.Cells[1].Value?.ToString();  // EmployeeName
                nictxt.Text = row.Cells[2].Value?.ToString();  // EmployeeNIC
                telenotxt.Text = row.Cells[3].Value?.ToString();  // EmployeeTeleNo
                addresstxt.Text = row.Cells[4].Value?.ToString();  // EmployeeAddress
                emailtxt.Text = row.Cells[5].Value?.ToString();  // EmployeeEmail
                jobtxt.Text = row.Cells[6].Value?.ToString();  // EmployeeRole
                gendertxt.Text = row.Cells[7].Value?.ToString();  // EmployeeGender
                salarytxt.Text = row.Cells[8].Value?.ToString();
                
                // EmployeeSalary
                usernametxt.Text = row.Cells[9].Value?.ToString();  // EmployeeUserName
                passwordtxt.Text = row.Cells[10].Value?.ToString();  // EmployeePassword
                

                LoadEmployeeImage(idtxt.Text);
            }
        }


    }
}
