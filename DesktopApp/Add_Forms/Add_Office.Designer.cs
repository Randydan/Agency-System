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
            components = new System.ComponentModel.Container();
            AddOfficeAddr = new TextBox();
            AddOfficeDes = new TextBox();
            AddOfficeDep = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            AddOfficeBtn = new Button();
            OffData = new DataGridView();
            panel2 = new Panel();
            Deletebtn = new Button();
            Updatebtn = new Button();
            OffID = new TextBox();
            officeBindingSource = new BindingSource(components);
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            departmentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)OffData).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)officeBindingSource).BeginInit();
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
            // OffData
            // 
            OffData.AllowUserToAddRows = false;
            OffData.AllowUserToDeleteRows = false;
            OffData.AutoGenerateColumns = false;
            OffData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OffData.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, departmentDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn });
            OffData.DataSource = officeBindingSource;
            OffData.Location = new Point(26, 12);
            OffData.Name = "OffData";
            OffData.ReadOnly = true;
            OffData.RowTemplate.Height = 25;
            OffData.Size = new Size(444, 357);
            OffData.TabIndex = 11;
            OffData.CellContentClick += OffData_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(Deletebtn);
            panel2.Controls.Add(Updatebtn);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(AddOfficeBtn);
            panel2.Controls.Add(AddOfficeAddr);
            panel2.Controls.Add(AddOfficeDep);
            panel2.Controls.Add(AddOfficeDes);
            panel2.Location = new Point(12, 391);
            panel2.Name = "panel2";
            panel2.Size = new Size(488, 207);
            panel2.TabIndex = 12;
            // 
            // Deletebtn
            // 
            Deletebtn.BackColor = Color.Red;
            Deletebtn.Location = new Point(385, 123);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(89, 34);
            Deletebtn.TabIndex = 11;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = false;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // Updatebtn
            // 
            Updatebtn.BackColor = SystemColors.MenuHighlight;
            Updatebtn.Location = new Point(254, 123);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new Size(89, 34);
            Updatebtn.TabIndex = 10;
            Updatebtn.Text = "Update";
            Updatebtn.UseVisualStyleBackColor = false;
            Updatebtn.Click += Updatebtn_Click;
            // 
            // OffID
            // 
            OffID.Location = new Point(116, 289);
            OffID.Name = "OffID";
            OffID.Size = new Size(188, 23);
            OffID.TabIndex = 11;
            // 
            // officeBindingSource
            // 
            officeBindingSource.DataSource = typeof(Code_First.Models.Office);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            departmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Add_Office
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(512, 610);
            Controls.Add(panel2);
            Controls.Add(OffData);
            Controls.Add(OffID);
            Name = "Add_Office";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Office";
            Load += Add_Office_Load;
            ((System.ComponentModel.ISupportInitialize)OffData).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)officeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AddOfficeAddr;
        private TextBox AddOfficeDes;
        private TextBox AddOfficeDep;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button AddOfficeBtn;
        private DataGridView OffData;
        private Panel panel2;
        private Button Updatebtn;
        private TextBox OffID;
        private Button Deletebtn;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private BindingSource officeBindingSource;
    }
}