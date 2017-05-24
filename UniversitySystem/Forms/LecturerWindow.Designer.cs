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
            this.tabLecturer = new System.Windows.Forms.TabControl();
            this.tabLecturerHome = new System.Windows.Forms.TabPage();
            this.tabLecturerStudentAssessments = new System.Windows.Forms.TabPage();
            this.btLogOutLecturer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLecturerName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbScientificDegreeLecturer = new System.Windows.Forms.Label();
            this.lbLecturerDisciplines = new System.Windows.Forms.ListBox();
            this.tab = new System.Windows.Forms.TabPage();
            this.tbWorkScheduleLecturer = new System.Windows.Forms.TableLayoutPanel();
            this.tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btAddGradeLecturer = new System.Windows.Forms.Button();
            this.tabLecturer.SuspendLayout();
            this.tabLecturerHome.SuspendLayout();
            this.tabLecturerStudentAssessments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLecturer
            // 
            this.tabLecturer.Controls.Add(this.tabLecturerHome);
            this.tabLecturer.Controls.Add(this.tabLecturerStudentAssessments);
            this.tabLecturer.Controls.Add(this.tab);
            this.tabLecturer.Location = new System.Drawing.Point(0, 0);
            this.tabLecturer.Name = "tabLecturer";
            this.tabLecturer.SelectedIndex = 0;
            this.tabLecturer.Size = new System.Drawing.Size(466, 316);
            this.tabLecturer.TabIndex = 0;
            // 
            // tabLecturerHome
            // 
            this.tabLecturerHome.Controls.Add(this.lbLecturerDisciplines);
            this.tabLecturerHome.Controls.Add(this.lbScientificDegreeLecturer);
            this.tabLecturerHome.Controls.Add(this.label3);
            this.tabLecturerHome.Controls.Add(this.lbLecturerName);
            this.tabLecturerHome.Controls.Add(this.label1);
            this.tabLecturerHome.Controls.Add(this.pictureBox1);
            this.tabLecturerHome.Location = new System.Drawing.Point(4, 22);
            this.tabLecturerHome.Name = "tabLecturerHome";
            this.tabLecturerHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabLecturerHome.Size = new System.Drawing.Size(458, 290);
            this.tabLecturerHome.TabIndex = 0;
            this.tabLecturerHome.Text = "Home";
            this.tabLecturerHome.UseVisualStyleBackColor = true;
            // 
            // tabLecturerStudentAssessments
            // 
            this.tabLecturerStudentAssessments.Controls.Add(this.btAddGradeLecturer);
            this.tabLecturerStudentAssessments.Controls.Add(this.label4);
            this.tabLecturerStudentAssessments.Controls.Add(this.textBox1);
            this.tabLecturerStudentAssessments.Controls.Add(this.listBox1);
            this.tabLecturerStudentAssessments.Controls.Add(this.label2);
            this.tabLecturerStudentAssessments.Controls.Add(this.tb);
            this.tabLecturerStudentAssessments.Location = new System.Drawing.Point(4, 22);
            this.tabLecturerStudentAssessments.Name = "tabLecturerStudentAssessments";
            this.tabLecturerStudentAssessments.Padding = new System.Windows.Forms.Padding(3);
            this.tabLecturerStudentAssessments.Size = new System.Drawing.Size(458, 290);
            this.tabLecturerStudentAssessments.TabIndex = 1;
            this.tabLecturerStudentAssessments.Text = "Student Assessments";
            this.tabLecturerStudentAssessments.UseVisualStyleBackColor = true;
            // 
            // btLogOutLecturer
            // 
            this.btLogOutLecturer.Location = new System.Drawing.Point(387, 322);
            this.btLogOutLecturer.Name = "btLogOutLecturer";
            this.btLogOutLecturer.Size = new System.Drawing.Size(75, 23);
            this.btLogOutLecturer.TabIndex = 2;
            this.btLogOutLecturer.Text = "Log out";
            this.btLogOutLecturer.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(8, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 114);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // lbLecturerName
            // 
            this.lbLecturerName.AutoSize = true;
            this.lbLecturerName.Location = new System.Drawing.Point(119, 137);
            this.lbLecturerName.Name = "lbLecturerName";
            this.lbLecturerName.Size = new System.Drawing.Size(35, 13);
            this.lbLecturerName.TabIndex = 5;
            this.lbLecturerName.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Scientific Degree:";
            // 
            // lbScientificDegreeLecturer
            // 
            this.lbScientificDegreeLecturer.AutoSize = true;
            this.lbScientificDegreeLecturer.Location = new System.Drawing.Point(119, 161);
            this.lbScientificDegreeLecturer.Name = "lbScientificDegreeLecturer";
            this.lbScientificDegreeLecturer.Size = new System.Drawing.Size(35, 13);
            this.lbScientificDegreeLecturer.TabIndex = 7;
            this.lbScientificDegreeLecturer.Text = "label4";
            // 
            // lbLecturerDisciplines
            // 
            this.lbLecturerDisciplines.FormattingEnabled = true;
            this.lbLecturerDisciplines.Location = new System.Drawing.Point(227, 6);
            this.lbLecturerDisciplines.Name = "lbLecturerDisciplines";
            this.lbLecturerDisciplines.Size = new System.Drawing.Size(225, 277);
            this.lbLecturerDisciplines.TabIndex = 8;
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tbWorkScheduleLecturer);
            this.tab.Location = new System.Drawing.Point(4, 22);
            this.tab.Name = "tab";
            this.tab.Padding = new System.Windows.Forms.Padding(3);
            this.tab.Size = new System.Drawing.Size(458, 290);
            this.tab.TabIndex = 2;
            this.tab.Text = "Work schedule";
            this.tab.UseVisualStyleBackColor = true;
            this.tab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tbWorkScheduleLecturer
            // 
            this.tbWorkScheduleLecturer.ColumnCount = 2;
            this.tbWorkScheduleLecturer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbWorkScheduleLecturer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbWorkScheduleLecturer.Location = new System.Drawing.Point(6, 6);
            this.tbWorkScheduleLecturer.Name = "tbWorkScheduleLecturer";
            this.tbWorkScheduleLecturer.RowCount = 2;
            this.tbWorkScheduleLecturer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbWorkScheduleLecturer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbWorkScheduleLecturer.Size = new System.Drawing.Size(449, 281);
            this.tbWorkScheduleLecturer.TabIndex = 3;
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(98, 6);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(100, 20);
            this.tb.TabIndex = 0;
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(449, 212);
            this.listBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(349, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
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
            // btAddGradeLecturer
            // 
            this.btAddGradeLecturer.Location = new System.Drawing.Point(188, 250);
            this.btAddGradeLecturer.Name = "btAddGradeLecturer";
            this.btAddGradeLecturer.Size = new System.Drawing.Size(75, 23);
            this.btAddGradeLecturer.TabIndex = 3;
            this.btAddGradeLecturer.Text = "Add Grade";
            this.btAddGradeLecturer.UseVisualStyleBackColor = true;
            // 
            // LecturerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 355);
            this.Controls.Add(this.btLogOutLecturer);
            this.Controls.Add(this.tabLecturer);
            this.Name = "LecturerWindow";
            this.Text = "LecturerWindow";
            this.Load += new System.EventHandler(this.LecturerWindow_Load);
            this.tabLecturer.ResumeLayout(false);
            this.tabLecturerHome.ResumeLayout(false);
            this.tabLecturerHome.PerformLayout();
            this.tabLecturerStudentAssessments.ResumeLayout(false);
            this.tabLecturerStudentAssessments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabLecturer;
        private System.Windows.Forms.TabPage tabLecturerHome;
        private System.Windows.Forms.TabPage tabLecturerStudentAssessments;
        private System.Windows.Forms.ListBox lbLecturerDisciplines;
        private System.Windows.Forms.Label lbScientificDegreeLecturer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbLecturerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tab;
        private System.Windows.Forms.Button btLogOutLecturer;
        private System.Windows.Forms.TableLayoutPanel tbWorkScheduleLecturer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Button btAddGradeLecturer;
    }
}