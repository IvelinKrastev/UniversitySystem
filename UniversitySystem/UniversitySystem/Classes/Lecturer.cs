using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.Classes
{
    class Lecturer:User
    {
        public string ServiceNumber { get; set; }
        public string ScientificDegree { get; set; }
        public string WorkSchedule { get; set; }
        public List<string> TaughtDisciplines { get; set; }

       
       

    }
}
