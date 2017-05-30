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

        // FUNCTION WHICH RETRIEVES THE NEEDED DATA FOR LOGIN FROM THE [LECTURER] TABLE.
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

                    // READING FROM THE TABLE [LECTURER].
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

        // FUNCTION WHICH RETRIEVES THE NEEDED DATA FOR THE STUDENT WINDOW.
        public void ReadTableData(string connectionString, string readQuery, string facNumber, Student student)
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
                        if (reader["Faculty_Number"].ToString().Equals(facNumber))
                        {
                            student.FacultyNumber = reader["Faculty_Number"].ToString();
                            student.FirstName = reader["First_Name"].ToString();
                            student.SecondName = reader["Second_Name"].ToString();
                            student.LastName = reader["Last_Name"].ToString();
                            student.PersonalId = reader["Personal_Id"].ToString();
                            student.Degree = reader["Degree"].ToString();
                            student.Specialty = reader["Specialty"].ToString();
                            student.Course = byte.Parse(reader["Course"].ToString());
                            student.Group = reader["Group"].ToString();
                        }
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("An unexpected error has occured with the database. Please try again later.", "Unexpected error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // FUNCTION WHICH RETRIEVES THE NEEDED DATA FOR THE STUDENT WINDOW FROM THE [DISCIPLINES] TABLE.
        public void ReadDisciplines(string connectionString, string readQuery, string specialty, string course, List<Discipline> disciplines)
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
                        if (reader["Specialty"].ToString().Equals(specialty) && reader["Course"].ToString().Equals(course))
                        {
                            Discipline d = new Discipline();

                            d.DisciplineName = reader["Discipline_Name"].ToString();
                            d.Specialty = specialty;
                            d.Course = byte.Parse(course);
                            d.LecturerWorkNumber = reader["Lecturer_Work_Number"].ToString();

                            disciplines.Add(d);
                        }
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
