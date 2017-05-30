using System.Collections.Generic;

namespace DataAccess.Entity
{
    public class Grades
    {
        public ICollection<Student> FacultyNumber { get; set; }

        public string DisciplineName { get; set; }
        public double Grade { get; set; }
        public double Lecturer { get; set; }
    }
}
