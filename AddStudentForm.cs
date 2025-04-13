
namespace ciss311_TeamProject
{
    internal class AddStudentForm : AddStudent
    {
        private Dictionary<string, Student> students;
        private Dictionary<string, Course> courses;
        private List<Enrollment> enrollments;

        public AddStudentForm(Dictionary<string, Student> students, Dictionary<string, Course> courses, List<Enrollment> enrollments)
        {
            this.students = students;
            this.courses = courses;
            this.enrollments = enrollments;
        }
    }
}