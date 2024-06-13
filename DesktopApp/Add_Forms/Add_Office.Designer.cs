namespace DesktopApp.Add_Forms
{
    partial class Add_Office
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Office));
            AddOfficeAddr = new TextBox();
            AddOfficeDes = new TextBox();
            AddOfficeDep = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            AddOfficeBtn = new Button();
            label4 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            Student = new Button();
            Office = new Button();
            Lecturer = new Button();
            Department = new Button();
            Course = new Button();
            Classroom = new Button();
            Administrator = new Button();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            OffData = new DataGridView();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OffData).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // AddOfficeAddr
            // 
            AddOfficeAddr.Location = new Point(34, 160);
            AddOfficeAddr.Name = "AddOfficeAddr";
            AddOfficeAddr.Size = new Size(188, 23);
            AddOfficeAddr.TabIndex = 7;
            // 
            // AddOfficeDes
            // 
            AddOfficeDes.Location = new Point(34, 103);
            AddOfficeDes.Name = "AddOfficeDes";
            AddOfficeDes.Size = new Size(188, 23);
            AddOfficeDes.TabIndex = 8;
            // 
            // AddOfficeDep
            // 
            AddOfficeDep.Location = new Point(34, 44);
            AddOfficeDep.Name = "AddOfficeDep";
            AddOfficeDep.Size = new Size(188, 23);
            AddOfficeDep.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 142);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 4;
            label3.Text = "Address:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 85);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 5;
            label2.Text = "Description:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 26);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 6;
            label1.Text = "Department:";
            // 
            // AddOfficeBtn
            // 
            AddOfficeBtn.BackColor = Color.MediumSeaGreen;
            AddOfficeBtn.Location = new Point(323, 44);
            AddOfficeBtn.Name = "AddOfficeBtn";
            AddOfficeBtn.Size = new Size(89, 34);
            AddOfficeBtn.TabIndex = 3;
            AddOfficeBtn.Text = "Add";
            AddOfficeBtn.UseVisualStyleBackColor = false;
            AddOfficeBtn.Click += AddOfficeBtn_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(171, 1202);
            label4.Name = "label4";
            label4.Size = new Size(156, 15);
            label4.TabIndex = 3;
            label4.Text = "Keeping Records Made easy";
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
            panel1.Location = new Point(1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 724);
            panel1.TabIndex = 10;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(82, 709);
            label6.Name = "label6";
            label6.Size = new Size(156, 15);
            label6.TabIndex = 11;
            label6.Text = "Keeping Records Made easy";
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
            Office.BackColor = Color.Honeydew;
            Office.FlatStyle = FlatStyle.Flat;
            Office.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Office.ForeColor = Color.MediumSpringGreen;
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
            Course.BackColor = Color.MediumSeaGreen;
            Course.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Course.ForeColor = Color.White;
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
            pictureBox1.Location = new Point(134, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 84);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // OffData
            // 
            OffData.AllowUserToAddRows = false;
            OffData.AllowUserToDeleteRows = false;
            OffData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OffData.Location = new Point(363, 6);
            OffData.Name = "OffData";
            OffData.ReadOnly = true;
            OffData.RowTemplate.Height = 25;
            OffData.Size = new Size(983, 453);
            OffData.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(AddOfficeBtn);
            panel2.Controls.Add(AddOfficeAddr);
            panel2.Controls.Add(AddOfficeDep);
            panel2.Controls.Add(AddOfficeDes);
            panel2.Location = new Point(616, 490);
            panel2.Name = "panel2";
            panel2.Size = new Size(488, 207);
            panel2.TabIndex = 12;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(385, 123);
            button2.Name = "button2";
            button2.Size = new Size(89, 34);
            button2.TabIndex = 3;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += AddOfficeBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Location = new Point(263, 123);
            button1.Name = "button1";
            button1.Size = new Size(89, 34);
            button1.TabIndex = 3;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += AddOfficeBtn_Click;
            // 
            // Add_Office
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1350, 729);
            Controls.Add(panel2);
            Controls.Add(OffData);
            Controls.Add(panel1);
            Name = "Add_Office";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Office";
            Load += Add_Office_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)OffData).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox AddOfficeAddr;
        private TextBox AddOfficeDes;
        private TextBox AddOfficeDep;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button AddOfficeBtn;
        private Label label4;
        private Panel panel1;
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
        private DataGridView OffData;
        private Panel panel2;
        private Button button1;
        private Button button2;
    }
}