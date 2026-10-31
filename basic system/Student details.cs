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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String stdno = cmbstdno.SelectedItem.ToString();
            String stdname = txtstdname.Text;
            String stdaddress = txtstdaddress.Text;

            //radio button
            char gender;
            if (rdmale.Checked == true)
            { gender = 'M'; }
            else { gender = 'F'; }

            //checl box code
            char status;
            if (cbactive.Checked == true)
            { status = 'A'; }
            else { status = 'D'; }


            /*MessageBox.Show("Std No = " + stdno + "\n" +
                            "Std name = " + stdname + "\n" +
                            "Std Addreess = " + stdaddress + "\n" +
                            "Gender = " + gender + "\n" +
                            "Status = " + status + "\n");
            */
            //create the SQL connection
            SqlConnection sqlcon = new SqlConnection("Data Source = localhost\\SQLEXPRESS; Initial catalog = Madara; Integrated Security= True;");

            //Openining the connection 
            sqlcon.Open();

            //Sql query
            SqlCommand sqlcmd = new SqlCommand("insert into Students values (@St_No,@Name,@Address,@Gender,@Status)", sqlcon);

            //Equalling Parameaters to relevent db columns
            sqlcmd.Parameters.AddWithValue("@St_No", stdno);
            sqlcmd.Parameters.AddWithValue("@Name", stdname);
            sqlcmd.Parameters.AddWithValue("@Address", stdaddress);
            sqlcmd.Parameters.AddWithValue("@Gender", gender);
            sqlcmd.Parameters.AddWithValue("@Status", status);

            //To Execute
            sqlcmd.ExecuteNonQuery();

            //closing thw con
            sqlcon.Close();

            MessageBox.Show("Inserted Successfull");

            //method calling - clearing fields
            button5_Click(sender, e);

            //real time - I've called the method of from load
            groupBox1_Enter(sender, e);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

            //sql connection
            SqlConnection sqlcon = new SqlConnection("Data Source = localhost\\SQLEXPRESS; Initial catalog = Madara; Integrated Security = True;");

            //Opening the con 
            sqlcon.Open();

            //Sql query
            SqlCommand sqlcmd = new SqlCommand("select * from Students ",sqlcon);

            //To retreive data from sql, Use this Library SqlDataAdapter
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);

            //To set tab retrievd data, User this LIbrary Datatable 
            DataTable dt = new DataTable();
            da.Fill(dt);
            dg_Students_details.DataSource = dt;

            MessageBox.Show("Search Succesfull !");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Combo box
            String stno = cmbstdno.SelectedItem.ToString();

            //sql connection
            SqlConnection sqlcon = new SqlConnection("Data Source = localhost\\SQLEXPRESS; Initial catalog = Madara; Integrated Security = True;");

            //Oepen the con 
            sqlcon.Open();

            //Sql query
            SqlCommand sqlcmd = new SqlCommand("select * from Students where St_No = @St_No", sqlcon);

            //Equalling parameters to relevant columns
            sqlcmd.Parameters.AddWithValue("St_No", stno);

            //To retreive data from sql, Use this Library SqlDataAdapter
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);

            //To set tab retrievd data, User this LIbrary Datatable 
            DataTable dt = new DataTable();
            da.Fill(dt);
            dg_Students_details.DataSource = dt;

            MessageBox.Show("Search Succesfull !");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String stdno = cmbstdno.SelectedItem.ToString();
            String stdname = txtstdname.Text;
            String stdaddress = txtstdaddress.Text;

            //radio button
            char gender;
            if (rdmale.Checked == true)
            { gender = 'M'; }
            else { gender = 'F'; }

            //checl box code
            char status;
            if (cbactive.Checked == true)
            { status = 'A'; }
            else { status = 'D'; }


            /*MessageBox.Show("Std No = " + stdno + "\n" +
                            "Std name = " + stdname + "\n" +
                            "Std Addreess = " + stdaddress + "\n" +
                            "Gender = " + gender + "\n" +
                            "Status = " + status + "\n");
            */
            //create the SQL connection
            SqlConnection sqlcon = new SqlConnection("Data Source = localhost\\SQLEXPRESS; Initial catalog = Madara; Integrated Security= True;");

            //Openining the connection 
            sqlcon.Open();

            //Sql query
            SqlCommand sqlcmd = new SqlCommand("Update Students set Name = @Name , Address = @Address , Gender = @Gender , @Status = @Status where St_No = @St_No", sqlcon);

            //Equalling Parameaters to relevent db columns
            sqlcmd.Parameters.AddWithValue("@St_No", stdno);
            sqlcmd.Parameters.AddWithValue("@Name", stdname);
            sqlcmd.Parameters.AddWithValue("@Address", stdaddress);
            sqlcmd.Parameters.AddWithValue("@Gender", gender);
            sqlcmd.Parameters.AddWithValue("@Status", status);

            //To Execute
            sqlcmd.ExecuteNonQuery();

            //closing thw con
            sqlcon.Close();

            MessageBox.Show("Inserted Successfull");

            //method calling - clearing fields
            button5_Click(sender, e);

            //real time - I've called the method of from load
            groupBox1_Enter(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cmbstdno.Text = ("");
            txtstdname.Text = ("");
            txtstdaddress.Text = ("");
            rdmale.Checked = false;
            rdfemale.Checked = false;
            cbactive.Checked = false;
            cbdeactive.Checked = false;



        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Do something
            //Combo box
            String st_no = cmbstdno.SelectedItem.ToString();

            //sql connection
            SqlConnection sqlcon = new SqlConnection("Data Source = localhost\\SQLEXPRESS; Initial catalog = Madara; Integrated Security = True;");

            //Oepen the con 
            sqlcon.Open();

            //Sql query
            SqlCommand sqlcmd = new SqlCommand("Delete from Students where St_No = @St_No", sqlcon);

            //Equalling parameters to relevant columns
            sqlcmd.Parameters.AddWithValue("St_No", st_no);

            //To execute
            sqlcmd.ExecuteNonQuery();

            //Closing the connection
            sqlcon.Close();

            MessageBox.Show("Delete Succesfull !");

            //method calling - clearing fields
            button5_Click(sender, e);

            //real time - I've called the method of from load
            groupBox1_Enter(sender, e);
        }

        private void dg_Students_details_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbstdno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

