using DataAccess.Entity;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using UniversitySystem.Forms;

namespace UniversitySystem
{
    public partial class LogInStudent : Form
    {
        public LogInStudent()
        {
            InitializeComponent();
        }
        string path = "Students.txt";
        List<Student> students = new List<Student>();

        Form welcome = new Welcome();

        // FORM LOAD EVENT.
        private void LogInStudent_Load(object sender, EventArgs e)
        {
            ReadData rd = new ReadData();
            rd.ReadForLogin(path, students);
        }

        // LOGIN BUTTON CLICK EVENT.
        private void btnLogInStudent_Click(object sender, EventArgs e)
        {
            CheckInputData(students);
        }

        // BACK BUTTON CLICK EVENT.
        private void btnBackStudent_Click(object sender, EventArgs e)
        {
            welcome.Show();
            Hide();
        }

        // FORM CLOSING EVENT.
        private void LogInStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            welcome.Show();
            Hide();
        }

        // TEXTBOX KEY DOWN EVENT.
        private void inputField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogInStudent_Click(sender, e);
        }

        // FUNCTION WHICH CHECKS IF THE INPUT DATA FOR THE STUDENT IS VALID AND EXISTS IN THE DATABASE.
        private void CheckInputData(List<Student> students)
        {
            // CHECK IF THE FIELDS ARE IN A CORRECT FORMAT.
            if (tbFNumberStudent.Text.Trim().Length == 10 && isDigits(tbFNumberStudent) &&
                tbIDNumberStudent.Text.Trim().Length == 10 && isDigits(tbIDNumberStudent))
            {
                for (int i = 0; i < students.Count; i++)
                {
                    // CHECK IF SUCH STUDENT EXISTS IN THE DATABASE.
                    if (tbFNumberStudent.Text.Trim() == students[i].FacultyNumber &&
                        tbIDNumberStudent.Text.Trim() == students[i].PersonalId)
                    {
                        StudentWindow sw = new StudentWindow();
                        sw.lblFacNumber.Text = tbFNumberStudent.Text;
                        sw.Show();

                        Hide();
                        break;
                    }
                    else if (i == students.Count - 1)
                    {
                        MessageBox.Show("No such student exists!", "No such student!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("Please enter a correct Faculty Number and/or ID Number!", "Incorrect Faculty Number/ID!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // FUNCTION WHICH CHECKS IF A FIELD CONTAINS ONLY DIGITS.
        public bool isDigits(TextBox field)
        {
            Regex onlyDigits = new Regex("^[0-9]+$");

            if (onlyDigits.IsMatch(field.Text))
                return true;
            else
                return false;
        }
    }
}
