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
            components = new System.ComponentModel.Container();
            AddCourseBtn = new Button();
            AddCourseName = new TextBox();
            label1 = new Label();
            AddCourseDes = new TextBox();
            label2 = new Label();
            AddCourseCode = new TextBox();
            label3 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            Deletebtn = new Button();
            Updatebtn = new Button();
            CourseData = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            departmentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            courseBindingSource = new BindingSource(components);
            CourseID = new TextBox();
            AddCourseDep = new ComboBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CourseData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)courseBindingSource).BeginInit();
            SuspendLayout();
            // 
            // AddCourseBtn
            // 
            AddCourseBtn.BackColor = Color.MediumSeaGreen;
            AddCourseBtn.Location = new Point(100, 151);
            AddCourseBtn.Name = "AddCourseBtn";
            AddCourseBtn.Size = new Size(92, 32);
            AddCourseBtn.TabIndex = 0;
            AddCourseBtn.Text = "Add New";
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
            panel2.Controls.Add(AddCourseDep);
            panel2.Controls.Add(Deletebtn);
            panel2.Controls.Add(Updatebtn);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(AddCourseName);
            panel2.Controls.Add(AddCourseBtn);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(AddCourseDes);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(AddCourseCode);
            panel2.Location = new Point(23, 451);
            panel2.Name = "panel2";
            panel2.Size = new Size(521, 192);
            panel2.TabIndex = 4;
            // 
            // Deletebtn
            // 
            Deletebtn.BackColor = Color.Red;
            Deletebtn.Location = new Point(326, 151);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(92, 32);
            Deletebtn.TabIndex = 4;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = false;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // Updatebtn
            // 
            Updatebtn.BackColor = SystemColors.MenuHighlight;
            Updatebtn.Location = new Point(214, 151);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new Size(92, 32);
            Updatebtn.TabIndex = 3;
            Updatebtn.Text = "Edit";
            Updatebtn.UseVisualStyleBackColor = false;
            Updatebtn.Click += Updatebtn_Click;
            // 
            // CourseData
            // 
            CourseData.AllowUserToAddRows = false;
            CourseData.AllowUserToDeleteRows = false;
            CourseData.AutoGenerateColumns = false;
            CourseData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CourseData.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, codeDataGridViewTextBoxColumn, departmentDataGridViewTextBoxColumn });
            CourseData.DataSource = courseBindingSource;
            CourseData.Location = new Point(12, 12);
            CourseData.Name = "CourseData";
            CourseData.ReadOnly = true;
            CourseData.RowTemplate.Height = 25;
            CourseData.Size = new Size(544, 407);
            CourseData.TabIndex = 5;
            CourseData.CellContentClick += CourseData_CellContentClick;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            codeDataGridViewTextBoxColumn.HeaderText = "Code";
            codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            departmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseBindingSource
            // 
            courseBindingSource.DataSource = typeof(Code_First.Models.Course);
            // 
            // CourseID
            // 
            CourseID.Location = new Point(156, 306);
            CourseID.Name = "CourseID";
            CourseID.Size = new Size(224, 23);
            CourseID.TabIndex = 4;
            // 
            // AddCourseDep
            // 
            AddCourseDep.FormattingEnabled = true;
            AddCourseDep.Items.AddRange(new object[] { "Civil Engineering", "Computer Engineering", "Accounting", "Marketing", "Management", "Electrical Engineering", "Transport and Logistics", "Banking and Finance" });
            AddCourseDep.Location = new Point(279, 102);
            AddCourseDep.Name = "AddCourseDep";
            AddCourseDep.Size = new Size(224, 23);
            AddCourseDep.TabIndex = 5;
            // 
            // Add_Course
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(569, 658);
            Controls.Add(CourseData);
            Controls.Add(panel2);
            Controls.Add(CourseID);
            Name = "Add_Course";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Course";
            Load += Add_Course_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CourseData).EndInit();
            ((System.ComponentModel.ISupportInitialize)courseBindingSource).EndInit();
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
        private Label label4;
        private Panel panel2;
        private DataGridView CourseData;
        private Button Updatebtn;
        private TextBox CourseID;
        private Button Deletebtn;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private BindingSource courseBindingSource;
        private ComboBox AddCourseDep;
    }
}