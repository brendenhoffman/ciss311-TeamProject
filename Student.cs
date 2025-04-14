using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciss311_TeamProject
{
    public class Student
    {
        public string StudentId { get; set; }
        public string Name { get; set; }
        public double Gpa { get; set; }
        public double Hours { get; set; }

        public Student(string studentId, string name, double gpa, double hours)
        {
            StudentId = studentId;
            Name = name;
            Gpa = gpa;
            Hours = hours;
        }

        public override string ToString()
        {
            return $"{StudentId}|{Name}|{Gpa}|{Hours}";
        }

        public string DisplayInfo => $"{StudentId} - {Name}";
    }
}
