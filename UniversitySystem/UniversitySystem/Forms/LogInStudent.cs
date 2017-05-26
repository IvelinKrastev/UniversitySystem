using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        List<string> StudentFacNumbers = new List<string>();
        List<string> StudentIDs = new List<string>();

        Form welcome = new Welcome();

        private void LogInStudent_Load(object sender, EventArgs e)
        {
        }


        private void btLogInStudent_Click(object sender, EventArgs e)
        {
            if (tbFNumberStudent.Text != string.Empty && tbFNumberStudent.Text.Length != 10 && 
                tbIDNumberStudent.Text != string.Empty)
            {
                for (int i = 0; i < StudentFacNumbers.Count; i++)
                {
                    if (tbFNumberStudent.Text == StudentFacNumbers[i] && tbIDNumberStudent.Text == StudentIDs[i])
                    {
                        StudentWindow sw = new StudentWindow();
                        sw.Show();

                        Hide();
                    }
                    else if (i == StudentFacNumbers.Count - 1)
                    {
                        MessageBox.Show("Incorrect Username/Password");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a correct Username/Password!");
            }
        }

        // BACK BUTTON CLICK EVENT.
        private void btBackStudent_Click(object sender, EventArgs e)
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
    }
}
