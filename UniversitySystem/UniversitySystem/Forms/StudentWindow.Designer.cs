namespace UniversitySystem.Forms
{
    partial class StudentWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentWindow));
            this.tabStudent = new System.Windows.Forms.TabControl();
            this.tabStudentHome = new System.Windows.Forms.TabPage();
            this.lblDisciplinesTxt = new System.Windows.Forms.Label();
            this.lblGroupTxt = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblCourseTxt = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblSpecialtyTxt = new System.Windows.Forms.Label();
            this.lblSpecialty = new System.Windows.Forms.Label();
            this.lbDegreeTxt = new System.Windows.Forms.Label();
            this.lblDegree = new System.Windows.Forms.Label();
            this.lblIDTxt = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblFNumberTxt = new System.Windows.Forms.Label();
            this.lblFacNumber = new System.Windows.Forms.Label();
            this.lblLastNameTxt = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblSecondNameTxt = new System.Windows.Forms.Label();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.lbDisciplinesForCourse = new System.Windows.Forms.ListBox();
            this.lblFirstNameTxt = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tabStudentAssessments = new System.Windows.Forms.TabPage();
            this.lbAssessmentsStudent = new System.Windows.Forms.ListBox();
            this.tabStudentSchedule = new System.Windows.Forms.TabPage();
            this.btnLogOutStudent = new System.Windows.Forms.Button();
            this.pbStudentSchedule = new System.Windows.Forms.PictureBox();
            this.tabStudent.SuspendLayout();
            this.tabStudentHome.SuspendLayout();
            this.tabStudentAssessments.SuspendLayout();
            this.tabStudentSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudentSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // tabStudent
            // 
            this.tabStudent.Controls.Add(this.tabStudentHome);
            this.tabStudent.Controls.Add(this.tabStudentAssessments);
            this.tabStudent.Controls.Add(this.tabStudentSchedule);
            this.tabStudent.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabStudent.Location = new System.Drawing.Point(0, 0);
            this.tabStudent.Name = "tabStudent";
            this.tabStudent.SelectedIndex = 0;
            this.tabStudent.Size = new System.Drawing.Size(693, 325);
            this.tabStudent.TabIndex = 0;
            // 
            // tabStudentHome
            // 
            this.tabStudentHome.BackColor = System.Drawing.Color.Gainsboro;
            this.tabStudentHome.Controls.Add(this.lblDisciplinesTxt);
            this.tabStudentHome.Controls.Add(this.lblGroupTxt);
            this.tabStudentHome.Controls.Add(this.lblGroup);
            this.tabStudentHome.Controls.Add(this.lblCourseTxt);
            this.tabStudentHome.Controls.Add(this.lblCourse);
            this.tabStudentHome.Controls.Add(this.lblSpecialtyTxt);
            this.tabStudentHome.Controls.Add(this.lblSpecialty);
            this.tabStudentHome.Controls.Add(this.lbDegreeTxt);
            this.tabStudentHome.Controls.Add(this.lblDegree);
            this.tabStudentHome.Controls.Add(this.lblIDTxt);
            this.tabStudentHome.Controls.Add(this.lblId);
            this.tabStudentHome.Controls.Add(this.lblFNumberTxt);
            this.tabStudentHome.Controls.Add(this.lblFacNumber);
            this.tabStudentHome.Controls.Add(this.lblLastNameTxt);
            this.tabStudentHome.Controls.Add(this.lblLastName);
            this.tabStudentHome.Controls.Add(this.lblSecondNameTxt);
            this.tabStudentHome.Controls.Add(this.lblSecondName);
            this.tabStudentHome.Controls.Add(this.lbDisciplinesForCourse);
            this.tabStudentHome.Controls.Add(this.lblFirstNameTxt);
            this.tabStudentHome.Controls.Add(this.lblFirstName);
            this.tabStudentHome.Location = new System.Drawing.Point(4, 22);
            this.tabStudentHome.Name = "tabStudentHome";
            this.tabStudentHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudentHome.Size = new System.Drawing.Size(685, 299);
            this.tabStudentHome.TabIndex = 0;
            this.tabStudentHome.Text = "Home";
            // 
            // lblDisciplinesTxt
            // 
            this.lblDisciplinesTxt.AutoSize = true;
            this.lblDisciplinesTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisciplinesTxt.Location = new System.Drawing.Point(486, 20);
            this.lblDisciplinesTxt.Name = "lblDisciplinesTxt";
            this.lblDisciplinesTxt.Size = new System.Drawing.Size(95, 20);
            this.lblDisciplinesTxt.TabIndex = 32;
            this.lblDisciplinesTxt.Text = "Disciplines";
            // 
            // lblGroupTxt
            // 
            this.lblGroupTxt.AutoSize = true;
            this.lblGroupTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupTxt.Location = new System.Drawing.Point(6, 260);
            this.lblGroupTxt.Name = "lblGroupTxt";
            this.lblGroupTxt.Size = new System.Drawing.Size(50, 15);
            this.lblGroupTxt.TabIndex = 31;
            this.lblGroupTxt.Text = "Group:";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroup.Location = new System.Drawing.Point(123, 260);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(0, 15);
            this.lblGroup.TabIndex = 30;
            // 
            // lblCourseTxt
            // 
            this.lblCourseTxt.AutoSize = true;
            this.lblCourseTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseTxt.Location = new System.Drawing.Point(6, 230);
            this.lblCourseTxt.Name = "lblCourseTxt";
            this.lblCourseTxt.Size = new System.Drawing.Size(56, 15);
            this.lblCourseTxt.TabIndex = 29;
            this.lblCourseTxt.Text = "Course:";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(123, 230);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(0, 15);
            this.lblCourse.TabIndex = 28;
            // 
            // lblSpecialtyTxt
            // 
            this.lblSpecialtyTxt.AutoSize = true;
            this.lblSpecialtyTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialtyTxt.Location = new System.Drawing.Point(6, 200);
            this.lblSpecialtyTxt.Name = "lblSpecialtyTxt";
            this.lblSpecialtyTxt.Size = new System.Drawing.Size(69, 15);
            this.lblSpecialtyTxt.TabIndex = 27;
            this.lblSpecialtyTxt.Text = "Specialty:";
            // 
            // lblSpecialty
            // 
            this.lblSpecialty.AutoSize = true;
            this.lblSpecialty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialty.Location = new System.Drawing.Point(123, 200);
            this.lblSpecialty.Name = "lblSpecialty";
            this.lblSpecialty.Size = new System.Drawing.Size(0, 15);
            this.lblSpecialty.TabIndex = 26;
            // 
            // lbDegreeTxt
            // 
            this.lbDegreeTxt.AutoSize = true;
            this.lbDegreeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDegreeTxt.Location = new System.Drawing.Point(6, 170);
            this.lbDegreeTxt.Name = "lbDegreeTxt";
            this.lbDegreeTxt.Size = new System.Drawing.Size(58, 15);
            this.lbDegreeTxt.TabIndex = 25;
            this.lbDegreeTxt.Text = "Degree:";
            // 
            // lblDegree
            // 
            this.lblDegree.AutoSize = true;
            this.lblDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDegree.Location = new System.Drawing.Point(123, 170);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Size = new System.Drawing.Size(0, 15);
            this.lblDegree.TabIndex = 24;
            // 
            // lblIDTxt
            // 
            this.lblIDTxt.AutoSize = true;
            this.lblIDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDTxt.Location = new System.Drawing.Point(6, 110);
            this.lblIDTxt.Name = "lblIDTxt";
            this.lblIDTxt.Size = new System.Drawing.Size(86, 15);
            this.lblIDTxt.TabIndex = 23;
            this.lblIDTxt.Text = "Personal ID:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(123, 110);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 15);
            this.lblId.TabIndex = 22;
            // 
            // lblFNumberTxt
            // 
            this.lblFNumberTxt.AutoSize = true;
            this.lblFNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFNumberTxt.Location = new System.Drawing.Point(6, 140);
            this.lblFNumberTxt.Name = "lblFNumberTxt";
            this.lblFNumberTxt.Size = new System.Drawing.Size(111, 15);
            this.lblFNumberTxt.TabIndex = 21;
            this.lblFNumberTxt.Text = "Faculty Number:";
            // 
            // lblFacNumber
            // 
            this.lblFacNumber.AutoSize = true;
            this.lblFacNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacNumber.Location = new System.Drawing.Point(123, 140);
            this.lblFacNumber.Name = "lblFacNumber";
            this.lblFacNumber.Size = new System.Drawing.Size(0, 15);
            this.lblFacNumber.TabIndex = 20;
            // 
            // lblLastNameTxt
            // 
            this.lblLastNameTxt.AutoSize = true;
            this.lblLastNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastNameTxt.Location = new System.Drawing.Point(6, 80);
            this.lblLastNameTxt.Name = "lblLastNameTxt";
            this.lblLastNameTxt.Size = new System.Drawing.Size(80, 15);
            this.lblLastNameTxt.TabIndex = 19;
            this.lblLastNameTxt.Text = "Last Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(123, 80);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(0, 15);
            this.lblLastName.TabIndex = 18;
            // 
            // lblSecondNameTxt
            // 
            this.lblSecondNameTxt.AutoSize = true;
            this.lblSecondNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondNameTxt.Location = new System.Drawing.Point(6, 50);
            this.lblSecondNameTxt.Name = "lblSecondNameTxt";
            this.lblSecondNameTxt.Size = new System.Drawing.Size(101, 15);
            this.lblSecondNameTxt.TabIndex = 17;
            this.lblSecondNameTxt.Text = "Second Name:";
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondName.Location = new System.Drawing.Point(123, 50);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(0, 15);
            this.lblSecondName.TabIndex = 16;
            // 
            // lbDisciplinesForCourse
            // 
            this.lbDisciplinesForCourse.BackColor = System.Drawing.Color.LightGray;
            this.lbDisciplinesForCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisciplinesForCourse.FormattingEnabled = true;
            this.lbDisciplinesForCourse.ItemHeight = 16;
            this.lbDisciplinesForCourse.Location = new System.Drawing.Point(380, 46);
            this.lbDisciplinesForCourse.Name = "lbDisciplinesForCourse";
            this.lbDisciplinesForCourse.Size = new System.Drawing.Size(299, 228);
            this.lbDisciplinesForCourse.TabIndex = 12;
            // 
            // lblFirstNameTxt
            // 
            this.lblFirstNameTxt.AutoSize = true;
            this.lblFirstNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNameTxt.Location = new System.Drawing.Point(6, 20);
            this.lblFirstNameTxt.Name = "lblFirstNameTxt";
            this.lblFirstNameTxt.Size = new System.Drawing.Size(81, 15);
            this.lblFirstNameTxt.TabIndex = 6;
            this.lblFirstNameTxt.Text = "First Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(123, 20);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(0, 15);
            this.lblFirstName.TabIndex = 0;
            // 
            // tabStudentAssessments
            // 
            this.tabStudentAssessments.BackColor = System.Drawing.Color.Gainsboro;
            this.tabStudentAssessments.Controls.Add(this.lbAssessmentsStudent);
            this.tabStudentAssessments.Location = new System.Drawing.Point(4, 22);
            this.tabStudentAssessments.Name = "tabStudentAssessments";
            this.tabStudentAssessments.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudentAssessments.Size = new System.Drawing.Size(685, 299);
            this.tabStudentAssessments.TabIndex = 1;
            this.tabStudentAssessments.Text = "Assessments";
            // 
            // lbAssessmentsStudent
            // 
            this.lbAssessmentsStudent.BackColor = System.Drawing.Color.Gainsboro;
            this.lbAssessmentsStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAssessmentsStudent.FormattingEnabled = true;
            this.lbAssessmentsStudent.Location = new System.Drawing.Point(3, 3);
            this.lbAssessmentsStudent.Name = "lbAssessmentsStudent";
            this.lbAssessmentsStudent.Size = new System.Drawing.Size(679, 293);
            this.lbAssessmentsStudent.TabIndex = 0;
            // 
            // tabStudentSchedule
            // 
            this.tabStudentSchedule.BackColor = System.Drawing.Color.Gainsboro;
            this.tabStudentSchedule.Controls.Add(this.pbStudentSchedule);
            this.tabStudentSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabStudentSchedule.Location = new System.Drawing.Point(4, 22);
            this.tabStudentSchedule.Name = "tabStudentSchedule";
            this.tabStudentSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudentSchedule.Size = new System.Drawing.Size(685, 299);
            this.tabStudentSchedule.TabIndex = 2;
            this.tabStudentSchedule.Text = "Schedule";
            // 
            // btnLogOutStudent
            // 
            this.btnLogOutStudent.BackColor = System.Drawing.Color.LightGray;
            this.btnLogOutStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOutStudent.Location = new System.Drawing.Point(591, 331);
            this.btnLogOutStudent.Name = "btnLogOutStudent";
            this.btnLogOutStudent.Size = new System.Drawing.Size(98, 42);
            this.btnLogOutStudent.TabIndex = 15;
            this.btnLogOutStudent.Text = "Log Out";
            this.btnLogOutStudent.UseVisualStyleBackColor = false;
            this.btnLogOutStudent.Click += new System.EventHandler(this.btnLogOutStudent_Click);
            // 
            // pbStudentSchedule
            // 
            this.pbStudentSchedule.Location = new System.Drawing.Point(126, 6);
            this.pbStudentSchedule.Name = "pbStudentSchedule";
            this.pbStudentSchedule.Size = new System.Drawing.Size(405, 287);
            this.pbStudentSchedule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStudentSchedule.TabIndex = 0;
            this.pbStudentSchedule.TabStop = false;
            // 
            // StudentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(693, 385);
            this.Controls.Add(this.tabStudent);
            this.Controls.Add(this.btnLogOutStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StudentWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello, Student";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentWindow_FormClosing);
            this.Load += new System.EventHandler(this.StudentWindow_Load);
            this.tabStudent.ResumeLayout(false);
            this.tabStudentHome.ResumeLayout(false);
            this.tabStudentHome.PerformLayout();
            this.tabStudentAssessments.ResumeLayout(false);
            this.tabStudentSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbStudentSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabStudent;
        private System.Windows.Forms.TabPage tabStudentHome;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TabPage tabStudentAssessments;
        private System.Windows.Forms.TabPage tabStudentSchedule;
        private System.Windows.Forms.Label lblFirstNameTxt;
        private System.Windows.Forms.ListBox lbDisciplinesForCourse;
        private System.Windows.Forms.ListBox lbAssessmentsStudent;
        private System.Windows.Forms.Button btnLogOutStudent;
        private System.Windows.Forms.Label lblSecondNameTxt;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.Label lblFNumberTxt;
        private System.Windows.Forms.Label lblLastNameTxt;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblIDTxt;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblGroupTxt;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblCourseTxt;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblSpecialtyTxt;
        private System.Windows.Forms.Label lblSpecialty;
        private System.Windows.Forms.Label lbDegreeTxt;
        private System.Windows.Forms.Label lblDegree;
        public System.Windows.Forms.Label lblFacNumber;
        private System.Windows.Forms.Label lblDisciplinesTxt;
        private System.Windows.Forms.PictureBox pbStudentSchedule;
    }
}