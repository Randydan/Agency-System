namespace DesktopApp.Data
{
    partial class CourseData
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
            CourseDatas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)CourseDatas).BeginInit();
            SuspendLayout();
            // 
            // CourseDatas
            // 
            CourseDatas.AllowUserToAddRows = false;
            CourseDatas.AllowUserToDeleteRows = false;
            CourseDatas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CourseDatas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CourseDatas.Location = new Point(7, 7);
            CourseDatas.Name = "CourseDatas";
            CourseDatas.ReadOnly = true;
            CourseDatas.RowTemplate.Height = 25;
            CourseDatas.Size = new Size(341, 431);
            CourseDatas.TabIndex = 0;
            // 
            // CourseData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 450);
            Controls.Add(CourseDatas);
            Name = "CourseData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CourseData";
            Load += CourseData_Load;
            ((System.ComponentModel.ISupportInitialize)CourseDatas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView CourseDatas;
    }
}