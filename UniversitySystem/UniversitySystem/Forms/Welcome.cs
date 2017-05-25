using System;
using System.Windows.Forms;
using UniversitySystem.Forms;

namespace UniversitySystem
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
        Form openForm;

        // PICTURE BOX LECTURER CLICK EVENT.
        private void pbLecturer_Click(object sender, EventArgs e)
        {
            openForm = new LogInLecturer();
            openForm.Show();

            Hide();
        }

        // PICTURE BOX STUDENT CLICK EVENT.
        private void pbStudent_Click(object sender, EventArgs e)
        {
            openForm = new LogInStudent();
            openForm.Show();

            Hide();
        }
    }
}
