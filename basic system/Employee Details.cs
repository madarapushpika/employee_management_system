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
            try
            {
                if (cmbempno.SelectedItem == null)
                {
                    MessageBox.Show("Please select Employee Number");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtempname.Text) ||
                    string.IsNullOrWhiteSpace(txtempaddress.Text))
                {
                    MessageBox.Show("Please enter Employee Name and Address");
                    return;
                }

                if (!rdmale.Checked && !rdfemale.Checked)
                {
                    MessageBox.Show("Please select Gender");
                    return;
                }

                string empno = cmbempno.SelectedItem.ToString();
                string empname = txtempname.Text.Trim();
                string empaddress = txtempaddress.Text.Trim();

                char gender = rdmale.Checked ? 'M' : 'F';
                char status = cbactive.Checked ? 'A' : 'D';

                using (SqlConnection sqlcon = new SqlConnection(
                    "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Madara;Integrated Security=True;"))
                {
                    sqlcon.Open();

                    SqlCommand sqlcmd = new SqlCommand(
                        "UPDATE Employees SET Name = @Name, Address = @Address, Gender = @Gender, Status = @Status WHERE Emp_No = @Emp_No",
                        sqlcon);

                    sqlcmd.Parameters.AddWithValue("@Name", empname);
                    sqlcmd.Parameters.AddWithValue("@Address", empaddress);
                    sqlcmd.Parameters.AddWithValue("@Gender", gender);
                    sqlcmd.Parameters.AddWithValue("@Status", status);
                    sqlcmd.Parameters.AddWithValue("@Emp_No", empno);

                    int result = sqlcmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Employee Updated Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Employee not found!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbempno.SelectedItem == null)
                {
                    MessageBox.Show("Please select Employee Number");
                    return;
                }

                string empno = cmbempno.SelectedItem.ToString();

                using (SqlConnection sqlcon = new SqlConnection(
                    "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Madara;Integrated Security=True;"))
                {
                    sqlcon.Open();

                    SqlCommand sqlcmd = new SqlCommand(
                        "SELECT * FROM Employees WHERE Emp_No = @Emp_No", sqlcon);

                    sqlcmd.Parameters.AddWithValue("@Emp_No", empno);

                    SqlDataReader reader = sqlcmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtempname.Text = reader["Name"].ToString();
                        txtempaddress.Text = reader["Address"].ToString();

                        string gender = reader["Gender"].ToString();

                        if (gender == "M")
                        {
                            rdmale.Checked = true;
                            rdfemale.Checked = false;
                        }
                        else
                        {
                            rdfemale.Checked = true;
                            rdmale.Checked = false;
                        }

                        string status = reader["Status"].ToString();

                        if (status == "A")
                        {
                            cbactive.Checked = true;
                            cbdeactive.Checked = false;
                        }
                        else
                        {
                            cbactive.Checked = false;
                            cbdeactive.Checked = true;
                        }

                        MessageBox.Show("Employee Found Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Employee Not Found!");
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                if (cmbempno.SelectedItem == null)
                {
                    MessageBox.Show("Please select Employee Number");
                    return;
                }

                string empno = cmbempno.SelectedItem.ToString();

                DialogResult confirm = MessageBox.Show(
                    "Are you sure you want to delete this employee?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    using (SqlConnection sqlcon = new SqlConnection(
                        "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Madara;Integrated Security=True;"))
                    {
                        sqlcon.Open();

                        SqlCommand sqlcmd = new SqlCommand(
                            "DELETE FROM Employees WHERE Emp_No = @Emp_No",
                            sqlcon);

                        sqlcmd.Parameters.AddWithValue("@Emp_No", empno);

                        int result = sqlcmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Employee Deleted Successfully!");

                            txtempname.Clear();
                            txtempaddress.Clear();
                            rdmale.Checked = false;
                            rdfemale.Checked = false;
                            cbactive.Checked = false;
                        }
                        else
                        {
                            MessageBox.Show("Employee not found!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}

