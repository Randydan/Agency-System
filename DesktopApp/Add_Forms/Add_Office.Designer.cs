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
            AddOfficeAddr = new TextBox();
            AddOfficeDes = new TextBox();
            AddOfficeDep = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            AddOfficeBtn = new Button();
            SuspendLayout();
            // 
            // AddOfficeAddr
            // 
            AddOfficeAddr.Location = new Point(38, 163);
            AddOfficeAddr.Name = "AddOfficeAddr";
            AddOfficeAddr.Size = new Size(188, 23);
            AddOfficeAddr.TabIndex = 7;
            // 
            // AddOfficeDes
            // 
            AddOfficeDes.Location = new Point(38, 106);
            AddOfficeDes.Name = "AddOfficeDes";
            AddOfficeDes.Size = new Size(188, 23);
            AddOfficeDes.TabIndex = 8;
            // 
            // AddOfficeDep
            // 
            AddOfficeDep.Location = new Point(38, 47);
            AddOfficeDep.Name = "AddOfficeDep";
            AddOfficeDep.Size = new Size(188, 23);
            AddOfficeDep.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 145);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 4;
            label3.Text = "Address:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 88);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 5;
            label2.Text = "Description:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 29);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 6;
            label1.Text = "Department:";
            // 
            // AddOfficeBtn
            // 
            AddOfficeBtn.BackColor = SystemColors.MenuHighlight;
            AddOfficeBtn.Location = new Point(94, 207);
            AddOfficeBtn.Name = "AddOfficeBtn";
            AddOfficeBtn.Size = new Size(75, 23);
            AddOfficeBtn.TabIndex = 3;
            AddOfficeBtn.Text = "Add";
            AddOfficeBtn.UseVisualStyleBackColor = false;
            AddOfficeBtn.Click += AddOfficeBtn_Click;
            // 
            // Add_Office
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 242);
            Controls.Add(AddOfficeAddr);
            Controls.Add(AddOfficeDes);
            Controls.Add(AddOfficeDep);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AddOfficeBtn);
            Name = "Add_Office";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_Office";
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
    }
}