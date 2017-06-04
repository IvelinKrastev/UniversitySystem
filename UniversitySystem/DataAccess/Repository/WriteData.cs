using DataAccess.Entity;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace DataAccess.Repository
{
    public class WriteData
    {
        public void UpdateGrades(string path, List<Grades> allGrades, int index, double grade)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    allGrades[index].Grade = grade.ToString();

                    foreach (Grades g in allGrades)
                        sw.WriteLine("{0}-{1}-{2}-{3}-{4}-{5}-{6}", g.FacultyNumberOfStudent, g.Specialty, g.Course.ToString(),
                            g.Group, g.DisciplineName, g.Grade, g.LecturerNumber);
                }
            }
            MessageBox.Show("Grade changed successfully!", "Changes made!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
