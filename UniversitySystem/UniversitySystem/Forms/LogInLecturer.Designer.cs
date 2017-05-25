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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInLecturer));
            this.btnLogInLecturer = new System.Windows.Forms.Button();
            this.btnBackLecturer = new System.Windows.Forms.Button();
            this.lblIDTxt = new System.Windows.Forms.Label();
            this.lblPassTxt = new System.Windows.Forms.Label();
            this.tbPasswordLecturer = new System.Windows.Forms.TextBox();
            this.tbIDLecturer = new System.Windows.Forms.TextBox();
            this.pbLecturer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLecturer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogInLecturer
            // 
            this.btnLogInLecturer.BackColor = System.Drawing.Color.LightGray;
            this.btnLogInLecturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogInLecturer.Location = new System.Drawing.Point(223, 278);
            this.btnLogInLecturer.Name = "btnLogInLecturer";
            this.btnLogInLecturer.Size = new System.Drawing.Size(98, 42);
            this.btnLogInLecturer.TabIndex = 13;
            this.btnLogInLecturer.Text = "Log in";
            this.btnLogInLecturer.UseVisualStyleBackColor = false;
            this.btnLogInLecturer.Click += new System.EventHandler(this.btnLogInLecturer_Click);
            // 
            // btnBackLecturer
            // 
            this.btnBackLecturer.BackColor = System.Drawing.Color.LightGray;
            this.btnBackLecturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackLecturer.Location = new System.Drawing.Point(12, 278);
            this.btnBackLecturer.Name = "btnBackLecturer";
            this.btnBackLecturer.Size = new System.Drawing.Size(98, 42);
            this.btnBackLecturer.TabIndex = 12;
            this.btnBackLecturer.Text = "Back";
            this.btnBackLecturer.UseVisualStyleBackColor = false;
            this.btnBackLecturer.Click += new System.EventHandler(this.btnBackLecturer_Click);
            // 
            // lblIDTxt
            // 
            this.lblIDTxt.AutoSize = true;
            this.lblIDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDTxt.Location = new System.Drawing.Point(82, 142);
            this.lblIDTxt.Name = "lblIDTxt";
            this.lblIDTxt.Size = new System.Drawing.Size(161, 15);
            this.lblIDTxt.TabIndex = 11;
            this.lblIDTxt.Text = "Identification Number (EGN)";
            // 
            // lblPassTxt
            // 
            this.lblPassTxt.AutoSize = true;
            this.lblPassTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassTxt.Location = new System.Drawing.Point(134, 196);
            this.lblPassTxt.Name = "lblPassTxt";
            this.lblPassTxt.Size = new System.Drawing.Size(64, 15);
            this.lblPassTxt.TabIndex = 10;
            this.lblPassTxt.Text = "Password:";
            // 
            // tbPasswordLecturer
            // 
            this.tbPasswordLecturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPasswordLecturer.Location = new System.Drawing.Point(82, 214);
            this.tbPasswordLecturer.Name = "tbPasswordLecturer";
            this.tbPasswordLecturer.Size = new System.Drawing.Size(161, 21);
            this.tbPasswordLecturer.TabIndex = 9;
            this.tbPasswordLecturer.TextChanged += new System.EventHandler(this.tbPasswordLecturer_TextChanged);
            // 
            // tbIDLecturer
            // 
            this.tbIDLecturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDLecturer.Location = new System.Drawing.Point(82, 160);
            this.tbIDLecturer.Name = "tbIDLecturer";
            this.tbIDLecturer.Size = new System.Drawing.Size(161, 21);
            this.tbIDLecturer.TabIndex = 8;
            this.tbIDLecturer.TextChanged += new System.EventHandler(this.tbIDLecturer_TextChanged);
            // 
            // pbLecturer
            // 
            this.pbLecturer.Image = global::UniversitySystem.Properties.Resources.Lecturer;
            this.pbLecturer.Location = new System.Drawing.Point(97, 12);
            this.pbLecturer.Name = "pbLecturer";
            this.pbLecturer.Size = new System.Drawing.Size(136, 112);
            this.pbLecturer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLecturer.TabIndex = 7;
            this.pbLecturer.TabStop = false;
            // 
            // LogInLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(333, 332);
            this.Controls.Add(this.btnLogInLecturer);
            this.Controls.Add(this.btnBackLecturer);
            this.Controls.Add(this.lblIDTxt);
            this.Controls.Add(this.lblPassTxt);
            this.Controls.Add(this.tbPasswordLecturer);
            this.Controls.Add(this.tbIDLecturer);
            this.Controls.Add(this.pbLecturer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LogInLecturer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In As A Lecturer";
            this.Load += new System.EventHandler(this.LogInLecturer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLecturer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogInLecturer;
        private System.Windows.Forms.Button btnBackLecturer;
        private System.Windows.Forms.Label lblIDTxt;
        private System.Windows.Forms.Label lblPassTxt;
        private System.Windows.Forms.TextBox tbPasswordLecturer;
        private System.Windows.Forms.TextBox tbIDLecturer;
        private System.Windows.Forms.PictureBox pbLecturer;
    }
}