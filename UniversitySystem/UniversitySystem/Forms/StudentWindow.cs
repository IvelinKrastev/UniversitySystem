using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversitySystem.Classes;

namespace UniversitySystem.Forms
{
    public partial class StudentWindow : Form
    {
        public StudentWindow()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabStudentHome_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOutStudent_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void StudentWindow_Load(object sender, EventArgs e)
        {


            Student student1 = new Student();
            //student1.FirstName = "Name";
           // student1.SecondName = "Middle Name";
           // student1.ThirdName = "Last Name";

            lbStudentName.Text = student1.ShowName();
            lbBirthDate.Text = student1.ShowBirthDay();
            lbCourseAndGroup.Text = student1.Course + "/" + student1.Group;
            lbFNumberStudent.Text = student1.FacultyNumber;
            lbNationality.Text = student1.Nationality;
            lbSpecialityStudent.Text = student1.Specialty;

        }
    }
}
