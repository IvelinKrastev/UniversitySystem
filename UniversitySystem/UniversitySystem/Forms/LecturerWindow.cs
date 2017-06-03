using DataAccess.Entity;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UniversitySystem.Forms
{
    public partial class LecturerWindow : Form
    {
        public LecturerWindow()
        {
            InitializeComponent();
        }
        string path = "Lecturers.txt";
        public string workNumber;

        Lecturer lecturer = new Lecturer();
        List<Discipline> disciplines = new List<Discipline>();
        List<Grades> grades = new List<Grades>();

        // FORM LOAD EVENT.
        private void LecturerWindow_Load(object sender, EventArgs e)
        {
            ReadData rd = new ReadData();
            rd.ReadTableData(path, workNumber, lecturer);

            WriteDataToLabels(lecturer);
            SetImage(lecturer);

            path = "Disciplines.txt";
            rd.ReadDisciplines(path, workNumber, disciplines);
            WriteDataToListBox(disciplines);

            path = "Grades.txt";
            rd.ReadGradesForLecturer(path, lecturer.WorkNumber, grades);

            for (int i = 0; i < grades.Count; i++)
            {
                int counter = i + 1;

                lbGrades.Items.Add(counter + ". Fac. Number: " + grades[i].FacultyNumberOfStudent + " ----- Discipline: " + 
                    grades[i].DisciplineName + " ----- Grade: " + grades[i].Grade);
            }

            SetSchedules(lecturer);
        }

        // LOGOUT BUTTON CLICK EVENT.
        private void btnLogOutStudent_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Log out?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OpenWelcomeForm();
            }
        }

        // FORM CLOSING EVENT.
        private void LecturerWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Log out?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OpenWelcomeForm();
            }
            else
                e.Cancel = true;
        }

        // FUNCTION THAT FILLS THE DATA FROM THE LECTURER OBJECT TO THE LABELS.
        private void WriteDataToLabels(Lecturer lecturer)
        {
            lblDegree.Text = lecturer.Degree;
            lblFirstName.Text = lecturer.FirstName;
            lblSecondName.Text = lecturer.SecondName;
            lblLastName.Text = lecturer.LastName;
            lblId.Text = lecturer.PersonalId;
        }

        // FUNCTION THAT FILLS THE DATA FROM THE DISCIPLINES LIST TO THE LIST BOX.
        private void WriteDataToListBox(List<Discipline> disciplines)
        {
            int counter = 1;
            foreach (Discipline d in disciplines)
            {
                lbDisciplinesTaught.Items.Add(counter.ToString() + ". " + d.DisciplineName);
                counter++;
            }
        }

        // FUNCTION WHICH SETS THE CORRECT IMAGE TO THE PICTUREBOX.
        private void SetImage(Lecturer lecturer)
        {
            switch (lecturer.Image)
            {
                case "Valkov.jpg":
                    pbLecturerPic.Image = Properties.Resources.Valkov;
                    break;
                case "Baikalov.jpg":
                    pbLecturerPic.Image = Properties.Resources.Baikalov;
                    break;
                case "Angelov.jpg":
                    pbLecturerPic.Image = Properties.Resources.Angelov;
                    break;
                case "Tyankova.jpg":
                    pbLecturerPic.Image = Properties.Resources.Tyankova;
                    break;
                case "Ivailov.jpg":
                    pbLecturerPic.Image = Properties.Resources.Ivailov;
                    break;
                case "Anastasov.jpg":
                    pbLecturerPic.Image = Properties.Resources.Anastasov;
                    break;
                case "Terzieva.jpg":
                    pbLecturerPic.Image = Properties.Resources.Terzieva;
                    break;
            }
        }

        // FUNCTION WHICH SETS THE IMAGE FOR SCHEDULE BY WORK NUMBER OF LECTURER.
        private void SetSchedules(Lecturer lecturer)
        {
            switch (lecturer.WorkNumber)
            {
                case "123":
                    pbLecturerWorkSchedule.Image = Properties.Resources.WorkSchedule_123;
                    break;
                case "124":
                    pbLecturerWorkSchedule.Image = Properties.Resources.WorkSchedule_124; break;
                case "125":
                    pbLecturerWorkSchedule.Image = Properties.Resources.WorkSchedule_125;
                    break;
                case "126":
                    pbLecturerWorkSchedule.Image = Properties.Resources.WorkSchedule_126;
                    break;
                case "129":
                    pbLecturerWorkSchedule.Image = Properties.Resources.WorkSchedule_129;
                    break;
                case "134":
                    pbLecturerWorkSchedule.Image = Properties.Resources.WorkSchedule_134;
                    break;
                case "200":
                    pbLecturerWorkSchedule.Image = Properties.Resources.WorkSchedule_200;
                    break;
            }
        }

        // FUNCTION WHICH OPENS THE WELCOME FORM AND HIDES THE CURRENT.
        private void OpenWelcomeForm()
        {
            Form welcome = new Welcome();
            welcome.Show();

            Hide();
        }
    }
}
