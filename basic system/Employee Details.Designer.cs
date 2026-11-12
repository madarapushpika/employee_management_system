namespace basic_system
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbdeactive = new System.Windows.Forms.CheckBox();
            this.cbactive = new System.Windows.Forms.CheckBox();
            this.rdfemale = new System.Windows.Forms.RadioButton();
            this.rdmale = new System.Windows.Forms.RadioButton();
            this.cmbempno = new System.Windows.Forms.ComboBox();
            this.txtempaddress = new System.Windows.Forms.TextBox();
            this.txtempname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbdeactive);
            this.groupBox1.Controls.Add(this.cbactive);
            this.groupBox1.Controls.Add(this.rdfemale);
            this.groupBox1.Controls.Add(this.rdmale);
            this.groupBox1.Controls.Add(this.cmbempno);
            this.groupBox1.Controls.Add(this.txtempaddress);
            this.groupBox1.Controls.Add(this.txtempname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(125, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(889, 585);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage Employee Details";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(114, 473);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 28);
            this.button4.TabIndex = 15;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(387, 473);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 28);
            this.button3.TabIndex = 14;
            this.button3.Text = "Insert";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(387, 530);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 26);
            this.button2.TabIndex = 13;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(639, 86);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbdeactive
            // 
            this.cbdeactive.AutoSize = true;
            this.cbdeactive.Location = new System.Drawing.Point(532, 417);
            this.cbdeactive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbdeactive.Name = "cbdeactive";
            this.cbdeactive.Size = new System.Drawing.Size(83, 20);
            this.cbdeactive.TabIndex = 11;
            this.cbdeactive.Text = "Deactive";
            this.cbdeactive.UseVisualStyleBackColor = true;
            // 
            // cbactive
            // 
            this.cbactive.AutoSize = true;
            this.cbactive.Location = new System.Drawing.Point(340, 417);
            this.cbactive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbactive.Name = "cbactive";
            this.cbactive.Size = new System.Drawing.Size(66, 20);
            this.cbactive.TabIndex = 10;
            this.cbactive.Text = "Active";
            this.cbactive.UseVisualStyleBackColor = true;
            this.cbactive.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // rdfemale
            // 
            this.rdfemale.AutoSize = true;
            this.rdfemale.Location = new System.Drawing.Point(532, 353);
            this.rdfemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdfemale.Name = "rdfemale";
            this.rdfemale.Size = new System.Drawing.Size(74, 20);
            this.rdfemale.TabIndex = 9;
            this.rdfemale.TabStop = true;
            this.rdfemale.Text = "Female";
            this.rdfemale.UseVisualStyleBackColor = true;
            this.rdfemale.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdmale
            // 
            this.rdmale.AutoSize = true;
            this.rdmale.Location = new System.Drawing.Point(340, 353);
            this.rdmale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdmale.Name = "rdmale";
            this.rdmale.Size = new System.Drawing.Size(58, 20);
            this.rdmale.TabIndex = 8;
            this.rdmale.TabStop = true;
            this.rdmale.Text = "Male";
            this.rdmale.UseVisualStyleBackColor = true;
            // 
            // cmbempno
            // 
            this.cmbempno.FormattingEnabled = true;
            this.cmbempno.Items.AddRange(new object[] {
            "Ep 1",
            "Ep 2",
            "Ep 3",
            "Ep 4",
            "Ep5",
            "Ep6"});
            this.cmbempno.Location = new System.Drawing.Point(340, 90);
            this.cmbempno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbempno.Name = "cmbempno";
            this.cmbempno.Size = new System.Drawing.Size(132, 24);
            this.cmbempno.TabIndex = 7;
            this.cmbempno.SelectedIndexChanged += new System.EventHandler(this.cmbempno_SelectedIndexChanged);
            // 
            // txtempaddress
            // 
            this.txtempaddress.Location = new System.Drawing.Point(340, 271);
            this.txtempaddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtempaddress.Multiline = true;
            this.txtempaddress.Name = "txtempaddress";
            this.txtempaddress.Size = new System.Drawing.Size(438, 66);
            this.txtempaddress.TabIndex = 6;
            this.txtempaddress.TextChanged += new System.EventHandler(this.txtempaddress_TextChanged);
            // 
            // txtempname
            // 
            this.txtempname.Location = new System.Drawing.Point(340, 173);
            this.txtempname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtempname.Name = "txtempname";
            this.txtempname.Size = new System.Drawing.Size(132, 22);
            this.txtempname.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Select(Status)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Select(Gender)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Employee Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Employee Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Employee Number";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 622);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbdeactive;
        private System.Windows.Forms.CheckBox cbactive;
        private System.Windows.Forms.RadioButton rdfemale;
        private System.Windows.Forms.RadioButton rdmale;
        private System.Windows.Forms.ComboBox cmbempno;
        private System.Windows.Forms.TextBox txtempaddress;
        private System.Windows.Forms.TextBox txtempname;
    }
}