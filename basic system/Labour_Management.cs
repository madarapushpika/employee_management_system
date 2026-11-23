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
    public partial class Labour_Management : Form
    {
        string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Madara;Integrated Security=True;";
    
        public Labour_Management()
        {
            InitializeComponent();
            LoadLabour();
        }
        private void LoadLabour()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Labour";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvLabour.DataSource = dt;
            }
        }

        private void dgvPerformance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLabour.Rows[e.RowIndex];

                txtLabourID.Text = row.Cells["Labour_ID"].Value.ToString();
                txtLabourName.Text = row.Cells["Labour_Name"].Value.ToString();
                txtContact.Text = row.Cells["Contact_No"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                cmbLabourType.Text = row.Cells["Labour_Type"].Value.ToString();
                txtDailyRate.Text = row.Cells["Daily_Rate"].Value.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLabourID.Clear();
            txtLabourName.Clear();
            txtContact.Clear();
            txtAddress.Clear();
            cmbLabourType.SelectedIndex = -1;
            txtDailyRate.Clear();

            dgvLabour.ClearSelection();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            decimal rate;

            if (!decimal.TryParse(txtDailyRate.Text, out rate))
            {
                MessageBox.Show("Please enter a valid Daily Rate.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Labour (Labour_Name, Contact_No, Address, Labour_Type, Daily_Rate) VALUES (@Name, @Contact, @Address, @Type, @Rate)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Name", txtLabourName.Text);
                cmd.Parameters.AddWithValue("@Contact", txtContact.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Type", cmbLabourType.Text);
                cmd.Parameters.AddWithValue("@Rate", rate);

                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Labour details saved successfully!");

                LoadLabour();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Labour WHERE Labour_Name LIKE @Name";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", "%" + txtLabourName.Text + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvLabour.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No labour records found!");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            decimal rate;

            if (!decimal.TryParse(txtDailyRate.Text, out rate))
            {
                MessageBox.Show("Please enter a valid Daily Rate.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Labour 
                         SET Labour_Name = @Name,
                             Contact_No = @Contact,
                             Address = @Address,
                             Labour_Type = @Type,
                             Daily_Rate = @Rate
                         WHERE Labour_ID = @ID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@ID", txtLabourID.Text);
                cmd.Parameters.AddWithValue("@Name", txtLabourName.Text);
                cmd.Parameters.AddWithValue("@Contact", txtContact.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Type", cmbLabourType.Text);
                cmd.Parameters.AddWithValue("@Rate", rate);

                con.Open();

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Labour details updated successfully!");
                    LoadLabour();
                }
                else
                {
                    MessageBox.Show("Labour record not found!");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
     
            if (txtLabourID.Text == "")
            {
                MessageBox.Show("Please select a labour record first!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Labour WHERE Labour_ID = @ID";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ID", txtLabourID.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Labour record deleted successfully!");

                    LoadLabour();
                }
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvLabour_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
