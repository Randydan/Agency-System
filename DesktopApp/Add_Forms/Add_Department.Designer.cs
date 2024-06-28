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
            components = new System.ComponentModel.Container();
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
            Deletebtn = new Button();
            Updatebtn = new Button();
            DepData = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            coursesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lecturersDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            departmentBindingSource = new BindingSource(components);
            DepID = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DepData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)departmentBindingSource).BeginInit();
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
            AddDepBtn.Location = new Point(288, 167);
            AddDepBtn.Name = "AddDepBtn";
            AddDepBtn.Size = new Size(85, 33);
            AddDepBtn.TabIndex = 3;
            AddDepBtn.Text = "Add New";
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
            panel2.Controls.Add(Deletebtn);
            panel2.Controls.Add(Updatebtn);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(AddDepName);
            panel2.Controls.Add(AddDepBtn);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(AddDepDes);
            panel2.Controls.Add(AddDepLecturers);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(AddDepStudents);
            panel2.Controls.Add(AddDepCourses);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(37, 406);
            panel2.Name = "panel2";
            panel2.Size = new Size(584, 212);
            panel2.TabIndex = 13;
            // 
            // Deletebtn
            // 
            Deletebtn.BackColor = Color.Red;
            Deletebtn.Location = new Point(496, 167);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(85, 33);
            Deletebtn.TabIndex = 13;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = false;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // Updatebtn
            // 
            Updatebtn.BackColor = SystemColors.MenuHighlight;
            Updatebtn.Location = new Point(394, 167);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new Size(85, 33);
            Updatebtn.TabIndex = 12;
            Updatebtn.Text = "Edit";
            Updatebtn.UseVisualStyleBackColor = false;
            Updatebtn.Click += Updatebtn_Click;
            // 
            // DepData
            // 
            DepData.AllowUserToAddRows = false;
            DepData.AllowUserToDeleteRows = false;
            DepData.AutoGenerateColumns = false;
            DepData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DepData.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, iDDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, coursesDataGridViewTextBoxColumn, studentsDataGridViewTextBoxColumn, lecturersDataGridViewTextBoxColumn });
            DepData.DataSource = departmentBindingSource;
            DepData.Location = new Point(12, 12);
            DepData.Name = "DepData";
            DepData.ReadOnly = true;
            DepData.RowTemplate.Height = 25;
            DepData.Size = new Size(644, 376);
            DepData.TabIndex = 14;
            DepData.CellContentClick += DepData_CellContentClick;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coursesDataGridViewTextBoxColumn
            // 
            coursesDataGridViewTextBoxColumn.DataPropertyName = "Courses";
            coursesDataGridViewTextBoxColumn.HeaderText = "Courses";
            coursesDataGridViewTextBoxColumn.Name = "coursesDataGridViewTextBoxColumn";
            coursesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentsDataGridViewTextBoxColumn
            // 
            studentsDataGridViewTextBoxColumn.DataPropertyName = "Students";
            studentsDataGridViewTextBoxColumn.HeaderText = "Students";
            studentsDataGridViewTextBoxColumn.Name = "studentsDataGridViewTextBoxColumn";
            studentsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lecturersDataGridViewTextBoxColumn
            // 
            lecturersDataGridViewTextBoxColumn.DataPropertyName = "Lecturers";
            lecturersDataGridViewTextBoxColumn.HeaderText = "Lecturers";
            lecturersDataGridViewTextBoxColumn.Name = "lecturersDataGridViewTextBoxColumn";
            lecturersDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentBindingSource
            // 
            departmentBindingSource.DataSource = typeof(Code_First.Models.Department);
            // 
            // DepID
            // 
            DepID.Location = new Point(273, 262);
            DepID.Name = "DepID";
            DepID.Size = new Size(224, 23);
            DepID.TabIndex = 13;
            // 
            // Add_Department
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(668, 630);
            Controls.Add(DepData);
            Controls.Add(panel2);
            Controls.Add(DepID);
            Name = "Add_Department";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Department";
            Load += Add_Department_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DepData).EndInit();
            ((System.ComponentModel.ISupportInitialize)departmentBindingSource).EndInit();
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
        private Panel panel2;
        private DataGridView DepData;
        private Button Updatebtn;
        private TextBox DepID;
        private Button Deletebtn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn coursesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn studentsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lecturersDataGridViewTextBoxColumn;
        private BindingSource departmentBindingSource;
    }
}