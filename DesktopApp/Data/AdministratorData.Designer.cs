namespace DesktopApp.Data
{
    partial class AdministratorData
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
            AdminData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)AdminData).BeginInit();
            SuspendLayout();
            // 
            // AdminData
            // 
            AdminData.AllowUserToAddRows = false;
            AdminData.AllowUserToDeleteRows = false;
            AdminData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            AdminData.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            AdminData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdminData.Location = new Point(12, 12);
            AdminData.Name = "AdminData";
            AdminData.ReadOnly = true;
            AdminData.RowTemplate.Height = 25;
            AdminData.Size = new Size(1035, 440);
            AdminData.TabIndex = 0;
            AdminData.CellContentClick += AdminData_CellContentClick;
            // 
            // AdministratorData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 464);
            Controls.Add(AdminData);
            Name = "AdministratorData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrators";
            Load += AdministratorData_Load;
            ((System.ComponentModel.ISupportInitialize)AdminData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView AdminData;
    }
}