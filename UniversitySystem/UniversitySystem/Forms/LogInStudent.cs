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
        List<string> StudentFnumbers = new List<string>();
        List<string> StudentIDs = new List<string>();
        public LogInStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LogInStudent_Load(object sender, EventArgs e)
        {
            pbLogInStudent.Image = UniversitySystem.Properties.Resources.Student;
        }

        private void btLogInStudent_Click(object sender, EventArgs e)
        {
            if (tbFNumberStudent.Text != string.Empty && tbIDNumberStudent.Text != string.Empty)
            {

                for (int i = 0; i < StudentFnumbers.Count; i++)
                {
                    if (tbFNumberStudent.Text == StudentFnumbers[i] && tbIDNumberStudent.Text == StudentIDs[i])
                    {
                        StudentWindow sw = new StudentWindow();
                        sw.ShowDialog();
                        this.Close();
                        
                    }
                    else if (i == StudentFnumbers.Count - 1)
                    {
                        MessageBox.Show("Incorrect Username/Password");
                    }
                }

            }
            else
            {
                MessageBox.Show("Please enter a Username/Password!");
            }
        }
    }
}
