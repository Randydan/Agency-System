namespace DesktopApp.Data
{
    partial class LecturerData
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
            LecData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)LecData).BeginInit();
            SuspendLayout();
            // 
            // LecData
            // 
            LecData.AllowUserToAddRows = false;
            LecData.AllowUserToDeleteRows = false;
            LecData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LecData.Location = new Point(4, 4);
            LecData.Name = "LecData";
            LecData.ReadOnly = true;
            LecData.RowTemplate.Height = 25;
            LecData.Size = new Size(882, 440);
            LecData.TabIndex = 0;
            // 
            // LecturerData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 464);
            Controls.Add(LecData);
            Name = "LecturerData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LecturerData";
            Load += LecturerData_Load;
            ((System.ComponentModel.ISupportInitialize)LecData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView LecData;
    }
}