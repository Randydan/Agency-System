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
            AddClassBtn = new Button();
            label1 = new Label();
            AddClassName = new TextBox();
            label2 = new Label();
            AddClassDes = new TextBox();
            label3 = new Label();
            AddClassLoc = new TextBox();
            SuspendLayout();
            // 
            // AddClassBtn
            // 
            AddClassBtn.BackColor = SystemColors.MenuHighlight;
            AddClassBtn.Location = new Point(119, 232);
            AddClassBtn.Name = "AddClassBtn";
            AddClassBtn.Size = new Size(75, 23);
            AddClassBtn.TabIndex = 0;
            AddClassBtn.Text = "Add";
            AddClassBtn.UseVisualStyleBackColor = false;
            AddClassBtn.Click += AddClassBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 28);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // AddClassName
            // 
            AddClassName.Location = new Point(75, 46);
            AddClassName.Name = "AddClassName";
            AddClassName.Size = new Size(188, 23);
            AddClassName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 87);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Description:";
            // 
            // AddClassDes
            // 
            AddClassDes.Location = new Point(75, 105);
            AddClassDes.Name = "AddClassDes";
            AddClassDes.Size = new Size(188, 23);
            AddClassDes.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 154);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 1;
            label3.Text = "Location:";
            // 
            // AddClassLoc
            // 
            AddClassLoc.Location = new Point(75, 172);
            AddClassLoc.Name = "AddClassLoc";
            AddClassLoc.Size = new Size(188, 23);
            AddClassLoc.TabIndex = 2;
            // 
            // Add_Classroom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 283);
            Controls.Add(AddClassLoc);
            Controls.Add(AddClassDes);
            Controls.Add(AddClassName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AddClassBtn);
            Name = "Add_Classroom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddClassroom";
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
    }
}