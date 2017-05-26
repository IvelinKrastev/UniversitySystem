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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LecturerWindow));
            this.tabLecturer = new System.Windows.Forms.TabControl();
            this.tabLecturerHome = new System.Windows.Forms.TabPage();
            this.lbLecturerDisciplines = new System.Windows.Forms.ListBox();
            this.lbScientificDegreeLecturer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbLecturerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabLecturerStudentAssessments = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.TextBox();
            this.tab = new System.Windows.Forms.TabPage();
            this.tbWorkScheduleLecturer = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogOutLecturer = new System.Windows.Forms.Button();
            this.btnAddGradeLecturer = new System.Windows.Forms.Button();
            this.tabLecturer.SuspendLayout();
            this.tabLecturerHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabLecturerStudentAssessments.SuspendLayout();
            this.tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLecturer
            // 
            this.tabLecturer.Controls.Add(this.tabLecturerHome);
            this.tabLecturer.Controls.Add(this.tabLecturerStudentAssessments);
            this.tabLecturer.Controls.Add(this.tab);
            this.tabLecturer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLecturer.Location = new System.Drawing.Point(0, 0);
            this.tabLecturer.Name = "tabLecturer";
            this.tabLecturer.SelectedIndex = 0;
            this.tabLecturer.Size = new System.Drawing.Size(521, 353);
            this.tabLecturer.TabIndex = 0;
            // 
            // tabLecturerHome
            // 
            this.tabLecturerHome.BackColor = System.Drawing.Color.Gainsboro;
            this.tabLecturerHome.Controls.Add(this.btnAddGradeLecturer);
            this.tabLecturerHome.Controls.Add(this.lbLecturerDisciplines);
            this.tabLecturerHome.Controls.Add(this.btnLogOutLecturer);
            this.tabLecturerHome.Controls.Add(this.lbScientificDegreeLecturer);
            this.tabLecturerHome.Controls.Add(this.label3);
            this.tabLecturerHome.Controls.Add(this.lbLecturerName);
            this.tabLecturerHome.Controls.Add(this.label1);
            this.tabLecturerHome.Controls.Add(this.pictureBox1);
            this.tabLecturerHome.Location = new System.Drawing.Point(4, 22);
            this.tabLecturerHome.Name = "tabLecturerHome";
            this.tabLecturerHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabLecturerHome.Size = new System.Drawing.Size(513, 327);
            this.tabLecturerHome.TabIndex = 0;
            this.tabLecturerHome.Text = "Home";
            // 
            // lbLecturerDisciplines
            // 
            this.lbLecturerDisciplines.FormattingEnabled = true;
            this.lbLecturerDisciplines.Location = new System.Drawing.Point(227, 6);
            this.lbLecturerDisciplines.Name = "lbLecturerDisciplines";
            this.lbLecturerDisciplines.Size = new System.Drawing.Size(225, 186);
            this.lbLecturerDisciplines.TabIndex = 8;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Scientific Degree:";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(8, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 114);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
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
            this.tabLecturerStudentAssessments.Size = new System.Drawing.Size(458, 290);
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
            this.listBox1.Size = new System.Drawing.Size(449, 212);
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
            this.tab.Controls.Add(this.tbWorkScheduleLecturer);
            this.tab.Location = new System.Drawing.Point(4, 22);
            this.tab.Name = "tab";
            this.tab.Padding = new System.Windows.Forms.Padding(3);
            this.tab.Size = new System.Drawing.Size(458, 290);
            this.tab.TabIndex = 2;
            this.tab.Text = "Work schedule";
            this.tab.UseVisualStyleBackColor = true;
            // 
            // tbWorkScheduleLecturer
            // 
            this.tbWorkScheduleLecturer.ColumnCount = 2;
            this.tbWorkScheduleLecturer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbWorkScheduleLecturer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbWorkScheduleLecturer.Location = new System.Drawing.Point(6, 35);
            this.tbWorkScheduleLecturer.Name = "tbWorkScheduleLecturer";
            this.tbWorkScheduleLecturer.RowCount = 2;
            this.tbWorkScheduleLecturer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbWorkScheduleLecturer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbWorkScheduleLecturer.Size = new System.Drawing.Size(384, 252);
            this.tbWorkScheduleLecturer.TabIndex = 3;
            // 
            // btnLogOutLecturer
            // 
            this.btnLogOutLecturer.BackColor = System.Drawing.Color.LightGray;
            this.btnLogOutLecturer.Location = new System.Drawing.Point(357, 248);
            this.btnLogOutLecturer.Name = "btnLogOutLecturer";
            this.btnLogOutLecturer.Size = new System.Drawing.Size(75, 23);
            this.btnLogOutLecturer.TabIndex = 2;
            this.btnLogOutLecturer.Text = "Log out";
            this.btnLogOutLecturer.UseVisualStyleBackColor = false;
            // 
            // btnAddGradeLecturer
            // 
            this.btnAddGradeLecturer.BackColor = System.Drawing.Color.LightGray;
            this.btnAddGradeLecturer.Location = new System.Drawing.Point(12, 261);
            this.btnAddGradeLecturer.Name = "btnAddGradeLecturer";
            this.btnAddGradeLecturer.Size = new System.Drawing.Size(75, 23);
            this.btnAddGradeLecturer.TabIndex = 3;
            this.btnAddGradeLecturer.Text = "Add Grade";
            this.btnAddGradeLecturer.UseVisualStyleBackColor = false;
            // 
            // LecturerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(521, 353);
            this.Controls.Add(this.tabLecturer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LecturerWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LecturerWindow";
            this.Load += new System.EventHandler(this.LecturerWindow_Load);
            this.tabLecturer.ResumeLayout(false);
            this.tabLecturerHome.ResumeLayout(false);
            this.tabLecturerHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabLecturerStudentAssessments.ResumeLayout(false);
            this.tabLecturerStudentAssessments.PerformLayout();
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
        private System.Windows.Forms.Button btnLogOutLecturer;
        private System.Windows.Forms.TableLayoutPanel tbWorkScheduleLecturer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Button btnAddGradeLecturer;
    }
}