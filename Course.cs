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

        public Course(string id, string title)
        {
            CourseId = id;
            Title = title;
        }

        public override string ToString()
        {
            return $"{CourseId}|{Title}";
        }
    }
}
