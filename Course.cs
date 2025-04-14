using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciss311_TeamProject
{
    public class Course
    {
        public string CourseId { get; set; }
        public string Title { get; set; }
        public string Instructor { get; set; }
        public string Semester { get; set; }

        public Course(string courseId, string title, string instructor, string semester)
        {
            CourseId = courseId;
            Title = title;
            Instructor = instructor;
            Semester = semester;
        }

        public override string ToString()
        {
            return $"{CourseId}|{Title}|{Instructor}|{Semester}";
        }

        public string DisplayInfo => $"{CourseId} - {Title}";

    }
}
