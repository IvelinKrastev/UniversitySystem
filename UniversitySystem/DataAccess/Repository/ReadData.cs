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

        // FUNCTION WHICH RETRIEVES THE NEEDED DATA FROM THE GRADES FILE.
        public void ReadTableData(string path, List<Grades> grades)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(fs))
                {
                    // READING FROM THE TABLE [STUDENTS].
                    while (!reader.EndOfStream)
                    {
                        string[] split = reader.ReadLine().Split('-');
                        Grades g = new Grades();

                        g.FacultyNumberOfStudent = split[0];
                        g.Specialty = split[1];
                        g.Course = byte.Parse(split[2]);
                        g.Group = split[3];
                        g.DisciplineName = split[4];
                        g.Grade = split[5];
                        g.LecturerNumber = split[6];

                        grades.Add(g);
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

                            d.DisciplineId = int.Parse(split[0]);
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

        // FUNCTION WHICH RETRIEVES THE NEEDED DATA FOR THE STUDENT WINDOW FROM THE [GRADES] TABLE.
        public void ReadGradesForStudent(string path, string fNumber, List<Grades> grades)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(fs))
                {
                    // READING FROM THE TABLE [GRADES].
                    while (!reader.EndOfStream)
                    {
                        string[] split = reader.ReadLine().Split('-');

                        if (split[0].Equals(fNumber))
                        {
                            Grades g = new Grades();

                            g.DisciplineName = split[4];
                            g.Grade = split[5];

                            grades.Add(g);
                        }
                    }
                }
            }
        }

        // FUNCTION WHICH RETRIEVES THE NEEDED DATA FOR THE LECTURER WINDOW FROM THE [GRADES] TABLE.
        public void ReadGradesForLecturer(string path, string workNumber, List<Grades> grades)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(fs))
                {
                    // READING FROM THE TABLE [GRADES].
                    while (!reader.EndOfStream)
                    {
                        string[] split = reader.ReadLine().Split('-');

                        if (split.Length == 7)
                        {
                            if (split[6].Equals(workNumber))
                            {
                                Grades g = new Grades();

                                g.FacultyNumberOfStudent = split[0];
                                g.Specialty = split[1];
                                g.Course = byte.Parse(split[2]);
                                g.Group = split[3];
                                g.DisciplineName = split[4];
                                g.Grade = split[5];

                                grades.Add(g);
                            }
                        }
                    }
                }
            }
        }
    }
}
