using DataAccess.Entity;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace UniversitySystem.Forms
{
    public partial class LogInLecturer : Form
    {
        public LogInLecturer()
        {
            InitializeComponent();
        }
        List<Lecturer> lecturers = new List<Lecturer>();

        Form welcome = new Welcome();

        // LOGIN LECTURER FORM LOAD EVENT.
        private void LogInLecturer_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=localhost; Database=UniversitySystem; Integrated Security=True;";
            string readQuery = "SELECT * FROM Lecturer";

            ReadData rd = new ReadData();
            rd.ReadForLogin(connectionString, readQuery, lecturers);
        }
        
        // BUTTON LOGIN CLICK EVENT.
        private void btnLogInLecturer_Click(object sender, EventArgs e)
        {
            CheckInputData(lecturers);
        }

        // BUTTON BACK CLICK EVENT.
        private void btnBackLecturer_Click(object sender, EventArgs e)
        {
            welcome.Show();
            Hide();
        }

        // FORM CLOSING EVENT.
        private void LogInLecturer_FormClosing(object sender, FormClosingEventArgs e)
        {
            welcome.Show();
            Hide();
        }

        // TEXTBOX KEY DOWN EVENT.
        private void inputField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogInLecturer_Click(sender, e);
        }

        // FUNCTION WHICH CHECKS IF THE INPUT DATA FOR THE LECTURER IS VALID AND EXISTS IN THE DATABASE.
        private void CheckInputData(List<Lecturer> lecturers)
        {
            // CHECK IF THE FIELDS ARE IN A CORRECT FORMAT.
            if (tbIDLecturer.Text.Trim().Length == 10 && isDigits(tbIDLecturer) &&
                tbWorkNumberLecturer.Text.Trim().Length == 3 && isDigits(tbWorkNumberLecturer))
            {
                for (int i = 0; i < lecturers.Count; i++)
                {
                    // CHECK IF SUCH STUDENT EXISTS IN THE DATABASE.
                    if (tbIDLecturer.Text == lecturers[i].PersonalId &&
                        tbWorkNumberLecturer.Text == lecturers[i].WorkNumber)
                    {
                        Form lw = new LecturerWindow();
                        lw.Show();

                        Hide();
                        break;
                    }
                    else if (i == lecturers.Count - 1)
                    {
                        MessageBox.Show("No such lecturer exists!", "No such lecturer!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("Please enter a correct ID Number and/or Work Number!", "Incorrect ID/Work Number!",
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
