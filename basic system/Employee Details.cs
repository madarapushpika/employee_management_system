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

namespace basic_system
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Get employee details
                if (cmbempno.SelectedItem == null)
                {
                    MessageBox.Show("Please select Employee Number");
                    return;
                }

                string empno = cmbempno.SelectedItem.ToString();
                string empname = txtempname.Text.Trim();
                string empaddress = txtempaddress.Text.Trim();

                // Get Gender
                char gender;

                if (rdmale.Checked == true)
                {
                    gender = 'M';
                }
                else
                {
                    gender = 'F';
                }

                // Get Status
                char status;

                if (cbactive.Checked == true)
                {
                    status = 'A';
                }
                else
                {
                    status = 'D';
                }

                // Database connection
                using (SqlConnection sqlcon = new SqlConnection(
                    "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Madara;Integrated Security=True;"))
                {
                    sqlcon.Open();

                    // SQL query
                    SqlCommand sqlcmd = new SqlCommand(
                        "INSERT INTO Employees (Emp_No, Name, Address, Gender, Status) VALUES (@Emp_No, @Name, @Address, @Gender, @Status)",
                        sqlcon);

                    // Add parameters
                    sqlcmd.Parameters.AddWithValue("@Emp_No", empno);
                    sqlcmd.Parameters.AddWithValue("@Name", empname);
                    sqlcmd.Parameters.AddWithValue("@Address", empaddress);
                    sqlcmd.Parameters.AddWithValue("@Gender", gender);
                    sqlcmd.Parameters.AddWithValue("@Status", status);

                    // Execute query
                    sqlcmd.ExecuteNonQuery();
                }

                MessageBox.Show("Employee Inserted Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmbempno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtempaddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
