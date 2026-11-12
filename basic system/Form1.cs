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
            string un = txtun.Text.Trim();
            string pwd = txtpwd.Text;

            if (string.IsNullOrWhiteSpace(un) ||
                string.IsNullOrWhiteSpace(pwd))
            {
                MessageBox.Show("Please enter username and password");
            }
            else if (un == "user" && pwd == "123")
            {
                MessageBox.Show("Login successful");

                this.Hide();

                Form2 mm = new Form2();
                mm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void txtun_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

