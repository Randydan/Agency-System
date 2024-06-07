namespace DesktopApp.Data
{
    partial class DepartmentData
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
            DepData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DepData).BeginInit();
            SuspendLayout();
            // 
            // DepData
            // 
            DepData.AllowUserToAddRows = false;
            DepData.AllowUserToDeleteRows = false;
            DepData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            DepData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DepData.Location = new Point(12, 12);
            DepData.Name = "DepData";
            DepData.ReadOnly = true;
            DepData.RowTemplate.Height = 25;
            DepData.Size = new Size(429, 426);
            DepData.TabIndex = 0;
            // 
            // DepartmentData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 450);
            Controls.Add(DepData);
            Name = "DepartmentData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Departments";
            Load += DepartmentData_Load;
            ((System.ComponentModel.ISupportInitialize)DepData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DepData;
    }
}