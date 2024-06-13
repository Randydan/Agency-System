namespace DesktopApp
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            panel1 = new Panel();
            label2 = new Label();
            Student = new Button();
            Office = new Button();
            Lecturer = new Button();
            Department = new Button();
            Course = new Button();
            Classroom = new Button();
            Administrator = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Student);
            panel1.Controls.Add(Office);
            panel1.Controls.Add(Lecturer);
            panel1.Controls.Add(Department);
            panel1.Controls.Add(Course);
            panel1.Controls.Add(Classroom);
            panel1.Controls.Add(Administrator);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 593);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(93, 578);
            label2.Name = "label2";
            label2.Size = new Size(156, 15);
            label2.TabIndex = 3;
            label2.Text = "Keeping Records Made easy";
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
            Classroom.BackColor = Color.MediumSeaGreen;
            Classroom.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Classroom.ForeColor = Color.White;
            Classroom.Location = new Point(7, 295);
            Classroom.Name = "Classroom";
            Classroom.Size = new Size(167, 41);
            Classroom.TabIndex = 2;
            Classroom.Text = "Classroom";
            Classroom.UseVisualStyleBackColor = false;
            Classroom.Click += Classroom_Click;
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
            Administrator.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumSeaGreen;
            label1.Location = new Point(66, 154);
            label1.Name = "label1";
            label1.Size = new Size(211, 31);
            label1.TabIndex = 1;
            label1.Text = "Welcome Back";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(136, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 84);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Algerian", 33F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(405, 295);
            label3.Name = "label3";
            label3.Size = new Size(736, 98);
            label3.TabIndex = 1;
            label3.Text = "BRINGING YOUR RECORDS AT YOUR \r\n                         FINGER TIPS\r\n";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1171, 594);
            Controls.Add(label3);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainWindow";
            Text = "School Management System ";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button Student;
        private Button Office;
        private Button Lecturer;
        private Button Department;
        private Button Course;
        private Button Classroom;
        private Button Administrator;
        private Label label2;
        private Label label3;
    }
}