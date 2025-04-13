
namespace ciss311_TeamProject
{
    internal class AddCourseForm : AddCourse
    {
        private Dictionary<string, Student> students;
        private Dictionary<string, Course> courses;
        private List<Enrollment> enrollments;

        public AddCourseForm(Dictionary<string, Student> students, Dictionary<string, Course> courses, List<Enrollment> enrollments)
        {
            this.students = students;
            this.courses = courses;
            this.enrollments = enrollments;
        }
    }
}