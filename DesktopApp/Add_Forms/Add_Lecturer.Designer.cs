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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Lecturer));
            label2 = new Label();
            panel1 = new Panel();
            label11 = new Label();
            Student = new Button();
            Office = new Button();
            button1 = new Button();
            Department = new Button();
            Course = new Button();
            Classroom = new Button();
            Administrator = new Button();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            LecData = new DataGridView();
            panel2 = new Panel();
            AddLecDOB = new DateTimePicker();
            AddLecGen = new ComboBox();
            button3 = new Button();
            button2 = new Button();
            AddLecBtn = new Button();
            AddLecCourse = new Label();
            AddLecStatus = new TextBox();
            AddLecEmail = new TextBox();
            AddLecSalary = new TextBox();
            AddLecDep = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            AddLecPhone = new TextBox();
            label10 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            AddLecAddr = new TextBox();
            AddLecName = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LecData).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(171, 1199);
            label2.Name = "label2";
            label2.Size = new Size(156, 15);
            label2.TabIndex = 3;
            label2.Text = "Keeping Records Made easy";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Student);
            panel1.Controls.Add(Office);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(Department);
            panel1.Controls.Add(Course);
            panel1.Controls.Add(Classroom);
            panel1.Controls.Add(Administrator);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 721);
            panel1.TabIndex = 92;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom;
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = Color.DarkGreen;
            label11.Location = new Point(82, 706);
            label11.Name = "label11";
            label11.Size = new Size(156, 15);
            label11.TabIndex = 5;
            label11.Text = "Keeping Records Made easy";
            // 
            // Student
            // 
            Student.BackColor = Color.MediumSeaGreen;
            Student.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Student.ForeColor = Color.White;
            Student.Location = new Point(186, 295);
            Student.Name = "Student";
            Student.Size = new Size(164, 41);
            Student.TabIndex = 2;
            Student.Text = "Student";
            Student.UseVisualStyleBackColor = false;
            Student.Click += Student_Click_1;
            // 
            // Office
            // 
            Office.BackColor = Color.MediumSeaGreen;
            Office.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Office.ForeColor = Color.White;
            Office.Location = new Point(82, 487);
            Office.Name = "Office";
            Office.Size = new Size(167, 41);
            Office.TabIndex = 2;
            Office.Text = "Office";
            Office.UseVisualStyleBackColor = false;
            Office.Click += Office_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Honeydew;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.MediumSeaGreen;
            button1.Location = new Point(177, 415);
            button1.Name = "button1";
            button1.Size = new Size(164, 41);
            button1.TabIndex = 2;
            button1.Text = "Lecturer";
            button1.UseVisualStyleBackColor = false;
            // 
            // Department
            // 
            Department.BackColor = Color.MediumSeaGreen;
            Department.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Department.ForeColor = Color.White;
            Department.Location = new Point(82, 357);
            Department.Name = "Department";
            Department.Size = new Size(167, 41);
            Department.TabIndex = 2;
            Department.Text = "Department";
            Department.UseVisualStyleBackColor = false;
            Department.Click += Department_Click;
            // 
            // Course
            // 
            Course.BackColor = Color.MediumSeaGreen;
            Course.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Course.ForeColor = Color.White;
            Course.Location = new Point(4, 415);
            Course.Name = "Course";
            Course.Size = new Size(167, 41);
            Course.TabIndex = 2;
            Course.Text = "Course";
            Course.UseVisualStyleBackColor = false;
            Course.Click += Course_Click;
            // 
            // Classroom
            // 
            Classroom.BackColor = Color.MediumSeaGreen;
            Classroom.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Classroom.ForeColor = Color.White;
            Classroom.Location = new Point(7, 295);
            Classroom.Name = "Classroom";
            Classroom.Size = new Size(167, 41);
            Classroom.TabIndex = 2;
            Classroom.Text = "Classroom";
            Classroom.UseVisualStyleBackColor = false;
            Classroom.Click += Classroom_Click_1;
            // 
            // Administrator
            // 
            Administrator.BackColor = Color.MediumSeaGreen;
            Administrator.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Administrator.ForeColor = Color.White;
            Administrator.Location = new Point(82, 234);
            Administrator.Name = "Administrator";
            Administrator.Size = new Size(167, 41);
            Administrator.TabIndex = 2;
            Administrator.Text = "Administrator";
            Administrator.UseVisualStyleBackColor = false;
            Administrator.Click += Administrator_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cooper Black", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(66, 154);
            label9.Name = "label9";
            label9.Size = new Size(211, 31);
            label9.TabIndex = 1;
            label9.Text = "Welcome Back";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(134, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 84);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LecData
            // 
            LecData.AllowUserToAddRows = false;
            LecData.AllowUserToDeleteRows = false;
            LecData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LecData.Location = new Point(363, 6);
            LecData.Name = "LecData";
            LecData.ReadOnly = true;
            LecData.RowTemplate.Height = 25;
            LecData.Size = new Size(936, 398);
            LecData.TabIndex = 93;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(AddLecDOB);
            panel2.Controls.Add(AddLecGen);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(AddLecBtn);
            panel2.Controls.Add(AddLecCourse);
            panel2.Controls.Add(AddLecStatus);
            panel2.Controls.Add(AddLecEmail);
            panel2.Controls.Add(AddLecSalary);
            panel2.Controls.Add(AddLecDep);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(AddLecPhone);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(AddLecAddr);
            panel2.Controls.Add(AddLecName);
            panel2.Location = new Point(443, 421);
            panel2.Name = "panel2";
            panel2.Size = new Size(846, 258);
            panel2.TabIndex = 94;
            // 
            // AddLecDOB
            // 
            AddLecDOB.Format = DateTimePickerFormat.Short;
            AddLecDOB.Location = new Point(33, 106);
            AddLecDOB.Name = "AddLecDOB";
            AddLecDOB.Size = new Size(204, 23);
            AddLecDOB.TabIndex = 110;
            // 
            // AddLecGen
            // 
            AddLecGen.FormattingEnabled = true;
            AddLecGen.Items.AddRange(new object[] { "Male", "Female" });
            AddLecGen.Location = new Point(611, 164);
            AddLecGen.Name = "AddLecGen";
            AddLecGen.Size = new Size(198, 23);
            AddLecGen.TabIndex = 109;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.Red;
            button3.Location = new Point(531, 205);
            button3.Name = "button3";
            button3.Size = new Size(114, 37);
            button3.TabIndex = 108;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = SystemColors.Highlight;
            button2.Location = new Point(352, 205);
            button2.Name = "button2";
            button2.Size = new Size(100, 37);
            button2.TabIndex = 108;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            // 
            // AddLecBtn
            // 
            AddLecBtn.Anchor = AnchorStyles.None;
            AddLecBtn.BackColor = Color.MediumSeaGreen;
            AddLecBtn.Location = new Point(148, 205);
            AddLecBtn.Name = "AddLecBtn";
            AddLecBtn.Size = new Size(105, 37);
            AddLecBtn.TabIndex = 108;
            AddLecBtn.Text = "Add";
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
            // AddLecStatus
            // 
            AddLecStatus.Anchor = AnchorStyles.Left;
            AddLecStatus.Location = new Point(317, 164);
            AddLecStatus.Name = "AddLecStatus";
            AddLecStatus.Size = new Size(220, 23);
            AddLecStatus.TabIndex = 92;
            // 
            // AddLecEmail
            // 
            AddLecEmail.Anchor = AnchorStyles.Left;
            AddLecEmail.Location = new Point(611, 102);
            AddLecEmail.Name = "AddLecEmail";
            AddLecEmail.Size = new Size(198, 23);
            AddLecEmail.TabIndex = 93;
            // 
            // AddLecSalary
            // 
            AddLecSalary.Anchor = AnchorStyles.Left;
            AddLecSalary.Location = new Point(317, 106);
            AddLecSalary.Name = "AddLecSalary";
            AddLecSalary.Size = new Size(220, 23);
            AddLecSalary.TabIndex = 94;
            // 
            // AddLecDep
            // 
            AddLecDep.Anchor = AnchorStyles.Left;
            AddLecDep.Location = new Point(317, 46);
            AddLecDep.Name = "AddLecDep";
            AddLecDep.Size = new Size(220, 23);
            AddLecDep.TabIndex = 95;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(299, 84);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 106;
            label8.Text = "Salary:";
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
            label3.Location = new Point(593, 146);
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
            // AddLecName
            // 
            AddLecName.Anchor = AnchorStyles.Left;
            AddLecName.Location = new Point(33, 46);
            AddLecName.Name = "AddLecName";
            AddLecName.Size = new Size(204, 23);
            AddLecName.TabIndex = 103;
            // 
            // Lecturer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1350, 729);
            Controls.Add(panel2);
            Controls.Add(LecData);
            Controls.Add(panel1);
            Name = "Lecturer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lecturer";
            Load += Lecturer_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)LecData).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Panel panel1;
        private Button Student;
        private Button Office;
        private Button button1;
        private Button Department;
        private Button Course;
        private Button Classroom;
        private Button Administrator;
        private Label label9;
        private PictureBox pictureBox1;
        private DataGridView LecData;
        private Label label11;
        private Panel panel2;
        private DateTimePicker AddLecDOB;
        private ComboBox AddLecGen;
        private Button AddLecBtn;
        private Label AddLecCourse;
        private TextBox AddLecStatus;
        private TextBox AddLecEmail;
        private TextBox AddLecSalary;
        private TextBox AddLecDep;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox AddLecPhone;
        private Label label10;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox AddLecAddr;
        private TextBox AddLecName;
        private Button button3;
        private Button button2;
    }
}