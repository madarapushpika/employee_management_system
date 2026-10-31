using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            String epmno= cmbempno.SelectedItem.ToString();
            String empname=txtempname.Text;
            String empaddress=txtempaddress.Text;

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


            MessageBox.Show("Emp No = " + epmno + "\n" +
                            "Emp name = " + empname + "\n" +
                            "Emp Addreess = "+ empaddress+"\n"+
                            "Gender = "+gender+"\n"+
                            "Status = "+status+"\n");
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
