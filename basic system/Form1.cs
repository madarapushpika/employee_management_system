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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String un = "user";
            String pwd = "123";

            if (un.Equals("user") && pwd.Equals("123"))
            {
                MessageBox.Show("Login successful");

                this.Hide();// hide the previous form after login 
                Form2 mm = new Form2();
                mm.Show();// show the new form 
            }
            else { MessageBox.Show("login unsuccessful"); }
        
        }

        private void txtun_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

