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
            AddCourseBtn = new Button();
            AddCourseName = new TextBox();
            label1 = new Label();
            AddCourseDes = new TextBox();
            label2 = new Label();
            AddCourseCode = new TextBox();
            label3 = new Label();
            AddCourseDep = new TextBox();
            label4 = new Label();
            panel2 = new Panel();
            Delete = new Button();
            button1 = new Button();
            CourseData = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CourseData).BeginInit();
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
            panel2.Location = new Point(225, 507);
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
            // CourseData
            // 
            CourseData.AllowUserToAddRows = false;
            CourseData.AllowUserToDeleteRows = false;
            CourseData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CourseData.Location = new Point(12, 12);
            CourseData.Name = "CourseData";
            CourseData.ReadOnly = true;
            CourseData.RowTemplate.Height = 25;
            CourseData.Size = new Size(983, 478);
            CourseData.TabIndex = 5;
            // 
            // Add_Course
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1007, 711);
            Controls.Add(CourseData);
            Controls.Add(panel2);
            Name = "Add_Course";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Course";
            Load += Add_Course_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CourseData).EndInit();
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
        private Panel panel2;
        private Button Delete;
        private Button button1;
        private DataGridView CourseData;
    }
}