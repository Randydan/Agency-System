namespace DesktopApp
{
    partial class Loading_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading_Screen));
            Loading = new ProgressBar();
            textBox1 = new TextBox();
            loadingTimer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Loading
            // 
            Loading.Location = new Point(95, 297);
            Loading.Name = "Loading";
            Loading.Size = new Size(406, 23);
            Loading.Style = ProgressBarStyle.Continuous;
            Loading.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox1.Location = new Point(554, 372);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(48, 19);
            textBox1.TabIndex = 1;
            // 
            // loadingTimer
            // 
            loadingTimer.Tick += loadingTimer_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(145, 41);
            label1.Name = "label1";
            label1.Size = new Size(310, 23);
            label1.TabIndex = 2;
            label1.Text = "EVERYTHING IN ONE PLACE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Old English Text MT", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(557, 366);
            label2.Name = "label2";
            label2.Size = new Size(45, 19);
            label2.TabIndex = 2;
            label2.Text = "2024";
            // 
            // Loading_Screen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(614, 394);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(Loading);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Loading_Screen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loading_Screen";
            Load += Loading_Screen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar Loading;
        private TextBox textBox1;
        private System.Windows.Forms.Timer loadingTimer;
        private Label label1;
        private Label label2;
    }
}