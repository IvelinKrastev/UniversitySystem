namespace UniversitySystem.Forms
{
    partial class LogInLecturer
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
            this.btLogInLecturer = new System.Windows.Forms.Button();
            this.btBackLecturer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPasswordLecturer = new System.Windows.Forms.TextBox();
            this.tbIDLecturer = new System.Windows.Forms.TextBox();
            this.pbLecturer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLecturer)).BeginInit();
            this.SuspendLayout();
            // 
            // btLogInLecturer
            // 
            this.btLogInLecturer.Location = new System.Drawing.Point(197, 236);
            this.btLogInLecturer.Name = "btLogInLecturer";
            this.btLogInLecturer.Size = new System.Drawing.Size(75, 23);
            this.btLogInLecturer.TabIndex = 13;
            this.btLogInLecturer.Text = "Log in";
            this.btLogInLecturer.UseVisualStyleBackColor = true;
            // 
            // btBackLecturer
            // 
            this.btBackLecturer.Location = new System.Drawing.Point(12, 236);
            this.btBackLecturer.Name = "btBackLecturer";
            this.btBackLecturer.Size = new System.Drawing.Size(75, 23);
            this.btBackLecturer.TabIndex = 12;
            this.btBackLecturer.Text = "Back";
            this.btBackLecturer.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Identification Number (EGN)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Password:";
            // 
            // tbPasswordLecturer
            // 
            this.tbPasswordLecturer.Location = new System.Drawing.Point(77, 189);
            this.tbPasswordLecturer.Name = "tbPasswordLecturer";
            this.tbPasswordLecturer.Size = new System.Drawing.Size(128, 20);
            this.tbPasswordLecturer.TabIndex = 9;
            // 
            // tbIDLecturer
            // 
            this.tbIDLecturer.Location = new System.Drawing.Point(77, 137);
            this.tbIDLecturer.Name = "tbIDLecturer";
            this.tbIDLecturer.Size = new System.Drawing.Size(128, 20);
            this.tbIDLecturer.TabIndex = 8;
            // 
            // pbLecturer
            // 
            this.pbLecturer.Location = new System.Drawing.Point(77, 12);
            this.pbLecturer.Name = "pbLecturer";
            this.pbLecturer.Size = new System.Drawing.Size(128, 97);
            this.pbLecturer.TabIndex = 7;
            this.pbLecturer.TabStop = false;
            // 
            // LogInLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btLogInLecturer);
            this.Controls.Add(this.btBackLecturer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPasswordLecturer);
            this.Controls.Add(this.tbIDLecturer);
            this.Controls.Add(this.pbLecturer);
            this.Name = "LogInLecturer";
            this.Text = "LogInLecturer";
            this.Load += new System.EventHandler(this.LogInLecturer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLecturer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLogInLecturer;
        private System.Windows.Forms.Button btBackLecturer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPasswordLecturer;
        private System.Windows.Forms.TextBox tbIDLecturer;
        private System.Windows.Forms.PictureBox pbLecturer;
    }
}