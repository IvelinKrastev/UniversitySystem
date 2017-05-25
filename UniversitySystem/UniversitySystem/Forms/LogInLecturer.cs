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
        public LogInLecturer()
        {
            InitializeComponent();
        }

        private void LogInLecturer_Load(object sender, EventArgs e)
        {

        }

        private void tbIDLecturer_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPasswordLecturer_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogInLecturer_Click(object sender, EventArgs e)
        {

        }

        private void btnBackLecturer_Click(object sender, EventArgs e)
        {
            Form f = new Welcome();
            f.Show();

            Hide();
        }
    }
}
