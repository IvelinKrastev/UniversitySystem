namespace UniversitySystem.Forms
{
    partial class LecturerWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LecturerWindow));
            this.tabLecturer = new System.Windows.Forms.TabControl();
            this.tabLecturerHome = new System.Windows.Forms.TabPage();
            this.lblDegree = new System.Windows.Forms.Label();
            this.lblDegreeTxt = new System.Windows.Forms.Label();
            this.lblIDTxt = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblLastNameTxt = new System.Windows.Forms.Label();
            this.lblSecondNameTxt = new System.Windows.Forms.Label();
            this.lblFirstNameTxt = new System.Windows.Forms.Label();
            this.lblDisciplinesTxt = new System.Windows.Forms.Label();
            this.lbDisciplinesTaught = new System.Windows.Forms.ListBox();
            this.tabLecturerStudentAssessments = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.TextBox();
            this.tab = new System.Windows.Forms.TabPage();
            this.btnLogOutStudent = new System.Windows.Forms.Button();
            this.pbLecturerPic = new System.Windows.Forms.PictureBox();
            this.pbLecturerWorkSchedule = new System.Windows.Forms.PictureBox();
            this.tabLecturer.SuspendLayout();
            this.tabLecturerHome.SuspendLayout();
            this.tabLecturerStudentAssessments.SuspendLayout();
            this.tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLecturerPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLecturerWorkSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // tabLecturer
            // 
            this.tabLecturer.Controls.Add(this.tabLecturerHome);
            this.tabLecturer.Controls.Add(this.tabLecturerStudentAssessments);
            this.tabLecturer.Controls.Add(this.tab);
            this.tabLecturer.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabLecturer.Location = new System.Drawing.Point(0, 0);
            this.tabLecturer.Name = "tabLecturer";
            this.tabLecturer.SelectedIndex = 0;
            this.tabLecturer.Size = new System.Drawing.Size(693, 343);
            this.tabLecturer.TabIndex = 0;
            // 
            // tabLecturerHome
            // 
            this.tabLecturerHome.BackColor = System.Drawing.Color.Gainsboro;
            this.tabLecturerHome.Controls.Add(this.lblDegree);
            this.tabLecturerHome.Controls.Add(this.lblDegreeTxt);
            this.tabLecturerHome.Controls.Add(this.lblIDTxt);
            this.tabLecturerHome.Controls.Add(this.lblId);
            this.tabLecturerHome.Controls.Add(this.lblFirstName);
            this.tabLecturerHome.Controls.Add(this.lblSecondName);
            this.tabLecturerHome.Controls.Add(this.lblLastName);
            this.tabLecturerHome.Controls.Add(this.lblLastNameTxt);
            this.tabLecturerHome.Controls.Add(this.lblSecondNameTxt);
            this.tabLecturerHome.Controls.Add(this.lblFirstNameTxt);
            this.tabLecturerHome.Controls.Add(this.lblDisciplinesTxt);
            this.tabLecturerHome.Controls.Add(this.lbDisciplinesTaught);
            this.tabLecturerHome.Controls.Add(this.pbLecturerPic);
            this.tabLecturerHome.Location = new System.Drawing.Point(4, 22);
            this.tabLecturerHome.Name = "tabLecturerHome";
            this.tabLecturerHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabLecturerHome.Size = new System.Drawing.Size(685, 317);
            this.tabLecturerHome.TabIndex = 0;
            this.tabLecturerHome.Text = "Home";
            // 
            // lblDegree
            // 
            this.lblDegree.AutoSize = true;
            this.lblDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDegree.Location = new System.Drawing.Point(133, 20);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Size = new System.Drawing.Size(0, 15);
            this.lblDegree.TabIndex = 48;
            // 
            // lblDegreeTxt
            // 
            this.lblDegreeTxt.AutoSize = true;
            this.lblDegreeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDegreeTxt.Location = new System.Drawing.Point(6, 20);
            this.lblDegreeTxt.Name = "lblDegreeTxt";
            this.lblDegreeTxt.Size = new System.Drawing.Size(121, 15);
            this.lblDegreeTxt.TabIndex = 47;
            this.lblDegreeTxt.Text = "Scientific Degree:";
            // 
            // lblIDTxt
            // 
            this.lblIDTxt.AutoSize = true;
            this.lblIDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDTxt.Location = new System.Drawing.Point(6, 140);
            this.lblIDTxt.Name = "lblIDTxt";
            this.lblIDTxt.Size = new System.Drawing.Size(86, 15);
            this.lblIDTxt.TabIndex = 46;
            this.lblIDTxt.Text = "Personal ID:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(133, 140);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 15);
            this.lblId.TabIndex = 45;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(133, 50);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(0, 15);
            this.lblFirstName.TabIndex = 44;
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondName.Location = new System.Drawing.Point(133, 80);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(0, 15);
            this.lblSecondName.TabIndex = 43;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(133, 110);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(0, 15);
            this.lblLastName.TabIndex = 42;
            // 
            // lblLastNameTxt
            // 
            this.lblLastNameTxt.AutoSize = true;
            this.lblLastNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastNameTxt.Location = new System.Drawing.Point(6, 110);
            this.lblLastNameTxt.Name = "lblLastNameTxt";
            this.lblLastNameTxt.Size = new System.Drawing.Size(80, 15);
            this.lblLastNameTxt.TabIndex = 39;
            this.lblLastNameTxt.Text = "Last Name:";
            // 
            // lblSecondNameTxt
            // 
            this.lblSecondNameTxt.AutoSize = true;
            this.lblSecondNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondNameTxt.Location = new System.Drawing.Point(6, 80);
            this.lblSecondNameTxt.Name = "lblSecondNameTxt";
            this.lblSecondNameTxt.Size = new System.Drawing.Size(101, 15);
            this.lblSecondNameTxt.TabIndex = 37;
            this.lblSecondNameTxt.Text = "Second Name:";
            // 
            // lblFirstNameTxt
            // 
            this.lblFirstNameTxt.AutoSize = true;
            this.lblFirstNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNameTxt.Location = new System.Drawing.Point(6, 50);
            this.lblFirstNameTxt.Name = "lblFirstNameTxt";
            this.lblFirstNameTxt.Size = new System.Drawing.Size(81, 15);
            this.lblFirstNameTxt.TabIndex = 35;
            this.lblFirstNameTxt.Text = "First Name:";
            // 
            // lblDisciplinesTxt
            // 
            this.lblDisciplinesTxt.AutoSize = true;
            this.lblDisciplinesTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisciplinesTxt.Location = new System.Drawing.Point(449, 23);
            this.lblDisciplinesTxt.Name = "lblDisciplinesTxt";
            this.lblDisciplinesTxt.Size = new System.Drawing.Size(156, 20);
            this.lblDisciplinesTxt.TabIndex = 33;
            this.lblDisciplinesTxt.Text = "Disciplines Taught";
            // 
            // lbDisciplinesTaught
            // 
            this.lbDisciplinesTaught.BackColor = System.Drawing.Color.LightGray;
            this.lbDisciplinesTaught.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisciplinesTaught.FormattingEnabled = true;
            this.lbDisciplinesTaught.ItemHeight = 16;
            this.lbDisciplinesTaught.Location = new System.Drawing.Point(380, 46);
            this.lbDisciplinesTaught.Name = "lbDisciplinesTaught";
            this.lbDisciplinesTaught.Size = new System.Drawing.Size(299, 228);
            this.lbDisciplinesTaught.TabIndex = 8;
            // 
            // tabLecturerStudentAssessments
            // 
            this.tabLecturerStudentAssessments.Controls.Add(this.label4);
            this.tabLecturerStudentAssessments.Controls.Add(this.textBox1);
            this.tabLecturerStudentAssessments.Controls.Add(this.listBox1);
            this.tabLecturerStudentAssessments.Controls.Add(this.label2);
            this.tabLecturerStudentAssessments.Controls.Add(this.tb);
            this.tabLecturerStudentAssessments.Location = new System.Drawing.Point(4, 22);
            this.tabLecturerStudentAssessments.Name = "tabLecturerStudentAssessments";
            this.tabLecturerStudentAssessments.Padding = new System.Windows.Forms.Padding(3);
            this.tabLecturerStudentAssessments.Size = new System.Drawing.Size(685, 317);
            this.tabLecturerStudentAssessments.TabIndex = 1;
            this.tabLecturerStudentAssessments.Text = "Student Assessments";
            this.tabLecturerStudentAssessments.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Grade:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(349, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(449, 186);
            this.listBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Faculty Number:";
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(98, 6);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(100, 20);
            this.tb.TabIndex = 0;
            // 
            // tab
            // 
            this.tab.Controls.Add(this.pbLecturerWorkSchedule);
            this.tab.Location = new System.Drawing.Point(4, 22);
            this.tab.Name = "tab";
            this.tab.Padding = new System.Windows.Forms.Padding(3);
            this.tab.Size = new System.Drawing.Size(685, 317);
            this.tab.TabIndex = 2;
            this.tab.Text = "Work schedule";
            this.tab.UseVisualStyleBackColor = true;
            // 
            // btnLogOutStudent
            // 
            this.btnLogOutStudent.BackColor = System.Drawing.Color.LightGray;
            this.btnLogOutStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOutStudent.Location = new System.Drawing.Point(591, 349);
            this.btnLogOutStudent.Name = "btnLogOutStudent";
            this.btnLogOutStudent.Size = new System.Drawing.Size(98, 42);
            this.btnLogOutStudent.TabIndex = 16;
            this.btnLogOutStudent.Text = "Log Out";
            this.btnLogOutStudent.UseVisualStyleBackColor = false;
            this.btnLogOutStudent.Click += new System.EventHandler(this.btnLogOutStudent_Click);
            // 
            // pbLecturerPic
            // 
            this.pbLecturerPic.Location = new System.Drawing.Point(6, 167);
            this.pbLecturerPic.Name = "pbLecturerPic";
            this.pbLecturerPic.Size = new System.Drawing.Size(245, 144);
            this.pbLecturerPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLecturerPic.TabIndex = 3;
            this.pbLecturerPic.TabStop = false;
            this.pbLecturerPic.Click += new System.EventHandler(this.pbLecturerPic_Click);
            // 
            // pbLecturerWorkSchedule
            // 
            this.pbLecturerWorkSchedule.Location = new System.Drawing.Point(8, 8);
            this.pbLecturerWorkSchedule.Name = "pbLecturerWorkSchedule";
            this.pbLecturerWorkSchedule.Size = new System.Drawing.Size(669, 303);
            this.pbLecturerWorkSchedule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLecturerWorkSchedule.TabIndex = 0;
            this.pbLecturerWorkSchedule.TabStop = false;
            // 
            // LecturerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(693, 403);
            this.Controls.Add(this.btnLogOutStudent);
            this.Controls.Add(this.tabLecturer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LecturerWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello, Lecturer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LecturerWindow_FormClosing);
            this.Load += new System.EventHandler(this.LecturerWindow_Load);
            this.tabLecturer.ResumeLayout(false);
            this.tabLecturerHome.ResumeLayout(false);
            this.tabLecturerHome.PerformLayout();
            this.tabLecturerStudentAssessments.ResumeLayout(false);
            this.tabLecturerStudentAssessments.PerformLayout();
            this.tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLecturerPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLecturerWorkSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabLecturer;
        private System.Windows.Forms.TabPage tabLecturerHome;
        private System.Windows.Forms.TabPage tabLecturerStudentAssessments;
        private System.Windows.Forms.ListBox lbDisciplinesTaught;
        private System.Windows.Forms.PictureBox pbLecturerPic;
        private System.Windows.Forms.TabPage tab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Button btnLogOutStudent;
        private System.Windows.Forms.Label lblDisciplinesTxt;
        private System.Windows.Forms.Label lblLastNameTxt;
        private System.Windows.Forms.Label lblSecondNameTxt;
        private System.Windows.Forms.Label lblFirstNameTxt;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblIDTxt;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblDegree;
        private System.Windows.Forms.Label lblDegreeTxt;
        private System.Windows.Forms.PictureBox pbLecturerWorkSchedule;
    }
}