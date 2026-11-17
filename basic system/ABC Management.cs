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
            LoadPerformance();
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

        private void LoadPerformance()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT 
                         p.Emp_No,
                         e.Name AS Emp_Name,
                         p.Score,
                         p.Category,
                         p.Remarks
                         FROM EmployeePerformance p
                         INNER JOIN Employees e
                         ON p.Emp_No = e.Emp_No";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvPerformance.DataSource = dt;
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

        private void txtscore_TextChanged(object sender, EventArgs e)
        {
            int score;

            if (int.TryParse(txtscore.Text, out score) && score >= 0 && score <= 100)
            {
                if (score >= 90)
                {
                    cmbcategory.SelectedIndex = 0;
                }
                else if (score >= 70)
                {
                    cmbcategory.SelectedIndex = 1;
                }
                else
                {
                    cmbcategory.SelectedIndex = 2;
                }
            }
            else
            {
                cmbcategory.SelectedIndex = -1;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int score;

            if (cmbempno.SelectedValue == null ||
                !int.TryParse(txtscore.Text, out score) ||
                score < 0 || score > 100 ||
                cmbcategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter valid employee and performance details.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO EmployeePerformance
                         (Emp_No, Score, Category)
                         VALUES (@Emp_No, @Score, @Category)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Emp_No", cmbempno.SelectedValue);
                cmd.Parameters.AddWithValue("@Score", score);
                cmd.Parameters.AddWithValue("@Category", cmbcategory.Text);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    LoadPerformance();

                    MessageBox.Show("Performance Details Saved Successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbempno.SelectedValue == null)
            {
                MessageBox.Show("Please select an Employee Number.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT Score, Category
                         FROM EmployeePerformance
                         WHERE Emp_No = @Emp_No";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Emp_No", cmbempno.SelectedValue);

                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtscore.Text = dr["Score"].ToString();
                    cmbcategory.Text = dr["Category"].ToString();
                }
                else
                {
                    MessageBox.Show("No Performance Record Found!");
                    txtscore.Clear();
                    cmbcategory.SelectedIndex = -1;
                }

                dr.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int score;

            if (cmbempno.SelectedValue == null ||
                !int.TryParse(txtscore.Text, out score) ||
                score < 0 || score > 100 ||
                cmbcategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter valid performance details.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"UPDATE EmployeePerformance
                         SET Score = @Score,
                             Category = @Category
                         WHERE Emp_No = @Emp_No";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Emp_No", cmbempno.SelectedValue);
                cmd.Parameters.AddWithValue("@Score", score);
                cmd.Parameters.AddWithValue("@Category", cmbcategory.Text);

                con.Open();

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    LoadPerformance();
                    MessageBox.Show("Performance Updated Successfully!");
                }
                else
                {
                    MessageBox.Show("No Performance Record Found!");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbempno.SelectedValue == null)
            {
                MessageBox.Show("Please select an Employee Number.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this performance record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM EmployeePerformance WHERE Emp_No = @Emp_No";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Emp_No", cmbempno.SelectedValue);

                    con.Open();

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        LoadPerformance();
                        txtscore.Clear();
                        cmbcategory.SelectedIndex = -1;

                        MessageBox.Show("Performance Record Deleted Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No Performance Record Found!");
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbempno.SelectedIndex = -1;
            txtempname.Clear();
            txtscore.Clear();
            cmbcategory.SelectedIndex = -1;

            cmbempno.Focus();
        }
    }
}
