namespace DesktopApp.Add_Forms
{
    partial class Add_Department
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
            label4 = new Label();
            AddDepStudents = new TextBox();
            label3 = new Label();
            AddDepCourses = new TextBox();
            label2 = new Label();
            AddDepDes = new TextBox();
            label1 = new Label();
            AddDepName = new TextBox();
            AddDepBtn = new Button();
            AddDepLecturers = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 181);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 8;
            label4.Text = "Number of Students:";
            // 
            // AddDepStudents
            // 
            AddDepStudents.Location = new Point(60, 199);
            AddDepStudents.Name = "AddDepStudents";
            AddDepStudents.Size = new Size(224, 23);
            AddDepStudents.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 126);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 9;
            label3.Text = "Number of Courses:";
            // 
            // AddDepCourses
            // 
            AddDepCourses.Location = new Point(60, 144);
            AddDepCourses.Name = "AddDepCourses";
            AddDepCourses.Size = new Size(224, 23);
            AddDepCourses.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 70);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 10;
            label2.Text = "Description:";
            // 
            // AddDepDes
            // 
            AddDepDes.Location = new Point(60, 88);
            AddDepDes.Name = "AddDepDes";
            AddDepDes.Size = new Size(224, 23);
            AddDepDes.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 17);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 11;
            label1.Text = "Name:";
            // 
            // AddDepName
            // 
            AddDepName.Location = new Point(60, 35);
            AddDepName.Name = "AddDepName";
            AddDepName.Size = new Size(224, 23);
            AddDepName.TabIndex = 7;
            // 
            // AddDepBtn
            // 
            AddDepBtn.BackColor = SystemColors.MenuHighlight;
            AddDepBtn.Location = new Point(135, 296);
            AddDepBtn.Name = "AddDepBtn";
            AddDepBtn.Size = new Size(75, 23);
            AddDepBtn.TabIndex = 3;
            AddDepBtn.Text = "Add";
            AddDepBtn.UseVisualStyleBackColor = false;
            AddDepBtn.Click += AddDepBtn_Click;
            // 
            // AddDepLecturers
            // 
            AddDepLecturers.Location = new Point(60, 257);
            AddDepLecturers.Name = "AddDepLecturers";
            AddDepLecturers.Size = new Size(224, 23);
            AddDepLecturers.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 239);
            label5.Name = "label5";
            label5.Size = new Size(119, 15);
            label5.TabIndex = 8;
            label5.Text = "Number of Lecturers:";
            // 
            // Add_Department
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 331);
            Controls.Add(label5);
            Controls.Add(AddDepLecturers);
            Controls.Add(label4);
            Controls.Add(AddDepStudents);
            Controls.Add(label3);
            Controls.Add(AddDepCourses);
            Controls.Add(label2);
            Controls.Add(AddDepDes);
            Controls.Add(label1);
            Controls.Add(AddDepName);
            Controls.Add(AddDepBtn);
            Name = "Add_Department";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_Department";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox AddDepStudents;
        private Label label3;
        private TextBox AddDepCourses;
        private Label label2;
        private TextBox AddDepDes;
        private Label label1;
        private TextBox AddDepName;
        private Button AddDepBtn;
        private TextBox AddDepLecturers;
        private Label label5;
    }
}