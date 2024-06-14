namespace DesktopApp
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
            AddAdminBtn = new Button();
            label9 = new Label();
            AddAdminStatus = new TextBox();
            AddAdminEmail = new TextBox();
            AddAdminSalary = new TextBox();
            AddAdminDepartment = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            AddAdminPhone = new TextBox();
            AddAdminPost = new TextBox();
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
            UpdateAdmin = new Button();
            button9 = new Button();
            administratorsBindingSource = new BindingSource(components);
            AdminData = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            departmentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            postDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dobDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
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
            AddAdminBtn.Location = new Point(557, 234);
            AddAdminBtn.Name = "AddAdminBtn";
            AddAdminBtn.Size = new Size(86, 29);
            AddAdminBtn.TabIndex = 68;
            AddAdminBtn.Text = "Add";
            AddAdminBtn.UseVisualStyleBackColor = false;
            AddAdminBtn.Click += AddAdminBtn_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Location = new Point(292, 47);
            label9.Name = "label9";
            label9.Size = new Size(73, 15);
            label9.TabIndex = 67;
            label9.Text = "Department:";
            // 
            // AddAdminStatus
            // 
            AddAdminStatus.Anchor = AnchorStyles.Top;
            AddAdminStatus.Location = new Point(599, 163);
            AddAdminStatus.Name = "AddAdminStatus";
            AddAdminStatus.Size = new Size(232, 23);
            AddAdminStatus.TabIndex = 48;
            // 
            // AddAdminEmail
            // 
            AddAdminEmail.Anchor = AnchorStyles.Top;
            AddAdminEmail.Location = new Point(305, 189);
            AddAdminEmail.Name = "AddAdminEmail";
            AddAdminEmail.Size = new Size(232, 23);
            AddAdminEmail.TabIndex = 49;
            // 
            // AddAdminSalary
            // 
            AddAdminSalary.Anchor = AnchorStyles.Top;
            AddAdminSalary.Location = new Point(305, 127);
            AddAdminSalary.Name = "AddAdminSalary";
            AddAdminSalary.Size = new Size(232, 23);
            AddAdminSalary.TabIndex = 50;
            // 
            // AddAdminDepartment
            // 
            AddAdminDepartment.Anchor = AnchorStyles.Top;
            AddAdminDepartment.Location = new Point(305, 65);
            AddAdminDepartment.Name = "AddAdminDepartment";
            AddAdminDepartment.Size = new Size(232, 23);
            AddAdminDepartment.TabIndex = 51;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Location = new Point(292, 105);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 66;
            label8.Text = "Salary:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Location = new Point(292, 171);
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
            AddAdminPhone.Name = "AddAdminPhone";
            AddAdminPhone.Size = new Size(232, 23);
            AddAdminPhone.TabIndex = 61;
            // 
            // AddAdminPost
            // 
            AddAdminPost.Anchor = AnchorStyles.Top;
            AddAdminPost.Location = new Point(21, 224);
            AddAdminPost.Name = "AddAdminPost";
            AddAdminPost.Size = new Size(216, 23);
            AddAdminPost.TabIndex = 59;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Location = new Point(14, 206);
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
            panel2.Controls.Add(UpdateAdmin);
            panel2.Controls.Add(button9);
            panel2.Controls.Add(AddAdminPhone);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(AddAdminGender);
            panel2.Controls.Add(AddAdminBtn);
            panel2.Controls.Add(AddAdminStatus);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(AddAdminDOB);
            panel2.Controls.Add(AddAdminEmail);
            panel2.Controls.Add(AddAdminPost);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(AddAdminN);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(AddAdminSalary);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(AddAdminDepartment);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(AddAdminA);
            panel2.Location = new Point(40, 373);
            panel2.Name = "panel2";
            panel2.Size = new Size(854, 277);
            panel2.TabIndex = 73;
            // 
            // UpdateAdmin
            // 
            UpdateAdmin.Anchor = AnchorStyles.Top;
            UpdateAdmin.BackColor = Color.Blue;
            UpdateAdmin.ForeColor = Color.White;
            UpdateAdmin.Location = new Point(668, 234);
            UpdateAdmin.Name = "UpdateAdmin";
            UpdateAdmin.Size = new Size(77, 29);
            UpdateAdmin.TabIndex = 72;
            UpdateAdmin.Text = "Update";
            UpdateAdmin.UseVisualStyleBackColor = false;
            UpdateAdmin.Click += UpdateAdmin_Click;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Top;
            button9.BackColor = Color.Red;
            button9.ForeColor = Color.White;
            button9.Location = new Point(763, 234);
            button9.Name = "button9";
            button9.Size = new Size(76, 29);
            button9.TabIndex = 68;
            button9.Text = "Delete";
            button9.UseVisualStyleBackColor = false;
            button9.Click += AddAdminBtn_Click;
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
            AdminData.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, salaryDataGridViewTextBoxColumn, departmentDataGridViewTextBoxColumn, postDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn, dobDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, phoneDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn });
            AdminData.DataSource = administratorsBindingSource;
            AdminData.Location = new Point(12, 12);
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
            // salaryDataGridViewTextBoxColumn
            // 
            salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            salaryDataGridViewTextBoxColumn.ReadOnly = true;
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
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dobDataGridViewTextBoxColumn
            // 
            dobDataGridViewTextBoxColumn.DataPropertyName = "Dob";
            dobDataGridViewTextBoxColumn.HeaderText = "Dob";
            dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            dobDataGridViewTextBoxColumn.ReadOnly = true;
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
            // Add_Administrator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(949, 662);
            Controls.Add(AdminData);
            Controls.Add(panel2);
            Name = "Add_Administrator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrators";
            Load += Add_Administrator_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)administratorsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)AdminData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button AddAdminBtn;
        private Label label9;
        private TextBox AddAdminStatus;
        private TextBox AddAdminEmail;
        private TextBox AddAdminSalary;
        private TextBox AddAdminDepartment;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox AddAdminPhone;
        private TextBox AddAdminPost;
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
        private Button button9;
        private BindingSource administratorsBindingSource;
        private DataGridView AdminData;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn postDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private Button UpdateAdmin;
    }
}