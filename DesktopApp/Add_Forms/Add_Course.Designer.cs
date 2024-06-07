namespace DesktopApp.Add_Forms
{
    partial class Add_Course
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Course));
            AddCourseBtn = new Button();
            AddCourseName = new TextBox();
            label1 = new Label();
            AddCourseDes = new TextBox();
            label2 = new Label();
            AddCourseCode = new TextBox();
            label3 = new Label();
            AddCourseDep = new TextBox();
            label4 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            label5 = new Label();
            Student = new Button();
            Office = new Button();
            Lecturer = new Button();
            Department = new Button();
            Course = new Button();
            Classroom = new Button();
            Administrator = new Button();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            Delete = new Button();
            button1 = new Button();
            CourseDatas = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CourseDatas).BeginInit();
            SuspendLayout();
            // 
            // AddCourseBtn
            // 
            AddCourseBtn.BackColor = Color.MediumSeaGreen;
            AddCourseBtn.Location = new Point(100, 151);
            AddCourseBtn.Name = "AddCourseBtn";
            AddCourseBtn.Size = new Size(92, 32);
            AddCourseBtn.TabIndex = 0;
            AddCourseBtn.Text = "Add";
            AddCourseBtn.UseVisualStyleBackColor = false;
            AddCourseBtn.Click += AddCourseBtn_Click;
            // 
            // AddCourseName
            // 
            AddCourseName.Location = new Point(22, 45);
            AddCourseName.Name = "AddCourseName";
            AddCourseName.Size = new Size(224, 23);
            AddCourseName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 27);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // AddCourseDes
            // 
            AddCourseDes.Location = new Point(22, 98);
            AddCourseDes.Name = "AddCourseDes";
            AddCourseDes.Size = new Size(224, 23);
            AddCourseDes.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 80);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 2;
            label2.Text = "Description:";
            // 
            // AddCourseCode
            // 
            AddCourseCode.Location = new Point(279, 45);
            AddCourseCode.Name = "AddCourseCode";
            AddCourseCode.Size = new Size(224, 23);
            AddCourseCode.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(268, 27);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "Code:";
            // 
            // AddCourseDep
            // 
            AddCourseDep.Location = new Point(279, 102);
            AddCourseDep.Name = "AddCourseDep";
            AddCourseDep.Size = new Size(224, 23);
            AddCourseDep.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(268, 84);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 2;
            label4.Text = "Department:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(Student);
            panel1.Controls.Add(Office);
            panel1.Controls.Add(Lecturer);
            panel1.Controls.Add(Department);
            panel1.Controls.Add(Course);
            panel1.Controls.Add(Classroom);
            panel1.Controls.Add(Administrator);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 726);
            panel1.TabIndex = 3;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom;
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkGreen;
            label7.Location = new Point(93, 711);
            label7.Name = "label7";
            label7.Size = new Size(156, 15);
            label7.TabIndex = 4;
            label7.Text = "Keeping Records Made easy";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(171, 1204);
            label5.Name = "label5";
            label5.Size = new Size(156, 15);
            label5.TabIndex = 3;
            label5.Text = "Keeping Records Made easy";
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
            // 
            // Lecturer
            // 
            Lecturer.BackColor = Color.MediumSeaGreen;
            Lecturer.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Lecturer.ForeColor = Color.White;
            Lecturer.Location = new Point(177, 415);
            Lecturer.Name = "Lecturer";
            Lecturer.Size = new Size(164, 41);
            Lecturer.TabIndex = 2;
            Lecturer.Text = "Lecturer";
            Lecturer.UseVisualStyleBackColor = false;
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
            // 
            // Course
            // 
            Course.BackColor = Color.Honeydew;
            Course.FlatStyle = FlatStyle.Flat;
            Course.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Course.ForeColor = Color.MediumSeaGreen;
            Course.Location = new Point(4, 415);
            Course.Name = "Course";
            Course.Size = new Size(167, 41);
            Course.TabIndex = 2;
            Course.Text = "Course";
            Course.UseVisualStyleBackColor = false;
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
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cooper Black", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(66, 154);
            label6.Name = "label6";
            label6.Size = new Size(211, 31);
            label6.TabIndex = 1;
            label6.Text = "Welcome Back";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(131, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 84);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(AddCourseName);
            panel2.Controls.Add(Delete);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(AddCourseBtn);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(AddCourseDes);
            panel2.Controls.Add(AddCourseDep);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(AddCourseCode);
            panel2.Location = new Point(539, 499);
            panel2.Name = "panel2";
            panel2.Size = new Size(521, 192);
            panel2.TabIndex = 4;
            // 
            // Delete
            // 
            Delete.BackColor = Color.Red;
            Delete.Location = new Point(332, 151);
            Delete.Name = "Delete";
            Delete.Size = new Size(92, 32);
            Delete.TabIndex = 0;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += AddCourseBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Location = new Point(214, 151);
            button1.Name = "button1";
            button1.Size = new Size(92, 32);
            button1.TabIndex = 0;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += AddCourseBtn_Click;
            // 
            // CourseDatas
            // 
            CourseDatas.AllowUserToAddRows = false;
            CourseDatas.AllowUserToDeleteRows = false;
            CourseDatas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CourseDatas.Location = new Point(362, 5);
            CourseDatas.Name = "CourseDatas";
            CourseDatas.ReadOnly = true;
            CourseDatas.RowTemplate.Height = 25;
            CourseDatas.Size = new Size(983, 478);
            CourseDatas.TabIndex = 5;
            // 
            // Add_Course
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1350, 729);
            Controls.Add(CourseDatas);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Add_Course";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Course";
            Load += Add_Course_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CourseDatas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button AddCourseBtn;
        private TextBox AddCourseName;
        private Label label1;
        private TextBox AddCourseDes;
        private Label label2;
        private TextBox AddCourseCode;
        private Label label3;
        private TextBox AddCourseDep;
        private Label label4;
        private Panel panel1;
        private Label label5;
        private Button Student;
        private Button Office;
        private Button Lecturer;
        private Button Department;
        private Button Course;
        private Button Classroom;
        private Button Administrator;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label7;
        private Panel panel2;
        private Button Delete;
        private Button button1;
        private DataGridView CourseDatas;
    }
}