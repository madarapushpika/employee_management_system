namespace basic_system
{
    partial class Labour_Management
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
            this.grpLabour = new System.Windows.Forms.GroupBox();
            this.lblLabourID = new System.Windows.Forms.Label();
            this.lblLabourName = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblLabourType = new System.Windows.Forms.Label();
            this.lblDailyRate = new System.Windows.Forms.Label();
            this.txtLabourID = new System.Windows.Forms.TextBox();
            this.txtLabourName = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtDailyRate = new System.Windows.Forms.TextBox();
            this.cmbLabourType = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblRecords = new System.Windows.Forms.Label();
            this.dgvLabour = new System.Windows.Forms.DataGridView();
            this.grpLabour.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLabour)).BeginInit();
            this.SuspendLayout();
            // 
            // grpLabour
            // 
            this.grpLabour.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpLabour.Controls.Add(this.txtAddress);
            this.grpLabour.Controls.Add(this.cmbLabourType);
            this.grpLabour.Controls.Add(this.txtDailyRate);
            this.grpLabour.Controls.Add(this.txtContact);
            this.grpLabour.Controls.Add(this.txtLabourName);
            this.grpLabour.Controls.Add(this.txtLabourID);
            this.grpLabour.Controls.Add(this.lblDailyRate);
            this.grpLabour.Controls.Add(this.lblLabourType);
            this.grpLabour.Controls.Add(this.lblAddress);
            this.grpLabour.Controls.Add(this.lblContact);
            this.grpLabour.Controls.Add(this.lblLabourName);
            this.grpLabour.Controls.Add(this.lblLabourID);
            this.grpLabour.Location = new System.Drawing.Point(28, 23);
            this.grpLabour.Name = "grpLabour";
            this.grpLabour.Size = new System.Drawing.Size(526, 348);
            this.grpLabour.TabIndex = 0;
            this.grpLabour.TabStop = false;
            this.grpLabour.Text = "Labour_Informations";
            // 
            // lblLabourID
            // 
            this.lblLabourID.AutoSize = true;
            this.lblLabourID.Location = new System.Drawing.Point(20, 33);
            this.lblLabourID.Name = "lblLabourID";
            this.lblLabourID.Size = new System.Drawing.Size(69, 16);
            this.lblLabourID.TabIndex = 0;
            this.lblLabourID.Text = "Labour_ID";
            // 
            // lblLabourName
            // 
            this.lblLabourName.AutoSize = true;
            this.lblLabourName.Location = new System.Drawing.Point(20, 83);
            this.lblLabourName.Name = "lblLabourName";
            this.lblLabourName.Size = new System.Drawing.Size(93, 16);
            this.lblLabourName.TabIndex = 1;
            this.lblLabourName.Text = "Labour_Name";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(20, 130);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(107, 16);
            this.lblContact.TabIndex = 2;
            this.lblContact.Text = "Contact_Number";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(20, 174);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 16);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address";
            // 
            // lblLabourType
            // 
            this.lblLabourType.AutoSize = true;
            this.lblLabourType.Location = new System.Drawing.Point(20, 267);
            this.lblLabourType.Name = "lblLabourType";
            this.lblLabourType.Size = new System.Drawing.Size(88, 16);
            this.lblLabourType.TabIndex = 4;
            this.lblLabourType.Text = "Labour_Type";
            // 
            // lblDailyRate
            // 
            this.lblDailyRate.AutoSize = true;
            this.lblDailyRate.Location = new System.Drawing.Point(20, 312);
            this.lblDailyRate.Name = "lblDailyRate";
            this.lblDailyRate.Size = new System.Drawing.Size(74, 16);
            this.lblDailyRate.TabIndex = 5;
            this.lblDailyRate.Text = "Daily_Rate";
            // 
            // txtLabourID
            // 
            this.txtLabourID.Location = new System.Drawing.Point(176, 30);
            this.txtLabourID.Name = "txtLabourID";
            this.txtLabourID.ReadOnly = true;
            this.txtLabourID.Size = new System.Drawing.Size(240, 22);
            this.txtLabourID.TabIndex = 6;
            // 
            // txtLabourName
            // 
            this.txtLabourName.Location = new System.Drawing.Point(176, 77);
            this.txtLabourName.Name = "txtLabourName";
            this.txtLabourName.Size = new System.Drawing.Size(240, 22);
            this.txtLabourName.TabIndex = 7;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(176, 124);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(240, 22);
            this.txtContact.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(176, 162);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(240, 79);
            this.txtAddress.TabIndex = 9;
            // 
            // txtDailyRate
            // 
            this.txtDailyRate.Location = new System.Drawing.Point(176, 305);
            this.txtDailyRate.Name = "txtDailyRate";
            this.txtDailyRate.Size = new System.Drawing.Size(240, 22);
            this.txtDailyRate.TabIndex = 10;
            // 
            // cmbLabourType
            // 
            this.cmbLabourType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLabourType.FormattingEnabled = true;
            this.cmbLabourType.Items.AddRange(new object[] {
            "Daily",
            "",
            "Temporary"});
            this.cmbLabourType.Location = new System.Drawing.Point(176, 259);
            this.cmbLabourType.Name = "cmbLabourType";
            this.cmbLabourType.Size = new System.Drawing.Size(240, 24);
            this.cmbLabourType.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.lblRecords);
            this.panel2.Controls.Add(this.dgvLabour);
            this.panel2.Location = new System.Drawing.Point(25, 401);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(992, 382);
            this.panel2.TabIndex = 5;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(907, 212);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(99, 71);
            this.btnMainMenu.TabIndex = 7;
            this.btnMainMenu.Text = "Mein Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(760, 217);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(107, 66);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(604, 217);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 66);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(907, 72);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 60);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(760, 71);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 61);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(604, 72);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 61);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Location = new System.Drawing.Point(0, 0);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(104, 16);
            this.lblRecords.TabIndex = 1;
            this.lblRecords.Text = "Labour Records";
            // 
            // dgvLabour
            // 
            this.dgvLabour.AllowUserToAddRows = false;
            this.dgvLabour.AllowUserToDeleteRows = false;
            this.dgvLabour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLabour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLabour.Location = new System.Drawing.Point(35, 34);
            this.dgvLabour.MultiSelect = false;
            this.dgvLabour.Name = "dgvLabour";
            this.dgvLabour.ReadOnly = true;
            this.dgvLabour.RowHeadersVisible = false;
            this.dgvLabour.RowHeadersWidth = 51;
            this.dgvLabour.RowTemplate.Height = 24;
            this.dgvLabour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLabour.Size = new System.Drawing.Size(920, 313);
            this.dgvLabour.TabIndex = 0;
            this.dgvLabour.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLabour_CellClick);
            this.dgvLabour.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerformance_CellContentClick);
            // 
            // Labour_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 850);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpLabour);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSearch);
            this.Name = "Labour_Management";
            this.Text = "Labour_Management";
            this.grpLabour.ResumeLayout(false);
            this.grpLabour.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLabour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLabour;
        private System.Windows.Forms.Label lblDailyRate;
        private System.Windows.Forms.Label lblLabourType;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblLabourName;
        private System.Windows.Forms.Label lblLabourID;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtLabourName;
        private System.Windows.Forms.TextBox txtLabourID;
        private System.Windows.Forms.ComboBox cmbLabourType;
        private System.Windows.Forms.TextBox txtDailyRate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.DataGridView dgvLabour;
    }
}