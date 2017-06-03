using DataAccess.Entity;
using System.Collections.Generic;
using System.IO;

namespace DataAccess.Repository
{
    public class ReadData
    {
        // FUNCTION WHICH RETRIEVES THE NEEDED DATA FOR LOGIN FROM THE [STUDENT] TABLE.
        public void ReadForLogin(string path, List<Student> students)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(fs))
                {
                    // READING FROM THE TABLE [STUDENTS].
                    while (!reader.EndOfStream)
                    {
                        Student s = new Student();

                        string[] split = reader.ReadLine().Split('-');

                        s.FacultyNumber = split[0];
                        s.PersonalId = split[4];

                        students.Add(s);
                    }
                }
            }
        }

        // FUNCTION WHICH RETRIEVES THE NEEDED DATA FOR LOGIN FROM THE [LECTURER] TABLE.
        public void ReadForLogin(string path, List<Lecturer> lecturers)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(fs))
                {
                    // READING FROM THE TABLE [LECTURER].
                    while (!reader.EndOfStream)
                    {
                        string[] split = reader.ReadLine().Split('-');

                        Lecturer l = new Lecturer();
                        l.PersonalId = split[5].ToString();
                        l.WorkNumber = split[0].ToString();

                        lecturers.Add(l);
                    }
                }
            }
        }
        
        // FUNCTION WHICH RETRIEVES THE NEEDED DATA FOR THE STUDENT WINDOW.
        public void ReadTableData(string path, string facNumber, Student student)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(fs))
                {
                    // READING FROM THE TABLE [STUDENTS].
                    while (!reader.EndOfStream)
                    {
                        string[] split = reader.ReadLine().Split('-');

                        if (split[0].Equals(facNumber))
                        {
                            student.FacultyNumber = split[0];
                            student.FirstName = split[1];
                            student.SecondName = split[2];
                            student.LastName = split[3];
                            student.PersonalId = split[4];
                            student.Degree = split[5];
                            student.Specialty = split[6];
                            student.Course = byte.Parse(split[7]);
                            student.Group = split[8];

                            break;
                        }
                    }
                }
            }
        }

        // FUNCTION WHICH RETRIEVES THE NEEDED DATA FOR THE LECTURER WINDOW.
        public void ReadTableData(string path, string workNumber, Lecturer lecturer)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(fs))
                {
                    // READING FROM THE TABLE [LECTURER].
                    while (!reader.EndOfStream)
                    {
                        string[] split = reader.ReadLine().Split('-');

                        if (split[0].Equals(workNumber))
                        {
                            lecturer.WorkNumber = split[0];
                            lecturer.Degree = split[1];
                            lecturer.FirstName = split[2];
                            lecturer.SecondName = split[3];
                            lecturer.LastName = split[4];
                            lecturer.PersonalId = split[5];
                            lecturer.Image = split[6];

                            break;
                        }
                    }
                }
            }
        }

        // FUNCTION WHICH RETRIEVES THE NEEDED DATA FOR THE STUDENT WINDOW FROM THE [DISCIPLINES] TABLE.
        public void ReadDisciplines(string path, string specialty, string course, List<Discipline> disciplines)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(fs))
                {
                    // READING FROM THE TABLE [DISCIPLINES].
                    while (!reader.EndOfStream)
                    {
                        string[] split = reader.ReadLine().Split('-');

                        if (split[2].Equals(specialty) && split[3].ToString().Equals(course))
                        {
                            Discipline d = new Discipline();

                            d.DisciplineName = split[1];
                            d.Specialty = specialty;
                            d.Course = byte.Parse(course);
                            d.LecturerWorkNumber = split[4];

                            disciplines.Add(d);
                        }
                    }
                }
            }
        }

        // FUNCTION WHICH RETRIEVES THE NEEDED DATA FOR THE STUDENT WINDOW FROM THE [GRADES] TABLE.
        public void ReadGrades(string path, string fNumber, List<Grades> grades)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(fs))
                {
                    // READING FROM THE TABLE [GRADES].
                    while (!reader.EndOfStream)
                    {
                        string[] split = reader.ReadLine().Split('-');
                        bool visited = false;
                        int number = int.Parse(split[1]);
                        int number2 = int.Parse(fNumber);
                        if (number==number2)
                        {
                            visited = true;
                            Grades g = new Grades();
                            switch(split[0].Trim()){
                                case "1": g.DisciplineName = "Introduction to Programming with C#"; break;
                                case "2": g.DisciplineName = "Introduction to IT";break;
                                case "3": g.DisciplineName = "English"; break;
                                case "4": g.DisciplineName = "Graphic Design"; break;
                                case "5": g.DisciplineName = "Sport"; break;
                                case "6": g.DisciplineName = "Object-Oriented Programming"; break;
                                case "7": g.DisciplineName = "Event Programming"; break;
                                case "8": g.DisciplineName = "Geometric Design"; break;
                                case "9": g.DisciplineName = "Databases"; break;
                                case "10": g.DisciplineName = "Vector Images"; break;
                                case "11": g.DisciplineName = "Design Of Mobile Applications"; break;
                                case "12": g.DisciplineName = "Design Of 3D Models"; break;
                                case "13": g.DisciplineName = "Framework Systems For Web Programming"; break;
                            }
                            string grade = split[6].Trim();
                            g.Grade = double.Parse(grade);
                            string lecturerID = split[7].Trim();
                            g.Lecturer = double.Parse(lecturerID);
                            grades.Add(g);   
                            
                        }
                    }
                }
            }
        }

        // FUNCTION WHICH RETRIEVES THE NEEDED DATA FOR THE LECTURER WINDOW FROM THE [DISCIPLINES] TABLE.
        public void ReadDisciplines(string path, string workNumber, List<Discipline> disciplines)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(fs))
                {
                    // READING FROM THE TABLE [DISCIPLINES].
                    while (!reader.EndOfStream)
                    {
                        string[] split = reader.ReadLine().Split('-');

                        if (split[4].Equals(workNumber))
                        {
                            Discipline d = new Discipline();

                            d.DisciplineName = split[1];
                            d.Specialty = split[2];
                            d.Course = byte.Parse(split[3]);
                            d.LecturerWorkNumber = workNumber;

                            disciplines.Add(d);
                        }
                    }
                }
            }
        }
    }
}
