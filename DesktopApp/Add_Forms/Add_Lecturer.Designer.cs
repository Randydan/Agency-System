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
            AddLecDOB = new TextBox();
            label10 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            AddLecAddr = new TextBox();
            AddLecName = new TextBox();
            AddLecGen = new ComboBox();
            SuspendLayout();
            // 
            // AddLecBtn
            // 
            AddLecBtn.Anchor = AnchorStyles.None;
            AddLecBtn.BackColor = SystemColors.Highlight;
            AddLecBtn.Location = new Point(246, 318);
            AddLecBtn.Name = "AddLecBtn";
            AddLecBtn.Size = new Size(59, 29);
            AddLecBtn.TabIndex = 89;
            AddLecBtn.Text = "Add";
            AddLecBtn.UseVisualStyleBackColor = false;
            AddLecBtn.Click += AddLecBtn_Click;
            // 
            // AddLecCourse
            // 
            AddLecCourse.Anchor = AnchorStyles.Left;
            AddLecCourse.AutoSize = true;
            AddLecCourse.Location = new Point(306, 40);
            AddLecCourse.Name = "AddLecCourse";
            AddLecCourse.Size = new Size(86, 15);
            AddLecCourse.TabIndex = 88;
            AddLecCourse.Text = "Course Taught:";
            // 
            // AddLecStatus
            // 
            AddLecStatus.Anchor = AnchorStyles.Left;
            AddLecStatus.Location = new Point(324, 218);
            AddLecStatus.Name = "AddLecStatus";
            AddLecStatus.Size = new Size(220, 23);
            AddLecStatus.TabIndex = 69;
            // 
            // AddLecEmail
            // 
            AddLecEmail.Anchor = AnchorStyles.Left;
            AddLecEmail.Location = new Point(324, 165);
            AddLecEmail.Name = "AddLecEmail";
            AddLecEmail.Size = new Size(220, 23);
            AddLecEmail.TabIndex = 70;
            // 
            // AddLecSalary
            // 
            AddLecSalary.Anchor = AnchorStyles.Left;
            AddLecSalary.Location = new Point(324, 114);
            AddLecSalary.Name = "AddLecSalary";
            AddLecSalary.Size = new Size(220, 23);
            AddLecSalary.TabIndex = 71;
            // 
            // AddLecDep
            // 
            AddLecDep.Anchor = AnchorStyles.Left;
            AddLecDep.Location = new Point(324, 58);
            AddLecDep.Name = "AddLecDep";
            AddLecDep.Size = new Size(220, 23);
            AddLecDep.TabIndex = 72;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(306, 92);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 87;
            label8.Text = "Salary:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(306, 147);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 86;
            label7.Text = "Email:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(306, 200);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 85;
            label6.Text = "Status:";
            // 
            // AddLecPhone
            // 
            AddLecPhone.Anchor = AnchorStyles.Left;
            AddLecPhone.Location = new Point(46, 218);
            AddLecPhone.Name = "AddLecPhone";
            AddLecPhone.Size = new Size(198, 23);
            AddLecPhone.TabIndex = 82;
            // 
            // AddLecDOB
            // 
            AddLecDOB.Anchor = AnchorStyles.Left;
            AddLecDOB.Location = new Point(40, 114);
            AddLecDOB.Name = "AddLecDOB";
            AddLecDOB.Size = new Size(204, 23);
            AddLecDOB.TabIndex = 81;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Location = new Point(28, 200);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 77;
            label10.Text = "Phone:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(28, 147);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 76;
            label5.Text = "Address:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(28, 92);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 75;
            label4.Text = "Date of Birth:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(28, 253);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 74;
            label3.Text = "Gender:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(28, 38);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 73;
            label1.Text = "Name:";
            // 
            // AddLecAddr
            // 
            AddLecAddr.Anchor = AnchorStyles.Left;
            AddLecAddr.Location = new Point(40, 165);
            AddLecAddr.Name = "AddLecAddr";
            AddLecAddr.Size = new Size(204, 23);
            AddLecAddr.TabIndex = 79;
            // 
            // AddLecName
            // 
            AddLecName.Anchor = AnchorStyles.Left;
            AddLecName.Location = new Point(40, 58);
            AddLecName.Name = "AddLecName";
            AddLecName.Size = new Size(204, 23);
            AddLecName.TabIndex = 84;
            // 
            // AddLecGen
            // 
            AddLecGen.FormattingEnabled = true;
            AddLecGen.Items.AddRange(new object[] { "Male", "Female" });
            AddLecGen.Location = new Point(46, 271);
            AddLecGen.Name = "AddLecGen";
            AddLecGen.Size = new Size(198, 23);
            AddLecGen.TabIndex = 90;
            // 
            // Add_Lecturer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 376);
            Controls.Add(AddLecGen);
            Controls.Add(AddLecBtn);
            Controls.Add(AddLecCourse);
            Controls.Add(AddLecStatus);
            Controls.Add(AddLecEmail);
            Controls.Add(AddLecSalary);
            Controls.Add(AddLecDep);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(AddLecPhone);
            Controls.Add(AddLecDOB);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(AddLecAddr);
            Controls.Add(AddLecName);
            Name = "Add_Lecturer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_Lecturer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private TextBox AddLecDOB;
        private Label label10;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox AddLecAddr;
        private TextBox AddLecName;
        private ComboBox AddLecGen;
    }
}