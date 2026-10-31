namespace basic_system
{
    partial class Form4
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
            this.button5 = new System.Windows.Forms.Button();
            this.dg_Students_details = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbdeactive = new System.Windows.Forms.CheckBox();
            this.cbactive = new System.Windows.Forms.CheckBox();
            this.rdfemale = new System.Windows.Forms.RadioButton();
            this.rdmale = new System.Windows.Forms.RadioButton();
            this.cmbstdno = new System.Windows.Forms.ComboBox();
            this.txtstdaddress = new System.Windows.Forms.TextBox();
            this.txtstdname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Students_details)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.dg_Students_details);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbdeactive);
            this.groupBox1.Controls.Add(this.cbactive);
            this.groupBox1.Controls.Add(this.rdfemale);
            this.groupBox1.Controls.Add(this.rdmale);
            this.groupBox1.Controls.Add(this.cmbstdno);
            this.groupBox1.Controls.Add(this.txtstdaddress);
            this.groupBox1.Controls.Add(this.txtstdname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(267, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(651, 727);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage Student Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(45, 510);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 26);
            this.button5.TabIndex = 17;
            this.button5.Text = "clear";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dg_Students_details
            // 
            this.dg_Students_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Students_details.Location = new System.Drawing.Point(32, 555);
            this.dg_Students_details.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dg_Students_details.Name = "dg_Students_details";
            this.dg_Students_details.RowHeadersWidth = 51;
            this.dg_Students_details.RowTemplate.Height = 24;
            this.dg_Students_details.Size = new System.Drawing.Size(588, 121);
            this.dg_Students_details.TabIndex = 16;
            this.dg_Students_details.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Students_details_CellContentClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(45, 448);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 28);
            this.button4.TabIndex = 15;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(243, 448);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 28);
            this.button3.TabIndex = 14;
            this.button3.Text = "Insert";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(243, 510);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 26);
            this.button2.TabIndex = 13;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(473, 55);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbdeactive
            // 
            this.cbdeactive.AutoSize = true;
            this.cbdeactive.Location = new System.Drawing.Point(412, 385);
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
            this.cbactive.Location = new System.Drawing.Point(243, 385);
            this.cbactive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbactive.Name = "cbactive";
            this.cbactive.Size = new System.Drawing.Size(66, 20);
            this.cbactive.TabIndex = 10;
            this.cbactive.Text = "Active";
            this.cbactive.UseVisualStyleBackColor = true;
            // 
            // rdfemale
            // 
            this.rdfemale.AutoSize = true;
            this.rdfemale.Location = new System.Drawing.Point(412, 327);
            this.rdfemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdfemale.Name = "rdfemale";
            this.rdfemale.Size = new System.Drawing.Size(74, 20);
            this.rdfemale.TabIndex = 9;
            this.rdfemale.TabStop = true;
            this.rdfemale.Text = "Female";
            this.rdfemale.UseVisualStyleBackColor = true;
            // 
            // rdmale
            // 
            this.rdmale.AutoSize = true;
            this.rdmale.Location = new System.Drawing.Point(243, 327);
            this.rdmale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdmale.Name = "rdmale";
            this.rdmale.Size = new System.Drawing.Size(58, 20);
            this.rdmale.TabIndex = 8;
            this.rdmale.TabStop = true;
            this.rdmale.Text = "Male";
            this.rdmale.UseVisualStyleBackColor = true;
            // 
            // cmbstdno
            // 
            this.cmbstdno.FormattingEnabled = true;
            this.cmbstdno.Items.AddRange(new object[] {
            "Std 1",
            "Std 2",
            "Std 3",
            "Std 4"});
            this.cmbstdno.Location = new System.Drawing.Point(243, 55);
            this.cmbstdno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbstdno.Name = "cmbstdno";
            this.cmbstdno.Size = new System.Drawing.Size(132, 24);
            this.cmbstdno.TabIndex = 7;
            this.cmbstdno.SelectedIndexChanged += new System.EventHandler(this.cmbstdno_SelectedIndexChanged);
            // 
            // txtstdaddress
            // 
            this.txtstdaddress.Location = new System.Drawing.Point(243, 198);
            this.txtstdaddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtstdaddress.Multiline = true;
            this.txtstdaddress.Name = "txtstdaddress";
            this.txtstdaddress.Size = new System.Drawing.Size(219, 74);
            this.txtstdaddress.TabIndex = 6;
            // 
            // txtstdname
            // 
            this.txtstdname.Location = new System.Drawing.Point(243, 123);
            this.txtstdname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtstdname.Name = "txtstdname";
            this.txtstdname.Size = new System.Drawing.Size(132, 22);
            this.txtstdname.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Select(Status)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Select(Gender)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Student Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Student  Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Student Number";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 750);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Students_details)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbdeactive;
        private System.Windows.Forms.CheckBox cbactive;
        private System.Windows.Forms.RadioButton rdfemale;
        private System.Windows.Forms.RadioButton rdmale;
        private System.Windows.Forms.ComboBox cmbstdno;
        private System.Windows.Forms.TextBox txtstdaddress;
        private System.Windows.Forms.TextBox txtstdname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_Students_details;
        private System.Windows.Forms.Button button5;
    }
}