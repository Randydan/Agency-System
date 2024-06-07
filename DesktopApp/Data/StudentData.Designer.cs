namespace DesktopApp.Data
{
    partial class StudentData
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
            StudData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)StudData).BeginInit();
            SuspendLayout();
            // 
            // StudData
            // 
            StudData.AllowUserToAddRows = false;
            StudData.AllowUserToDeleteRows = false;
            StudData.AllowUserToResizeColumns = false;
            StudData.AllowUserToResizeRows = false;
            StudData.CellBorderStyle = DataGridViewCellBorderStyle.None;
            StudData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudData.Location = new Point(5, 5);
            StudData.Name = "StudData";
            StudData.ReadOnly = true;
            StudData.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            StudData.RowTemplate.Height = 25;
            StudData.ShowCellErrors = false;
            StudData.ShowCellToolTips = false;
            StudData.ShowEditingIcon = false;
            StudData.ShowRowErrors = false;
            StudData.Size = new Size(783, 433);
            StudData.TabIndex = 0;
            // 
            // StudentData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(StudData);
            Name = "StudentData";
            Text = "Students";
            Load += StudentData_Load;
            ((System.ComponentModel.ISupportInitialize)StudData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView StudData;
    }
}