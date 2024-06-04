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
            SuspendLayout();
            // 
            // AddCourseBtn
            // 
            AddCourseBtn.BackColor = SystemColors.MenuHighlight;
            AddCourseBtn.Location = new Point(108, 235);
            AddCourseBtn.Name = "AddCourseBtn";
            AddCourseBtn.Size = new Size(75, 23);
            AddCourseBtn.TabIndex = 0;
            AddCourseBtn.Text = "Add";
            AddCourseBtn.UseVisualStyleBackColor = false;
            AddCourseBtn.Click += AddCourseBtn_Click;
            // 
            // AddCourseName
            // 
            AddCourseName.Location = new Point(51, 27);
            AddCourseName.Name = "AddCourseName";
            AddCourseName.Size = new Size(224, 23);
            AddCourseName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 9);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // AddCourseDes
            // 
            AddCourseDes.Location = new Point(51, 80);
            AddCourseDes.Name = "AddCourseDes";
            AddCourseDes.Size = new Size(224, 23);
            AddCourseDes.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 62);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 2;
            label2.Text = "Description:";
            // 
            // AddCourseCode
            // 
            AddCourseCode.Location = new Point(51, 136);
            AddCourseCode.Name = "AddCourseCode";
            AddCourseCode.Size = new Size(224, 23);
            AddCourseCode.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 118);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "Code:";
            // 
            // AddCourseDep
            // 
            AddCourseDep.Location = new Point(51, 193);
            AddCourseDep.Name = "AddCourseDep";
            AddCourseDep.Size = new Size(224, 23);
            AddCourseDep.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 175);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 2;
            label4.Text = "Department:";
            // 
            // Add_Course
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 276);
            Controls.Add(label4);
            Controls.Add(AddCourseDep);
            Controls.Add(label3);
            Controls.Add(AddCourseCode);
            Controls.Add(label2);
            Controls.Add(AddCourseDes);
            Controls.Add(label1);
            Controls.Add(AddCourseName);
            Controls.Add(AddCourseBtn);
            Name = "Add_Course";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Course";
            ResumeLayout(false);
            PerformLayout();
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
    }
}