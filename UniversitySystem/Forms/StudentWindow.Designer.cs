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
            this.tabStudent = new System.Windows.Forms.TabControl();
            this.tabStudentHome = new System.Windows.Forms.TabPage();
            this.tabStudentAssessments = new System.Windows.Forms.TabPage();
            this.tabStudentSchedule = new System.Windows.Forms.TabPage();
            this.lbStudentName = new System.Windows.Forms.Label();
            this.lbFNumberStudent = new System.Windows.Forms.Label();
            this.lbSpecialityStudent = new System.Windows.Forms.Label();
            this.lbCourseAndGroup = new System.Windows.Forms.Label();
            this.lbBirthDate = new System.Windows.Forms.Label();
            this.lbNationality = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbAssessmentsStudent = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btLogOutStudent = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btDegreeStudent = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabStudent.SuspendLayout();
            this.tabStudentHome.SuspendLayout();
            this.tabStudentAssessments.SuspendLayout();
            this.tabStudentSchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabStudent
            // 
            this.tabStudent.Controls.Add(this.tabStudentHome);
            this.tabStudent.Controls.Add(this.tabStudentAssessments);
            this.tabStudent.Controls.Add(this.tabStudentSchedule);
            this.tabStudent.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabStudent.Location = new System.Drawing.Point(0, 0);
            this.tabStudent.Name = "tabStudent";
            this.tabStudent.SelectedIndex = 0;
            this.tabStudent.Size = new System.Drawing.Size(466, 316);
            this.tabStudent.TabIndex = 0;
            // 
            // tabStudentHome
            // 
            this.tabStudentHome.Controls.Add(this.btDegreeStudent);
            this.tabStudentHome.Controls.Add(this.label4);
            this.tabStudentHome.Controls.Add(this.listBox1);
            this.tabStudentHome.Controls.Add(this.label1);
            this.tabStudentHome.Controls.Add(this.label2);
            this.tabStudentHome.Controls.Add(this.label3);
            this.tabStudentHome.Controls.Add(this.label7);
            this.tabStudentHome.Controls.Add(this.label8);
            this.tabStudentHome.Controls.Add(this.label9);
            this.tabStudentHome.Controls.Add(this.lbNationality);
            this.tabStudentHome.Controls.Add(this.lbBirthDate);
            this.tabStudentHome.Controls.Add(this.lbCourseAndGroup);
            this.tabStudentHome.Controls.Add(this.lbSpecialityStudent);
            this.tabStudentHome.Controls.Add(this.lbFNumberStudent);
            this.tabStudentHome.Controls.Add(this.lbStudentName);
            this.tabStudentHome.Location = new System.Drawing.Point(4, 22);
            this.tabStudentHome.Name = "tabStudentHome";
            this.tabStudentHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudentHome.Size = new System.Drawing.Size(458, 290);
            this.tabStudentHome.TabIndex = 0;
            this.tabStudentHome.Text = "Home";
            this.tabStudentHome.UseVisualStyleBackColor = true;
            this.tabStudentHome.Click += new System.EventHandler(this.tabStudentHome_Click);
            // 
            // tabStudentAssessments
            // 
            this.tabStudentAssessments.Controls.Add(this.lbAssessmentsStudent);
            this.tabStudentAssessments.Location = new System.Drawing.Point(4, 22);
            this.tabStudentAssessments.Name = "tabStudentAssessments";
            this.tabStudentAssessments.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudentAssessments.Size = new System.Drawing.Size(458, 290);
            this.tabStudentAssessments.TabIndex = 1;
            this.tabStudentAssessments.Text = "Assessments";
            this.tabStudentAssessments.UseVisualStyleBackColor = true;
            // 
            // tabStudentSchedule
            // 
            this.tabStudentSchedule.Controls.Add(this.tableLayoutPanel1);
            this.tabStudentSchedule.Location = new System.Drawing.Point(4, 22);
            this.tabStudentSchedule.Name = "tabStudentSchedule";
            this.tabStudentSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudentSchedule.Size = new System.Drawing.Size(458, 290);
            this.tabStudentSchedule.TabIndex = 2;
            this.tabStudentSchedule.Text = "Schedule";
            this.tabStudentSchedule.UseVisualStyleBackColor = true;
            // 
            // lbStudentName
            // 
            this.lbStudentName.AutoSize = true;
            this.lbStudentName.Location = new System.Drawing.Point(111, 18);
            this.lbStudentName.Name = "lbStudentName";
            this.lbStudentName.Size = new System.Drawing.Size(35, 13);
            this.lbStudentName.TabIndex = 0;
            this.lbStudentName.Text = "label1";
            // 
            // lbFNumberStudent
            // 
            this.lbFNumberStudent.AutoSize = true;
            this.lbFNumberStudent.Location = new System.Drawing.Point(111, 41);
            this.lbFNumberStudent.Name = "lbFNumberStudent";
            this.lbFNumberStudent.Size = new System.Drawing.Size(35, 13);
            this.lbFNumberStudent.TabIndex = 1;
            this.lbFNumberStudent.Text = "label2";
            // 
            // lbSpecialityStudent
            // 
            this.lbSpecialityStudent.AutoSize = true;
            this.lbSpecialityStudent.Location = new System.Drawing.Point(111, 64);
            this.lbSpecialityStudent.Name = "lbSpecialityStudent";
            this.lbSpecialityStudent.Size = new System.Drawing.Size(35, 13);
            this.lbSpecialityStudent.TabIndex = 2;
            this.lbSpecialityStudent.Text = "label3";
            // 
            // lbCourseAndGroup
            // 
            this.lbCourseAndGroup.AutoSize = true;
            this.lbCourseAndGroup.Location = new System.Drawing.Point(111, 86);
            this.lbCourseAndGroup.Name = "lbCourseAndGroup";
            this.lbCourseAndGroup.Size = new System.Drawing.Size(35, 13);
            this.lbCourseAndGroup.TabIndex = 3;
            this.lbCourseAndGroup.Text = "label4";
            this.lbCourseAndGroup.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbBirthDate
            // 
            this.lbBirthDate.AutoSize = true;
            this.lbBirthDate.Location = new System.Drawing.Point(111, 108);
            this.lbBirthDate.Name = "lbBirthDate";
            this.lbBirthDate.Size = new System.Drawing.Size(35, 13);
            this.lbBirthDate.TabIndex = 4;
            this.lbBirthDate.Text = "label5";
            // 
            // lbNationality
            // 
            this.lbNationality.AutoSize = true;
            this.lbNationality.Location = new System.Drawing.Point(111, 130);
            this.lbNationality.Name = "lbNationality";
            this.lbNationality.Size = new System.Drawing.Size(35, 13);
            this.lbNationality.TabIndex = 5;
            this.lbNationality.Text = "label6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nationality:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Birth Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Course/Group:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Speciality:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Faculty Number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Name:";
            // 
            // lbAssessmentsStudent
            // 
            this.lbAssessmentsStudent.FormattingEnabled = true;
            this.lbAssessmentsStudent.Location = new System.Drawing.Point(3, 3);
            this.lbAssessmentsStudent.Name = "lbAssessmentsStudent";
            this.lbAssessmentsStudent.Size = new System.Drawing.Size(452, 277);
            this.lbAssessmentsStudent.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(210, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(223, 160);
            this.listBox1.TabIndex = 12;
            // 
            // btLogOutStudent
            // 
            this.btLogOutStudent.Location = new System.Drawing.Point(387, 322);
            this.btLogOutStudent.Name = "btLogOutStudent";
            this.btLogOutStudent.Size = new System.Drawing.Size(75, 23);
            this.btLogOutStudent.TabIndex = 1;
            this.btLogOutStudent.Text = "Log out";
            this.btLogOutStudent.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Enrolled as:";
            // 
            // btDegreeStudent
            // 
            this.btDegreeStudent.AutoSize = true;
            this.btDegreeStudent.Location = new System.Drawing.Point(111, 156);
            this.btDegreeStudent.Name = "btDegreeStudent";
            this.btDegreeStudent.Size = new System.Drawing.Size(35, 13);
            this.btDegreeStudent.TabIndex = 14;
            this.btDegreeStudent.Text = "label6";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(441, 268);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // StudentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 355);
            this.Controls.Add(this.btLogOutStudent);
            this.Controls.Add(this.tabStudent);
            this.Name = "StudentWindow";
            this.Text = "StudentWindow";
            this.tabStudent.ResumeLayout(false);
            this.tabStudentHome.ResumeLayout(false);
            this.tabStudentHome.PerformLayout();
            this.tabStudentAssessments.ResumeLayout(false);
            this.tabStudentSchedule.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabStudent;
        private System.Windows.Forms.TabPage tabStudentHome;
        private System.Windows.Forms.Label lbNationality;
        private System.Windows.Forms.Label lbBirthDate;
        private System.Windows.Forms.Label lbCourseAndGroup;
        private System.Windows.Forms.Label lbSpecialityStudent;
        private System.Windows.Forms.Label lbFNumberStudent;
        private System.Windows.Forms.Label lbStudentName;
        private System.Windows.Forms.TabPage tabStudentAssessments;
        private System.Windows.Forms.TabPage tabStudentSchedule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label btDegreeStudent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox lbAssessmentsStudent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btLogOutStudent;
    }
}