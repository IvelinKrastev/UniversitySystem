using DataAccess.Entity;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace UniversitySystem.Forms
{
    public partial class StudentWindow : Form
    {
        public StudentWindow()
        {
            InitializeComponent();
        }
        string path = "Students.txt";

        Student student = new Student();
        //Grades grades = new Grades();
        List<Discipline> disciplines = new List<Discipline>();
        List<Grades> grades = new List<Grades>();

        // FORM LOAD EVENT.
        private void StudentWindow_Load(object sender, EventArgs e)
        {
            ReadData rd = new ReadData();
            rd.ReadTableData(path, lblFacNumber.Text, student);
            WriteDataToLabels(student);

            path = "Disciplines.txt";
            rd.ReadDisciplines(path, lblSpecialty.Text, lblCourse.Text, disciplines);

            path = "Grades.txt";
            rd.ReadGradesForStudent(path, lblFacNumber.Text, grades);


            WriteDataToListBox(disciplines);
            WriteGrades(grades);

            SetSchedules(student);
        }

        // FIRST PICTUREBOX CLICK EVENT.
        private void pbScheduleTrimOne_Click(object sender, EventArgs e)
        {
            ZoomPicture(pbScheduleTrimOne.Image);
        }

        // SECOND PICTUREBOX CLICK EVENT.
        private void pbScheduleTrimTwo_Click(object sender, EventArgs e)
        {
            ZoomPicture(pbScheduleTrimTwo.Image);
        }

        // THIRD PICTUREBOX CLICK EVENT.
        private void pbScheduleTrimThree_Click(object sender, EventArgs e)
        {
            ZoomPicture(pbScheduleTrimThree.Image);
        }

        // LOG OUT BUTTON CLICK EVENT.
        private void btnLogOutStudent_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Log out?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OpenWelcomeForm();
            }
        }

        // FORM CLOSING EVENT.
        private void StudentWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Log out?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OpenWelcomeForm();
            }
            else
                e.Cancel = true;
        }

        // FUNCTION THAT FILLS THE DATA FROM THE STUDENT OBJECT TO THE LABELS.
        private void WriteDataToLabels(Student student)
        {
            lblFirstName.Text = student.FirstName;
            lblSecondName.Text = student.SecondName;
            lblLastName.Text = student.LastName;
            lblId.Text = student.PersonalId;
            lblDegree.Text = student.Degree;
            lblSpecialty.Text = student.Specialty;
            lblCourse.Text = student.Course.ToString();
            lblGroup.Text = student.Group;
        }

        // FUNCTION THAT FILLS THE DATA FROM THE DISCIPLINES LIST TO THE LIST BOX.
        private void WriteDataToListBox(List<Discipline> disciplines)
        {
            int counter = 1;
            foreach (Discipline d in disciplines)
            {
                lbDisciplinesForCourse.Items.Add(counter.ToString() + ". " + d.DisciplineName);
                counter++;
            }
        }

        // FUNCTION WHICH OPENS THE WELCOME FORM AND HIDES THE CURRENT.
        private void OpenWelcomeForm()
        {
            Form welcome = new Welcome();
            welcome.Show();

            Hide();
        }

        // FUNCTION WHICH SETS THE IMAGES FOR SCHEDULE BY COURSE OF STUDENT.
        private void SetSchedules(Student student)
        {
            switch (student.Course)
            {
                case 1:
                    pbScheduleTrimOne.Image = Properties.Resources.ScheduleCourse1Semester1;
                    pbScheduleTrimTwo.Image = Properties.Resources.ScheduleCourse1Semester2;
                    pbScheduleTrimThree.Image = Properties.Resources.ScheduleCourse1Semester3;
                    break;
                case 2:
                    pbScheduleTrimOne.Image = Properties.Resources.ScheduleCourse2Semester1;
                    pbScheduleTrimTwo.Image = Properties.Resources.ScheduleCourse2Semester2;
                    pbScheduleTrimThree.Image = Properties.Resources.ScheduleCourse2Semester3;
                    break;
                case 3:
                    pbScheduleTrimOne.Image = Properties.Resources.ScheduleCourse3Semester1;
                    pbScheduleTrimTwo.Image = Properties.Resources.ScheduleCourse3Semester2;
                    pbScheduleTrimThree.Image = Properties.Resources.ScheduleCourse3Semester3;
                    break;
                case 4:
                    pbScheduleTrimOne.Image = Properties.Resources.ScheduleCourse4Semester1;
                    pbScheduleTrimTwo.Image = Properties.Resources.ScheduleCourse4Semester2;
                    pbScheduleTrimThree.Image = Properties.Resources.ScheduleCourse4Semester3;
                    break;
            }
        }

        // FUNCTION THAT ZOOMS THE PICTURE FROM THE PICTUREBOX IN ANOTHER FORM.
        private void ZoomPicture(Image image)
        {
            SheduleViewer sv = new SheduleViewer();
            sv.pbShedule.Image = image;
            sv.Show();
        }

        // FUNCTION THAT FILLS THE ASSESSMENTS LIST BOX WITH DATA.
        private void WriteGrades(List<Grades> grades)
        {
            int counter = 1;
            foreach (Grades g in grades)
            {
                lbAssessmentsStudent.Items.Add(counter.ToString() + ". Discipline: " + g.DisciplineName + " ----- Grade: " + g.Grade.ToString());
                counter++;
            }
        }
    }
}
