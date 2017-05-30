using DataAccess.Entity;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UniversitySystem.Forms
{
    public partial class StudentWindow : Form
    {
        public StudentWindow()
        {
            InitializeComponent();
        }
        Student student = new Student();
        List<Discipline> disciplines = new List<Discipline>();
        bool isButonClicked = false;

        // FORM LOAD EVENT.
        private void StudentWindow_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database\UniSystemDatabase.mdf;Integrated Security=True";
            string readQuery = "SELECT * FROM Student";

            ReadData rd = new ReadData();
            rd.ReadTableData(connectionString, readQuery, lblFacNumber.Text, student);

            WriteDataToLabels(student);

            readQuery = "SELECT * FROM Disciplines";
            rd.ReadDisciplines(connectionString, readQuery, lblSpecialty.Text, lblCourse.Text, disciplines);

            WriteDataToListBox(disciplines);
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

        private void OpenWelcomeForm()
        {
            Form welcome = new Welcome();
            welcome.Show();

            Hide();
        }
    }
}
