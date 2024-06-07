namespace DesktopApp
{
    partial class Add_Classroom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Classroom));
            AddClassBtn = new Button();
            label1 = new Label();
            AddClassName = new TextBox();
            label2 = new Label();
            AddClassDes = new TextBox();
            label3 = new Label();
            AddClassLoc = new TextBox();
            panel1 = new Panel();
            label6 = new Label();
            label4 = new Label();
            Student = new Button();
            Office = new Button();
            Lecturer = new Button();
            Department = new Button();
            Course = new Button();
            Classroom = new Button();
            Administrator = new Button();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            ClassData = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ClassData).BeginInit();
            SuspendLayout();
            // 
            // AddClassBtn
            // 
            AddClassBtn.BackColor = Color.MediumSeaGreen;
            AddClassBtn.Location = new Point(300, 58);
            AddClassBtn.Name = "AddClassBtn";
            AddClassBtn.Size = new Size(80, 34);
            AddClassBtn.TabIndex = 0;
            AddClassBtn.Text = "Add";
            AddClassBtn.UseVisualStyleBackColor = false;
            AddClassBtn.Click += AddClassBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 18);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // AddClassName
            // 
            AddClassName.Location = new Point(29, 36);
            AddClassName.Name = "AddClassName";
            AddClassName.Size = new Size(188, 23);
            AddClassName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 77);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Description:";
            // 
            // AddClassDes
            // 
            AddClassDes.Location = new Point(29, 95);
            AddClassDes.Name = "AddClassDes";
            AddClassDes.Size = new Size(188, 23);
            AddClassDes.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 144);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 1;
            label3.Text = "Location:";
            // 
            // AddClassLoc
            // 
            AddClassLoc.Location = new Point(29, 162);
            AddClassLoc.Name = "AddClassLoc";
            AddClassLoc.Size = new Size(188, 23);
            AddClassLoc.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(Student);
            panel1.Controls.Add(Office);
            panel1.Controls.Add(Lecturer);
            panel1.Controls.Add(Department);
            panel1.Controls.Add(Course);
            panel1.Controls.Add(Classroom);
            panel1.Controls.Add(Administrator);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 728);
            panel1.TabIndex = 3;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(105, 711);
            label6.Name = "label6";
            label6.Size = new Size(156, 15);
            label6.TabIndex = 4;
            label6.Text = "Keeping Records Made easy";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(171, 1204);
            label4.Name = "label4";
            label4.Size = new Size(156, 15);
            label4.TabIndex = 3;
            label4.Text = "Keeping Records Made easy";
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
            Student.Click += Student_Click;
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
            Lecturer.Click += Lecturer_Click;
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
            Classroom.BackColor = Color.Honeydew;
            Classroom.FlatStyle = FlatStyle.Flat;
            Classroom.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Classroom.ForeColor = Color.MediumSeaGreen;
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
            Administrator.Click += Administrator_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cooper Black", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(66, 154);
            label5.Name = "label5";
            label5.Size = new Size(211, 31);
            label5.TabIndex = 1;
            label5.Text = "Welcome Back";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(140, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 84);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(AddClassBtn);
            panel2.Controls.Add(AddClassLoc);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(AddClassDes);
            panel2.Controls.Add(AddClassName);
            panel2.Location = new Point(611, 469);
            panel2.Name = "panel2";
            panel2.Size = new Size(452, 215);
            panel2.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(357, 127);
            button2.Name = "button2";
            button2.Size = new Size(75, 32);
            button2.TabIndex = 0;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += AddClassBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Location = new Point(253, 127);
            button1.Name = "button1";
            button1.Size = new Size(75, 32);
            button1.TabIndex = 0;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += AddClassBtn_Click;
            // 
            // ClassData
            // 
            ClassData.AllowUserToAddRows = false;
            ClassData.AllowUserToDeleteRows = false;
            ClassData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ClassData.Location = new Point(362, 6);
            ClassData.Name = "ClassData";
            ClassData.ReadOnly = true;
            ClassData.RowTemplate.Height = 25;
            ClassData.Size = new Size(986, 450);
            ClassData.TabIndex = 5;
            // 
            // Add_Classroom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1350, 729);
            Controls.Add(ClassData);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Add_Classroom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Classrooms";
            Load += Add_Classroom_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ClassData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button AddClassBtn;
        private Label label1;
        private TextBox AddClassName;
        private Label label2;
        private TextBox AddClassDes;
        private Label label3;
        private TextBox AddClassLoc;
        private Panel panel1;
        private Label label4;
        private Button Student;
        private Button Office;
        private Button Lecturer;
        private Button Department;
        private Button Course;
        private Button Classroom;
        private Button Administrator;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label6;
        private Panel panel2;
        private Button button2;
        private Button button1;
        private DataGridView ClassData;
    }
}