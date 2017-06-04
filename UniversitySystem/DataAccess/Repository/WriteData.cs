using DataAccess.Entity;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System;

namespace DataAccess.Repository
{
    public class WriteData
    {
        public void UpdateGrades(string path, List<Grades> allGrades, string facNumber, string discipline, double grade)
        {
            File.Delete(path);

            using (FileStream fs = new FileStream(path, FileMode.CreateNew))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    //var CustomersQuery = from customers in northwindSampleDataContext1.Customers
                    //                     where customers.Country == "US"
                    //                     select customers;

                    foreach (Grades g in allGrades)
                    {
                        if (g.FacultyNumberOfStudent.Equals(facNumber) && g.DisciplineName.Equals(discipline))
                        {
                            g.Grade = grade.ToString();

                            break;
                        }
                    }

                    foreach (Grades g in allGrades)
                    {
                        sw.WriteLine("{0}-{1}-{2}-{3}-{4}-{5}-{6}", g.FacultyNumberOfStudent, g.Specialty, g.Course.ToString(), g.Group, g.DisciplineName, g.Grade, g.LecturerNumber);
                    }
                }
            }
            MessageBox.Show("Grade changed successfully!", "Changes made!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
