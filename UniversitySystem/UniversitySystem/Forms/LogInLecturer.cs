using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        Form welcome = new Welcome();

        // LOGIN LECTURER FORM LOAD EVENT.
        private void LogInLecturer_Load(object sender, EventArgs e)
        {

        }

        // TEXT BOX ID TEXT CHANGED EVENT.
        private void tbIDLecturer_TextChanged(object sender, EventArgs e)
        {

        }

        // TEXT BOX PASSWORD TEXT CHANGED EVENT.
        private void tbPasswordLecturer_TextChanged(object sender, EventArgs e)
        {

        }

        // BUTTON LOGIN CLICK EVENT.
        private void btnLogInLecturer_Click(object sender, EventArgs e)
        {
            string connectionString = (@"Data Source=(localdb)\mssqllocaldb; Integrated Security = True;");
            SqlConnection DBConnect = new SqlConnection(connectionString);

            try
            {
                DBConnect.Open();
                MessageBox.Show("Account Created");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // BTN BACK CLICK EVENT.
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
    }
}
