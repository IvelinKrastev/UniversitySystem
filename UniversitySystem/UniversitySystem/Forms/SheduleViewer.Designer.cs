namespace UniversitySystem.Forms
{
    partial class SheduleViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SheduleViewer));
            this.pbShedule = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbShedule)).BeginInit();
            this.SuspendLayout();
            // 
            // pbShedule
            // 
            this.pbShedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbShedule.Location = new System.Drawing.Point(0, 0);
            this.pbShedule.Name = "pbShedule";
            this.pbShedule.Size = new System.Drawing.Size(1084, 661);
            this.pbShedule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShedule.TabIndex = 0;
            this.pbShedule.TabStop = false;
            // 
            // SheduleViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.pbShedule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SheduleViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shedule View";
            ((System.ComponentModel.ISupportInitialize)(this.pbShedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pbShedule;
    }
}