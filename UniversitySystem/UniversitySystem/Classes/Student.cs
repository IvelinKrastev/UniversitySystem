using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.Classes
{
    class Student : User
    {

        public string FacultyNumber { get; set; }
        public string Nationality { get; set; }
        public string Degrees { get; set; }
        public string Specialty { get; set; }
        public byte Course { get; set; }
        public string Group { get; set; }
        public int SheduleId { get; set; }
        public string DisciplinesId { get; set; }
    }
}
