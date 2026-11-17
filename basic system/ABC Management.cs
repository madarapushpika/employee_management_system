using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace basic_system
{
    public partial class ABC_Management : Form
    {
        string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Madara;Integrated Security=True;";
        public ABC_Management()
        {
            InitializeComponent();
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT Emp_No FROM Employees", con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbempno.DataSource = dt;
                cmbempno.DisplayMember = "Emp_No";
                cmbempno.ValueMember = "Emp_No";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ABC_Management_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT Emp_No FROM Employees", con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbempno.DataSource = dt;
                cmbempno.DisplayMember = "Emp_No";
                cmbempno.ValueMember = "Emp_No";
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbcategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbempno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbempno.SelectedValue == null)
                return;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT Name FROM Employees WHERE Emp_No = @Emp_No";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Emp_No", cmbempno.SelectedValue);

                con.Open();

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    txtempname.Text = result.ToString();
                }
            }
        }
    }
}
