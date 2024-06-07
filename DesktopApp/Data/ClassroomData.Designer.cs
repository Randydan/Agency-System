namespace DesktopApp.Data
{
    partial class ClassroomData
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
            ClassData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ClassData).BeginInit();
            SuspendLayout();
            // 
            // ClassData
            // 
            ClassData.AllowUserToAddRows = false;
            ClassData.AllowUserToDeleteRows = false;
            ClassData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ClassData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ClassData.Location = new Point(12, 12);
            ClassData.Name = "ClassData";
            ClassData.ReadOnly = true;
            ClassData.RowTemplate.Height = 25;
            ClassData.Size = new Size(334, 426);
            ClassData.TabIndex = 0;
            ClassData.CellContentClick += ClassData_CellContentClick;
            // 
            // ClassroomData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 450);
            Controls.Add(ClassData);
            Name = "ClassroomData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClassroomData";
            Load += ClassroomData_Load;
            ((System.ComponentModel.ISupportInitialize)ClassData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ClassData;
    }
}