using DataAccess.Entity;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;

namespace DataAccess.Repository
{
    public class ReadData
    {
        // FUNCTION WHICH RETRIEVES THE NEEDED DATA FOR LOGIN FROM THE [STUDENT] TABLE.
        public void ReadForLogin(string connectionString, string readQuery, List<Student> students)
        {
            using (SqlConnection DBConnect = new SqlConnection(connectionString))
            {
                try
                {
                    // OPENING THE CONNECTION.
                    DBConnect.Open();
                    SqlCommand cmd = new SqlCommand(readQuery, DBConnect);

                    SqlDataReader reader = cmd.ExecuteReader();

                    // READING FROM THE TABLE [STUDENTS].
                    while (reader.Read())
                    {
                        Student s = new Student();
                        s.FacultyNumber = reader["Faculty_Number"].ToString();
                        s.PersonalId = reader["Personal_ID"].ToString();

                        students.Add(s);
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("An unexpected error has occured with the database. Please try again later.", "Unexpected error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void ReadForLogin(string connectionString, string readQuery, List<Lecturer> lecturers)
        {
            using (SqlConnection DBConnect = new SqlConnection(connectionString))
            {
                try
                {
                    // OPENING THE CONNECTION.
                    DBConnect.Open();
                    SqlCommand cmd = new SqlCommand(readQuery, DBConnect);

                    SqlDataReader reader = cmd.ExecuteReader();

                    // READING FROM THE TABLE [STUDENTS].
                    while (reader.Read())
                    {
                        Lecturer l = new Lecturer();
                        l.PersonalId = reader["Personal_ID"].ToString();
                        l.WorkNumber = reader["Work_Number"].ToString();

                        lecturers.Add(l);
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("An unexpected error has occured with the database. Please try again later.", "Unexpected error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
