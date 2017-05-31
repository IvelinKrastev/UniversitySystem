namespace UniversitySystem
{
    partial class LogInStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInStudent));
            this.pbLogInStudent = new System.Windows.Forms.PictureBox();
            this.tbFNumberStudent = new System.Windows.Forms.TextBox();
            this.tbIDNumberStudent = new System.Windows.Forms.TextBox();
            this.lblFacNumberTxt = new System.Windows.Forms.Label();
            this.lblIdTxt = new System.Windows.Forms.Label();
            this.btnBackStudent = new System.Windows.Forms.Button();
            this.btnLogInStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogInStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogInStudent
            // 
            this.pbLogInStudent.Image = global::UniversitySystem.Properties.Resources.Student;
            this.pbLogInStudent.Location = new System.Drawing.Point(97, 12);
            this.pbLogInStudent.Name = "pbLogInStudent";
            this.pbLogInStudent.Size = new System.Drawing.Size(136, 112);
            this.pbLogInStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogInStudent.TabIndex = 0;
            this.pbLogInStudent.TabStop = false;
            // 
            // tbFNumberStudent
            // 
            this.tbFNumberStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFNumberStudent.Location = new System.Drawing.Point(84, 160);
            this.tbFNumberStudent.Name = "tbFNumberStudent";
            this.tbFNumberStudent.Size = new System.Drawing.Size(161, 21);
            this.tbFNumberStudent.TabIndex = 1;
            this.tbFNumberStudent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputField_KeyDown);
            // 
            // tbIDNumberStudent
            // 
            this.tbIDNumberStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDNumberStudent.Location = new System.Drawing.Point(84, 214);
            this.tbIDNumberStudent.Name = "tbIDNumberStudent";
            this.tbIDNumberStudent.PasswordChar = '*';
            this.tbIDNumberStudent.Size = new System.Drawing.Size(161, 21);
            this.tbIDNumberStudent.TabIndex = 2;
            this.tbIDNumberStudent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputField_KeyDown);
            // 
            // lblFacNumberTxt
            // 
            this.lblFacNumberTxt.AutoSize = true;
            this.lblFacNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacNumberTxt.Location = new System.Drawing.Point(117, 142);
            this.lblFacNumberTxt.Name = "lblFacNumberTxt";
            this.lblFacNumberTxt.Size = new System.Drawing.Size(96, 15);
            this.lblFacNumberTxt.TabIndex = 3;
            this.lblFacNumberTxt.Text = "Faculty Number:";
            // 
            // lblIdTxt
            // 
            this.lblIdTxt.AutoSize = true;
            this.lblIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdTxt.Location = new System.Drawing.Point(84, 196);
            this.lblIdTxt.Name = "lblIdTxt";
            this.lblIdTxt.Size = new System.Drawing.Size(161, 15);
            this.lblIdTxt.TabIndex = 4;
            this.lblIdTxt.Text = "Identification Number (EGN)";
            // 
            // btnBackStudent
            // 
            this.btnBackStudent.BackColor = System.Drawing.Color.LightGray;
            this.btnBackStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackStudent.Location = new System.Drawing.Point(12, 278);
            this.btnBackStudent.Name = "btnBackStudent";
            this.btnBackStudent.Size = new System.Drawing.Size(98, 42);
            this.btnBackStudent.TabIndex = 5;
            this.btnBackStudent.Text = "Back";
            this.btnBackStudent.UseVisualStyleBackColor = false;
            this.btnBackStudent.Click += new System.EventHandler(this.btnBackStudent_Click);
            // 
            // btnLogInStudent
            // 
            this.btnLogInStudent.BackColor = System.Drawing.Color.LightGray;
            this.btnLogInStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogInStudent.Location = new System.Drawing.Point(223, 278);
            this.btnLogInStudent.Name = "btnLogInStudent";
            this.btnLogInStudent.Size = new System.Drawing.Size(98, 42);
            this.btnLogInStudent.TabIndex = 6;
            this.btnLogInStudent.Text = "Log in";
            this.btnLogInStudent.UseVisualStyleBackColor = false;
            this.btnLogInStudent.Click += new System.EventHandler(this.btnLogInStudent_Click);
            // 
            // LogInStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(333, 332);
            this.Controls.Add(this.btnLogInStudent);
            this.Controls.Add(this.btnBackStudent);
            this.Controls.Add(this.lblIdTxt);
            this.Controls.Add(this.lblFacNumberTxt);
            this.Controls.Add(this.tbIDNumberStudent);
            this.Controls.Add(this.tbFNumberStudent);
            this.Controls.Add(this.pbLogInStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LogInStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In As A Student";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogInStudent_FormClosing);
            this.Load += new System.EventHandler(this.LogInStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogInStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogInStudent;
        private System.Windows.Forms.TextBox tbIDNumberStudent;
        private System.Windows.Forms.Label lblFacNumberTxt;
        private System.Windows.Forms.Label lblIdTxt;
        private System.Windows.Forms.Button btnBackStudent;
        private System.Windows.Forms.Button btnLogInStudent;
        public System.Windows.Forms.TextBox tbFNumberStudent;
    }
}