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
            this.pbLogInStudent.Location = new System.Drawing.Point(76, 12);
            this.pbLogInStudent.Name = "pbLogInStudent";
            this.pbLogInStudent.Size = new System.Drawing.Size(128, 97);
            this.pbLogInStudent.TabIndex = 0;
            this.pbLogInStudent.TabStop = false;
            // 
            // tbFNumberStudent
            // 
            this.tbFNumberStudent.Location = new System.Drawing.Point(76, 137);
            this.tbFNumberStudent.Name = "tbFNumberStudent";
            this.tbFNumberStudent.Size = new System.Drawing.Size(128, 20);
            this.tbFNumberStudent.TabIndex = 1;
            // 
            // tbIDNumberStudent
            // 
            this.tbIDNumberStudent.Location = new System.Drawing.Point(76, 189);
            this.tbIDNumberStudent.Name = "tbIDNumberStudent";
            this.tbIDNumberStudent.Size = new System.Drawing.Size(128, 20);
            this.tbIDNumberStudent.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Faculty Number:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Identification Number (EGN)";
            // 
            // btBackStudent
            // 
            this.btBackStudent.Location = new System.Drawing.Point(12, 247);
            this.btBackStudent.Name = "btBackStudent";
            this.btBackStudent.Size = new System.Drawing.Size(75, 23);
            this.btBackStudent.TabIndex = 5;
            this.btBackStudent.Text = "Back";
            this.btBackStudent.UseVisualStyleBackColor = true;
            // 
            // btLogInStudent
            // 
            this.btLogInStudent.Location = new System.Drawing.Point(197, 247);
            this.btLogInStudent.Name = "btLogInStudent";
            this.btLogInStudent.Size = new System.Drawing.Size(75, 23);
            this.btLogInStudent.TabIndex = 6;
            this.btLogInStudent.Text = "Log in";
            this.btLogInStudent.UseVisualStyleBackColor = true;
            // 
            // LogInStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 282);
            this.Controls.Add(this.btLogInStudent);
            this.Controls.Add(this.btBackStudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIDNumberStudent);
            this.Controls.Add(this.tbFNumberStudent);
            this.Controls.Add(this.pbLogInStudent);
            this.Name = "LogInStudent";
            this.Text = "LogInStudent";
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