using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversitySystem.Forms
{
    public partial class LogInLecturer : Form
    {
        List<string> lecturerIDs = new List<string>();
        List<string> lecturerPasswords = new List<string>();

        public LogInLecturer()
        {
            InitializeComponent();
        }

        private void LogInLecturer_Load(object sender, EventArgs e)
        {
            //upon form load the lecturerIDs and lecturerPasswords lists are going to be populated by the database
            //Database code.....
            //if the database returns a collection of elements we only need to use it, instead of lecturerIDs and lecturerPasswords

        }

        private void tbIDLecturer_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPasswordLecturer_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogInLecturer_Click(object sender, EventArgs e)
        {

            if (tbIDLecturer.Text != string.Empty && tbPasswordLecturer.Text != string.Empty)
            {

                for (int i = 0; i < lecturerIDs.Count; i++)
                {
                    if (tbIDLecturer.Text == lecturerIDs[i] && tbPasswordLecturer.Text == lecturerPasswords[i])
                    {
                        LecturerWindow lw = new LecturerWindow();
                        lw.ShowDialog();
                        this.Close();
                    }
                    else if (i == lecturerIDs.Count - 1)
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

        private void btnBackLecturer_Click(object sender, EventArgs e)
        {
            Form f = new Welcome();
            f.Show();

            Hide();
        }
        
    }
}
