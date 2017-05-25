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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btBackStudent = new System.Windows.Forms.Button();
            this.btLogInStudent = new System.Windows.Forms.Button();
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
            this.tbFNumberStudent.Location = new System.Drawing.Point(84, 160);
            this.tbFNumberStudent.Name = "tbFNumberStudent";
            this.tbFNumberStudent.Size = new System.Drawing.Size(161, 20);
            this.tbFNumberStudent.TabIndex = 1;
            // 
            // tbIDNumberStudent
            // 
            this.tbIDNumberStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDNumberStudent.Location = new System.Drawing.Point(84, 214);
            this.tbIDNumberStudent.Name = "tbIDNumberStudent";
            this.tbIDNumberStudent.Size = new System.Drawing.Size(161, 21);
            this.tbIDNumberStudent.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Faculty Number:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Identification Number (EGN)";
            // 
            // btBackStudent
            // 
            this.btBackStudent.BackColor = System.Drawing.Color.LightGray;
            this.btBackStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBackStudent.Location = new System.Drawing.Point(12, 278);
            this.btBackStudent.Name = "btBackStudent";
            this.btBackStudent.Size = new System.Drawing.Size(98, 42);
            this.btBackStudent.TabIndex = 5;
            this.btBackStudent.Text = "Back";
            this.btBackStudent.UseVisualStyleBackColor = false;
            // 
            // btLogInStudent
            // 
            this.btLogInStudent.BackColor = System.Drawing.Color.LightGray;
            this.btLogInStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogInStudent.Location = new System.Drawing.Point(223, 278);
            this.btLogInStudent.Name = "btLogInStudent";
            this.btLogInStudent.Size = new System.Drawing.Size(98, 42);
            this.btLogInStudent.TabIndex = 6;
            this.btLogInStudent.Text = "Log in";
            this.btLogInStudent.UseVisualStyleBackColor = false;
            // 
            // LogInStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(333, 332);
            this.Controls.Add(this.btLogInStudent);
            this.Controls.Add(this.btBackStudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIDNumberStudent);
            this.Controls.Add(this.tbFNumberStudent);
            this.Controls.Add(this.pbLogInStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LogInStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In As A Student";
            this.Load += new System.EventHandler(this.LogInStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogInStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogInStudent;
        private System.Windows.Forms.TextBox tbFNumberStudent;
        private System.Windows.Forms.TextBox tbIDNumberStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btBackStudent;
        private System.Windows.Forms.Button btLogInStudent;
    }
}