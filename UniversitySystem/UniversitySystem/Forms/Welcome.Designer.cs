namespace UniversitySystem
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.pbLecturer = new System.Windows.Forms.PictureBox();
            this.pbStudent = new System.Windows.Forms.PictureBox();
            this.lblWelcomeTxt = new System.Windows.Forms.Label();
            this.lblLecturerTxt = new System.Windows.Forms.Label();
            this.lblStudentTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLecturer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLecturer
            // 
            this.pbLecturer.BackColor = System.Drawing.Color.Gainsboro;
            this.pbLecturer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLecturer.Image = global::UniversitySystem.Properties.Resources.Lecturer;
            this.pbLecturer.Location = new System.Drawing.Point(52, 80);
            this.pbLecturer.Name = "pbLecturer";
            this.pbLecturer.Size = new System.Drawing.Size(121, 120);
            this.pbLecturer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLecturer.TabIndex = 0;
            this.pbLecturer.TabStop = false;
            this.pbLecturer.Click += new System.EventHandler(this.pbLecturer_Click);
            // 
            // pbStudent
            // 
            this.pbStudent.BackColor = System.Drawing.Color.Gainsboro;
            this.pbStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbStudent.Image = global::UniversitySystem.Properties.Resources.Student;
            this.pbStudent.Location = new System.Drawing.Point(223, 80);
            this.pbStudent.Name = "pbStudent";
            this.pbStudent.Size = new System.Drawing.Size(121, 120);
            this.pbStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStudent.TabIndex = 1;
            this.pbStudent.TabStop = false;
            this.pbStudent.Click += new System.EventHandler(this.pbStudent_Click);
            // 
            // lblWelcomeTxt
            // 
            this.lblWelcomeTxt.AutoSize = true;
            this.lblWelcomeTxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeTxt.Location = new System.Drawing.Point(12, 20);
            this.lblWelcomeTxt.Name = "lblWelcomeTxt";
            this.lblWelcomeTxt.Size = new System.Drawing.Size(372, 19);
            this.lblWelcomeTxt.TabIndex = 2;
            this.lblWelcomeTxt.Text = "Welcome to the University Informational System";
            // 
            // lblLecturerTxt
            // 
            this.lblLecturerTxt.AutoSize = true;
            this.lblLecturerTxt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLecturerTxt.Location = new System.Drawing.Point(80, 203);
            this.lblLecturerTxt.Name = "lblLecturerTxt";
            this.lblLecturerTxt.Size = new System.Drawing.Size(61, 16);
            this.lblLecturerTxt.TabIndex = 3;
            this.lblLecturerTxt.Text = "Lecturer";
            // 
            // lblStudentTxt
            // 
            this.lblStudentTxt.AutoSize = true;
            this.lblStudentTxt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentTxt.Location = new System.Drawing.Point(257, 203);
            this.lblStudentTxt.Name = "lblStudentTxt";
            this.lblStudentTxt.Size = new System.Drawing.Size(57, 16);
            this.lblStudentTxt.TabIndex = 4;
            this.lblStudentTxt.Text = "Student";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(396, 268);
            this.Controls.Add(this.lblStudentTxt);
            this.Controls.Add(this.lblLecturerTxt);
            this.Controls.Add(this.lblWelcomeTxt);
            this.Controls.Add(this.pbStudent);
            this.Controls.Add(this.pbLecturer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.pbLecturer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLecturer;
        private System.Windows.Forms.PictureBox pbStudent;
        private System.Windows.Forms.Label lblWelcomeTxt;
        private System.Windows.Forms.Label lblLecturerTxt;
        private System.Windows.Forms.Label lblStudentTxt;
    }
}

