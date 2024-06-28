namespace DesktopApp.Add_Forms
{
    partial class Add_Lecturer
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
            LecData = new DataGridView();
            lecturerBindingSource = new BindingSource(components);
            panel2 = new Panel();
            updatebtn = new Button();
            AddLecDOB = new DateTimePicker();
            AddLecDep = new ComboBox();
            AddLecStatus = new ComboBox();
            AddLecGen = new ComboBox();
            Deletebtn = new Button();
            AddLecBtn = new Button();
            AddLecCourse = new Label();
            AddLecEmail = new TextBox();
            AddLecName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            AddLecPhone = new TextBox();
            label10 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            AddLecAddr = new TextBox();
            LecID = new TextBox();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DoB = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            courseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)LecData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lecturerBindingSource).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // LecData
            // 
            LecData.AllowUserToAddRows = false;
            LecData.AllowUserToDeleteRows = false;
            LecData.AutoGenerateColumns = false;
            LecData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LecData.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, DoB, emailDataGridViewTextBoxColumn, phoneDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, courseDataGridViewTextBoxColumn });
            LecData.DataSource = lecturerBindingSource;
            LecData.Location = new Point(12, 12);
            LecData.Name = "LecData";
            LecData.ReadOnly = true;
            LecData.RowTemplate.Height = 25;
            LecData.Size = new Size(842, 331);
            LecData.TabIndex = 93;
            LecData.CellContentClick += LecData_CellContentClick;
            // 
            // lecturerBindingSource
            // 
            lecturerBindingSource.DataSource = typeof(Code_First.Models.Lecturer);
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(updatebtn);
            panel2.Controls.Add(AddLecDOB);
            panel2.Controls.Add(AddLecDep);
            panel2.Controls.Add(AddLecStatus);
            panel2.Controls.Add(AddLecGen);
            panel2.Controls.Add(Deletebtn);
            panel2.Controls.Add(AddLecBtn);
            panel2.Controls.Add(AddLecCourse);
            panel2.Controls.Add(AddLecEmail);
            panel2.Controls.Add(AddLecName);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(AddLecPhone);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(AddLecAddr);
            panel2.Location = new Point(12, 359);
            panel2.Name = "panel2";
            panel2.Size = new Size(846, 258);
            panel2.TabIndex = 94;
            // 
            // updatebtn
            // 
            updatebtn.Anchor = AnchorStyles.None;
            updatebtn.BackColor = SystemColors.Highlight;
            updatebtn.Location = new Point(362, 205);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(100, 37);
            updatebtn.TabIndex = 111;
            updatebtn.Text = "Edit";
            updatebtn.UseVisualStyleBackColor = false;
            updatebtn.Click += updatebtn_Click;
            // 
            // AddLecDOB
            // 
            AddLecDOB.Format = DateTimePickerFormat.Short;
            AddLecDOB.Location = new Point(33, 106);
            AddLecDOB.Name = "AddLecDOB";
            AddLecDOB.Size = new Size(204, 23);
            AddLecDOB.TabIndex = 110;
            // 
            // AddLecDep
            // 
            AddLecDep.FormattingEnabled = true;
            AddLecDep.Items.AddRange(new object[] { "English", "French", "Maths", "Physics", "Accounting", "Marketing", "Data Literacy", "Programming" });
            AddLecDep.Location = new Point(317, 46);
            AddLecDep.Name = "AddLecDep";
            AddLecDep.Size = new Size(220, 23);
            AddLecDep.TabIndex = 109;
            // 
            // AddLecStatus
            // 
            AddLecStatus.FormattingEnabled = true;
            AddLecStatus.Items.AddRange(new object[] { "Married", "Single" });
            AddLecStatus.Location = new Point(317, 164);
            AddLecStatus.Name = "AddLecStatus";
            AddLecStatus.Size = new Size(220, 23);
            AddLecStatus.TabIndex = 109;
            // 
            // AddLecGen
            // 
            AddLecGen.FormattingEnabled = true;
            AddLecGen.Items.AddRange(new object[] { "Male", "Female" });
            AddLecGen.Location = new Point(317, 106);
            AddLecGen.Name = "AddLecGen";
            AddLecGen.Size = new Size(220, 23);
            AddLecGen.TabIndex = 109;
            // 
            // Deletebtn
            // 
            Deletebtn.Anchor = AnchorStyles.None;
            Deletebtn.BackColor = Color.Red;
            Deletebtn.Location = new Point(531, 205);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(114, 37);
            Deletebtn.TabIndex = 108;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = false;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // AddLecBtn
            // 
            AddLecBtn.Anchor = AnchorStyles.None;
            AddLecBtn.BackColor = Color.MediumSeaGreen;
            AddLecBtn.Location = new Point(148, 205);
            AddLecBtn.Name = "AddLecBtn";
            AddLecBtn.Size = new Size(105, 37);
            AddLecBtn.TabIndex = 108;
            AddLecBtn.Text = "Add New";
            AddLecBtn.UseVisualStyleBackColor = false;
            // 
            // AddLecCourse
            // 
            AddLecCourse.Anchor = AnchorStyles.Left;
            AddLecCourse.AutoSize = true;
            AddLecCourse.Location = new Point(299, 28);
            AddLecCourse.Name = "AddLecCourse";
            AddLecCourse.Size = new Size(86, 15);
            AddLecCourse.TabIndex = 107;
            AddLecCourse.Text = "Course Taught:";
            // 
            // AddLecEmail
            // 
            AddLecEmail.Anchor = AnchorStyles.Left;
            AddLecEmail.Location = new Point(611, 102);
            AddLecEmail.Name = "AddLecEmail";
            AddLecEmail.Size = new Size(198, 23);
            AddLecEmail.TabIndex = 93;
            // 
            // AddLecName
            // 
            AddLecName.Anchor = AnchorStyles.Left;
            AddLecName.Location = new Point(33, 46);
            AddLecName.Name = "AddLecName";
            AddLecName.Size = new Size(204, 23);
            AddLecName.TabIndex = 95;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(593, 84);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 105;
            label7.Text = "Email:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(299, 146);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 104;
            label6.Text = "Status:";
            // 
            // AddLecPhone
            // 
            AddLecPhone.Anchor = AnchorStyles.Left;
            AddLecPhone.Location = new Point(39, 164);
            AddLecPhone.MaxLength = 10;
            AddLecPhone.Name = "AddLecPhone";
            AddLecPhone.Size = new Size(198, 23);
            AddLecPhone.TabIndex = 102;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Location = new Point(21, 146);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 100;
            label10.Text = "Phone:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(593, 28);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 99;
            label5.Text = "Address:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(21, 84);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 98;
            label4.Text = "Date of Birth:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(299, 84);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 97;
            label3.Text = "Gender:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(21, 26);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 96;
            label1.Text = "Name:";
            // 
            // AddLecAddr
            // 
            AddLecAddr.Anchor = AnchorStyles.Left;
            AddLecAddr.Location = new Point(605, 46);
            AddLecAddr.Name = "AddLecAddr";
            AddLecAddr.Size = new Size(204, 23);
            AddLecAddr.TabIndex = 101;
            // 
            // LecID
            // 
            LecID.Anchor = AnchorStyles.Left;
            LecID.Location = new Point(258, 225);
            LecID.Name = "LecID";
            LecID.Size = new Size(204, 23);
            LecID.TabIndex = 111;
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
            // DoB
            // 
            DoB.DataPropertyName = "DoB";
            DoB.HeaderText = "DoB";
            DoB.Name = "DoB";
            DoB.ReadOnly = true;
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
            // courseDataGridViewTextBoxColumn
            // 
            courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            courseDataGridViewTextBoxColumn.HeaderText = "Course";
            courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            courseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Add_Lecturer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(869, 629);
            Controls.Add(panel2);
            Controls.Add(LecData);
            Controls.Add(LecID);
            Name = "Add_Lecturer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lecturer";
            Load += Lecturer_Load;
            ((System.ComponentModel.ISupportInitialize)LecData).EndInit();
            ((System.ComponentModel.ISupportInitialize)lecturerBindingSource).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView LecData;
        private Panel panel2;
        private DateTimePicker AddLecDOB;
        private ComboBox AddLecGen;
        private Button AddLecBtn;
        private Label AddLecCourse;
        private TextBox AddLecEmail;
        private Label label7;
        private Label label6;
        private TextBox AddLecPhone;
        private Label label10;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox AddLecAddr;
        private Button Deletebtn;
        private TextBox AddLecName;
        private TextBox LecID;
        private Button updatebtn;
        private DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private BindingSource lecturerBindingSource;
        private ComboBox AddLecDep;
        private ComboBox AddLecStatus;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn DoB;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
    }
}