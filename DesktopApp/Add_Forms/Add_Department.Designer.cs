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
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            DepData = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DepData).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(324, 17);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 8;
            label4.Text = "Number of Students:";
            // 
            // AddDepStudents
            // 
            AddDepStudents.Location = new Point(335, 35);
            AddDepStudents.Name = "AddDepStudents";
            AddDepStudents.Size = new Size(224, 23);
            AddDepStudents.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 126);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 9;
            label3.Text = "Number of Courses:";
            // 
            // AddDepCourses
            // 
            AddDepCourses.Location = new Point(40, 144);
            AddDepCourses.Name = "AddDepCourses";
            AddDepCourses.Size = new Size(224, 23);
            AddDepCourses.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 70);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 10;
            label2.Text = "Description:";
            // 
            // AddDepDes
            // 
            AddDepDes.Location = new Point(40, 88);
            AddDepDes.Name = "AddDepDes";
            AddDepDes.Size = new Size(224, 23);
            AddDepDes.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 17);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 11;
            label1.Text = "Name:";
            // 
            // AddDepName
            // 
            AddDepName.Location = new Point(40, 35);
            AddDepName.Name = "AddDepName";
            AddDepName.Size = new Size(224, 23);
            AddDepName.TabIndex = 7;
            // 
            // AddDepBtn
            // 
            AddDepBtn.BackColor = Color.MediumSeaGreen;
            AddDepBtn.Location = new Point(298, 167);
            AddDepBtn.Name = "AddDepBtn";
            AddDepBtn.Size = new Size(85, 33);
            AddDepBtn.TabIndex = 3;
            AddDepBtn.Text = "Add";
            AddDepBtn.UseVisualStyleBackColor = false;
            AddDepBtn.Click += AddDepBtn_Click;
            // 
            // AddDepLecturers
            // 
            AddDepLecturers.Location = new Point(335, 93);
            AddDepLecturers.Name = "AddDepLecturers";
            AddDepLecturers.Size = new Size(224, 23);
            AddDepLecturers.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(324, 75);
            label5.Name = "label5";
            label5.Size = new Size(119, 15);
            label5.TabIndex = 8;
            label5.Text = "Number of Lecturers:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(AddDepName);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(AddDepBtn);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(AddDepDes);
            panel2.Controls.Add(AddDepLecturers);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(AddDepStudents);
            panel2.Controls.Add(AddDepCourses);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(206, 405);
            panel2.Name = "panel2";
            panel2.Size = new Size(584, 212);
            panel2.TabIndex = 13;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(496, 167);
            button2.Name = "button2";
            button2.Size = new Size(85, 33);
            button2.TabIndex = 3;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += AddDepBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Location = new Point(398, 167);
            button1.Name = "button1";
            button1.Size = new Size(85, 33);
            button1.TabIndex = 3;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += AddDepBtn_Click;
            // 
            // DepData
            // 
            DepData.AllowUserToAddRows = false;
            DepData.AllowUserToDeleteRows = false;
            DepData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DepData.Location = new Point(12, 12);
            DepData.Name = "DepData";
            DepData.ReadOnly = true;
            DepData.RowTemplate.Height = 25;
            DepData.Size = new Size(981, 376);
            DepData.TabIndex = 14;
            // 
            // Add_Department
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1006, 630);
            Controls.Add(DepData);
            Controls.Add(panel2);
            Name = "Add_Department";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Department";
            Load += Add_Department_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DepData).EndInit();
            ResumeLayout(false);
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
        private Panel panel2;
        private Button button2;
        private Button button1;
        private DataGridView DepData;
    }
}