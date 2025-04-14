using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ciss311_TeamProject
{
    public partial class AddCourse : Form
    {
        private Dictionary<string, Student> students;
        private Dictionary<string, Course> courses;
        private List<Enrollment> enrollments;

        public AddCourse(Dictionary<string, Student> students, Dictionary<string, Course> courses, List<Enrollment> enrollments)
        {
            InitializeComponent();
            this.students = students;
            this.courses = courses;
            this.enrollments = enrollments;
        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            string courseId = courseIdTextBox.Text.Trim();
            string title = courseTitleTextBox.Text.Trim();
            string instructor = instructorTextBox.Text.Trim();
            string semester = semesterOfferedTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(courseId) ||
                string.IsNullOrWhiteSpace(title) ||
                string.IsNullOrWhiteSpace(instructor) ||
                string.IsNullOrWhiteSpace(semester))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (courses.ContainsKey(courseId))
            {
                MessageBox.Show("A course with this ID already exists.");
                return;
            }

            Course newCourse = new Course(courseId, title, instructor, semester);

            try
            {
                using (StreamWriter writer = new StreamWriter("courses.csv", true))
                {
                    writer.WriteLine($"{courseId}|{title}|{instructor}|{semester}");
                }

                // Optional: update in-memory course dictionary
                courses[courseId] = newCourse;

                MessageBox.Show("Course added successfully!");
                courseIdTextBox.Clear();
                courseTitleTextBox.Clear();
                instructorTextBox.Clear();
                semesterOfferedTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving course: {ex.Message}");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}