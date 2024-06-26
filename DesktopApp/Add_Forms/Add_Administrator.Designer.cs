﻿namespace DesktopApp
{
    partial class Add_Administrator
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            AddAdminBtn = new Button();
            label9 = new Label();
            AddAdminEmail = new TextBox();
            label7 = new Label();
            label6 = new Label();
            AddAdminPhone = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            AddAdminA = new TextBox();
            AddAdminN = new TextBox();
            AddAdminDOB = new DateTimePicker();
            AddAdminGender = new ComboBox();
            panel2 = new Panel();
            AddAdminDep = new ComboBox();
            AddAdminStatus = new ComboBox();
            AddAdminPost = new ComboBox();
            Deletebtn = new Button();
            UpdateAdmin = new Button();
            administratorsBindingSource = new BindingSource(components);
            AdminData = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DoB = new DataGridViewTextBoxColumn();
            departmentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            postDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            AdminId = new TextBox();
            Searchbtn = new Button();
            SearchBox = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)administratorsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AdminData).BeginInit();
            SuspendLayout();
            // 
            // AddAdminBtn
            // 
            AddAdminBtn.Anchor = AnchorStyles.Top;
            AddAdminBtn.BackColor = Color.MediumSeaGreen;
            AddAdminBtn.ForeColor = Color.White;
            AddAdminBtn.Location = new Point(548, 219);
            AddAdminBtn.Name = "AddAdminBtn";
            AddAdminBtn.Size = new Size(86, 29);
            AddAdminBtn.TabIndex = 68;
            AddAdminBtn.Text = "Add New";
            AddAdminBtn.UseVisualStyleBackColor = false;
            AddAdminBtn.Click += AddAdminBtn_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Location = new Point(292, 21);
            label9.Name = "label9";
            label9.Size = new Size(73, 15);
            label9.TabIndex = 67;
            label9.Text = "Department:";
            // 
            // AddAdminEmail
            // 
            AddAdminEmail.Anchor = AnchorStyles.Top;
            AddAdminEmail.Location = new Point(305, 163);
            AddAdminEmail.Name = "AddAdminEmail";
            AddAdminEmail.Size = new Size(232, 23);
            AddAdminEmail.TabIndex = 49;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Location = new Point(292, 145);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 65;
            label7.Text = "Email:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(586, 145);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 64;
            label6.Text = "Status:";
            // 
            // AddAdminPhone
            // 
            AddAdminPhone.Anchor = AnchorStyles.Top;
            AddAdminPhone.Location = new Point(599, 104);
            AddAdminPhone.MaxLength = 10;
            AddAdminPhone.Name = "AddAdminPhone";
            AddAdminPhone.Size = new Size(232, 23);
            AddAdminPhone.TabIndex = 61;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Location = new Point(292, 86);
            label11.Name = "label11";
            label11.Size = new Size(33, 15);
            label11.TabIndex = 57;
            label11.Text = "Post:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Location = new Point(586, 86);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 56;
            label10.Text = "Phone:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(14, 145);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 55;
            label5.Text = "Address:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(14, 79);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 54;
            label4.Text = "Date of Birth:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(586, 21);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 53;
            label3.Text = "Gender:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(14, 19);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 52;
            label1.Text = "Name:";
            // 
            // AddAdminA
            // 
            AddAdminA.Anchor = AnchorStyles.Top;
            AddAdminA.Location = new Point(21, 163);
            AddAdminA.Name = "AddAdminA";
            AddAdminA.Size = new Size(216, 23);
            AddAdminA.TabIndex = 58;
            // 
            // AddAdminN
            // 
            AddAdminN.Anchor = AnchorStyles.Top;
            AddAdminN.Location = new Point(21, 39);
            AddAdminN.Name = "AddAdminN";
            AddAdminN.Size = new Size(216, 23);
            AddAdminN.TabIndex = 63;
            // 
            // AddAdminDOB
            // 
            AddAdminDOB.Anchor = AnchorStyles.Top;
            AddAdminDOB.Format = DateTimePickerFormat.Short;
            AddAdminDOB.Location = new Point(21, 101);
            AddAdminDOB.Name = "AddAdminDOB";
            AddAdminDOB.Size = new Size(216, 23);
            AddAdminDOB.TabIndex = 70;
            // 
            // AddAdminGender
            // 
            AddAdminGender.Anchor = AnchorStyles.Top;
            AddAdminGender.FormattingEnabled = true;
            AddAdminGender.Items.AddRange(new object[] { "Male", "Female" });
            AddAdminGender.Location = new Point(599, 39);
            AddAdminGender.Name = "AddAdminGender";
            AddAdminGender.Size = new Size(232, 23);
            AddAdminGender.TabIndex = 71;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left;
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(AddAdminDep);
            panel2.Controls.Add(AddAdminStatus);
            panel2.Controls.Add(AddAdminPost);
            panel2.Controls.Add(Deletebtn);
            panel2.Controls.Add(UpdateAdmin);
            panel2.Controls.Add(AddAdminPhone);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(AddAdminGender);
            panel2.Controls.Add(AddAdminBtn);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(AddAdminDOB);
            panel2.Controls.Add(AddAdminEmail);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(AddAdminN);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(AddAdminA);
            panel2.Location = new Point(40, 408);
            panel2.Name = "panel2";
            panel2.Size = new Size(854, 264);
            panel2.TabIndex = 73;
            // 
            // AddAdminDep
            // 
            AddAdminDep.FormattingEnabled = true;
            AddAdminDep.Items.AddRange(new object[] { "Education", "Finance" });
            AddAdminDep.Location = new Point(305, 45);
            AddAdminDep.Name = "AddAdminDep";
            AddAdminDep.Size = new Size(232, 23);
            AddAdminDep.TabIndex = 77;
            // 
            // AddAdminStatus
            // 
            AddAdminStatus.Anchor = AnchorStyles.Top;
            AddAdminStatus.FormattingEnabled = true;
            AddAdminStatus.Items.AddRange(new object[] { "Married", "Single", "Others" });
            AddAdminStatus.Location = new Point(599, 163);
            AddAdminStatus.Name = "AddAdminStatus";
            AddAdminStatus.Size = new Size(232, 23);
            AddAdminStatus.TabIndex = 76;
            // 
            // AddAdminPost
            // 
            AddAdminPost.Anchor = AnchorStyles.Top;
            AddAdminPost.FormattingEnabled = true;
            AddAdminPost.Items.AddRange(new object[] { "Bursar", "Dean", "Registrar", "Rector", "Deputy Dean", "Head of Department" });
            AddAdminPost.Location = new Point(305, 104);
            AddAdminPost.Name = "AddAdminPost";
            AddAdminPost.Size = new Size(232, 23);
            AddAdminPost.TabIndex = 74;
            // 
            // Deletebtn
            // 
            Deletebtn.Anchor = AnchorStyles.Top;
            Deletebtn.BackColor = Color.Red;
            Deletebtn.ForeColor = Color.White;
            Deletebtn.Location = new Point(764, 219);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(76, 29);
            Deletebtn.TabIndex = 73;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = false;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // UpdateAdmin
            // 
            UpdateAdmin.Anchor = AnchorStyles.Top;
            UpdateAdmin.BackColor = Color.Blue;
            UpdateAdmin.ForeColor = Color.White;
            UpdateAdmin.Location = new Point(665, 219);
            UpdateAdmin.Name = "UpdateAdmin";
            UpdateAdmin.Size = new Size(77, 29);
            UpdateAdmin.TabIndex = 72;
            UpdateAdmin.Text = "Edit";
            UpdateAdmin.UseVisualStyleBackColor = false;
            UpdateAdmin.Click += UpdateAdmin_Click;
            // 
            // administratorsBindingSource
            // 
            administratorsBindingSource.DataSource = typeof(Code_First.Models.Administrators);
            // 
            // AdminData
            // 
            AdminData.AllowUserToAddRows = false;
            AdminData.AllowUserToDeleteRows = false;
            AdminData.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AdminData.AutoGenerateColumns = false;
            AdminData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdminData.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, DoB, departmentDataGridViewTextBoxColumn, postDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, phoneDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn });
            AdminData.DataSource = administratorsBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            AdminData.DefaultCellStyle = dataGridViewCellStyle3;
            AdminData.Location = new Point(12, 43);
            AdminData.Name = "AdminData";
            AdminData.ReadOnly = true;
            AdminData.RowTemplate.Height = 25;
            AdminData.Size = new Size(925, 348);
            AdminData.TabIndex = 72;
            AdminData.CellContentClick += AdminData_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DoB
            // 
            DoB.DataPropertyName = "DoB";
            DoB.HeaderText = "DoB";
            DoB.Name = "DoB";
            DoB.ReadOnly = true;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            departmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postDataGridViewTextBoxColumn
            // 
            postDataGridViewTextBoxColumn.DataPropertyName = "Post";
            postDataGridViewTextBoxColumn.HeaderText = "Post";
            postDataGridViewTextBoxColumn.Name = "postDataGridViewTextBoxColumn";
            postDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AdminId
            // 
            AdminId.Location = new Point(215, 286);
            AdminId.Name = "AdminId";
            AdminId.Size = new Size(100, 23);
            AdminId.TabIndex = 74;
            // 
            // Searchbtn
            // 
            Searchbtn.Location = new Point(862, 14);
            Searchbtn.Name = "Searchbtn";
            Searchbtn.Size = new Size(75, 23);
            Searchbtn.TabIndex = 75;
            Searchbtn.Text = "Search";
            Searchbtn.UseVisualStyleBackColor = true;
            Searchbtn.Click += Searchbtn_Click;
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(727, 14);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(210, 23);
            SearchBox.TabIndex = 76;
            // 
            // Add_Administrator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(949, 684);
            Controls.Add(Searchbtn);
            Controls.Add(panel2);
            Controls.Add(AdminData);
            Controls.Add(AdminId);
            Controls.Add(SearchBox);
            Name = "Add_Administrator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrators";
            Load += Add_Administrator_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)administratorsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)AdminData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddAdminBtn;
        private Label label9;
        private TextBox AddAdminEmail;
        private TextBox AddAdminDepartment;
        private Label label7;
        private Label label6;
        private TextBox AddAdminPhone;
        private Label label11;
        private Label label10;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox AddAdminA;
        private TextBox AddAdminN;
        private DateTimePicker AddAdminDOB;
        private ComboBox AddAdminGender;
        private Panel panel2;
        private BindingSource administratorsBindingSource;
        private DataGridView AdminData;
        private Button UpdateAdmin;
        private TextBox AdminId;
        private Button Deletebtn;
        private DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private ComboBox AddAdminStatus;
        private ComboBox comboBox2;
        private ComboBox AddAdminPost;
        private ComboBox comboBox1;
        private ComboBox AddAdminDep;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn DoB;
        private DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn postDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private Button Searchbtn;
        private TextBox SearchBox;
    }
}