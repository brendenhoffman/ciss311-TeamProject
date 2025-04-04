using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciss311_TeamProject
{
    public class Enrollment
    {
        public string StudentId { get; set; }
        public string CourseId { get; set; }

        public Enrollment(string studentId, string courseId)
        {
            StudentId = studentId;
            CourseId = courseId;
        }

        public override string ToString()
        {
            return $"{StudentId}|{CourseId}";
        }
    }
}
