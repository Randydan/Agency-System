namespace DesktopApp.Data
{
    partial class OfficeData
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
            OffData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)OffData).BeginInit();
            SuspendLayout();
            // 
            // OffData
            // 
            OffData.AllowUserToAddRows = false;
            OffData.AllowUserToDeleteRows = false;
            OffData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OffData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OffData.Location = new Point(12, 12);
            OffData.Name = "OffData";
            OffData.ReadOnly = true;
            OffData.RowTemplate.Height = 25;
            OffData.Size = new Size(307, 426);
            OffData.TabIndex = 0;
            // 
            // OfficeData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 450);
            Controls.Add(OffData);
            Name = "OfficeData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OfficeData";
            Load += OfficeData_Load;
            ((System.ComponentModel.ISupportInitialize)OffData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView OffData;
    }
}