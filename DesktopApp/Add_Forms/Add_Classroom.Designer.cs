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
            components = new System.ComponentModel.Container();
            AddClassBtn = new Button();
            label1 = new Label();
            AddClassName = new TextBox();
            label2 = new Label();
            AddClassDes = new TextBox();
            label3 = new Label();
            AddClassLoc = new TextBox();
            panel2 = new Panel();
            Updatebtn = new Button();
            Deletebtn = new Button();
            ClassData = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            locationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            classroomBindingSource = new BindingSource(components);
            ClassId = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ClassData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)classroomBindingSource).BeginInit();
            SuspendLayout();
            // 
            // AddClassBtn
            // 
            AddClassBtn.BackColor = Color.MediumSeaGreen;
            AddClassBtn.Location = new Point(286, 58);
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
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(Updatebtn);
            panel2.Controls.Add(Deletebtn);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(AddClassBtn);
            panel2.Controls.Add(AddClassLoc);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(AddClassDes);
            panel2.Controls.Add(AddClassName);
            panel2.Location = new Point(12, 326);
            panel2.Name = "panel2";
            panel2.Size = new Size(444, 201);
            panel2.TabIndex = 4;
            // 
            // Updatebtn
            // 
            Updatebtn.BackColor = SystemColors.MenuHighlight;
            Updatebtn.Location = new Point(239, 127);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new Size(75, 32);
            Updatebtn.TabIndex = 4;
            Updatebtn.Text = "Update";
            Updatebtn.UseVisualStyleBackColor = false;
            Updatebtn.Click += Updatebtn_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.BackColor = Color.Red;
            Deletebtn.Location = new Point(344, 127);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(75, 32);
            Deletebtn.TabIndex = 3;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = false;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // ClassData
            // 
            ClassData.AllowUserToAddRows = false;
            ClassData.AllowUserToDeleteRows = false;
            ClassData.AutoGenerateColumns = false;
            ClassData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ClassData.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, locationDataGridViewTextBoxColumn });
            ClassData.DataSource = classroomBindingSource;
            ClassData.Location = new Point(12, 12);
            ClassData.Name = "ClassData";
            ClassData.ReadOnly = true;
            ClassData.RowTemplate.Height = 25;
            ClassData.Size = new Size(444, 296);
            ClassData.TabIndex = 5;
            ClassData.CellContentClick += ClassData_CellContentClick;
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
            // locationDataGridViewTextBoxColumn
            // 
            locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            locationDataGridViewTextBoxColumn.HeaderText = "Location";
            locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            locationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classroomBindingSource
            // 
            classroomBindingSource.DataSource = typeof(Code_First.Models.Classroom);
            // 
            // ClassId
            // 
            ClassId.Location = new Point(190, 165);
            ClassId.Name = "ClassId";
            ClassId.Size = new Size(188, 23);
            ClassId.TabIndex = 4;
            // 
            // Add_Classroom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(469, 540);
            Controls.Add(ClassData);
            Controls.Add(panel2);
            Controls.Add(ClassId);
            Name = "Add_Classroom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Classrooms";
            Load += Add_Classroom_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ClassData).EndInit();
            ((System.ComponentModel.ISupportInitialize)classroomBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddClassBtn;
        private Label label1;
        private TextBox AddClassName;
        private Label label2;
        private TextBox AddClassDes;
        private Label label3;
        private TextBox AddClassLoc;
        private Panel panel2;
        private DataGridView ClassData;
        private Button Deletebtn;
        private TextBox ClassId;
        private Button Updatebtn;
        private BindingSource classroomBindingSource;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
    }
}