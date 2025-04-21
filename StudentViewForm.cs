using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ciss311_TeamProject
{
    public partial class StudentViewForm : Form
    {
        private Dictionary<string, Student> students;
        private Dictionary<string, Course> courses;
        private List<Enrollment> enrollments;

        public StudentViewForm(
            Dictionary<string, Student> students,
            Dictionary<string, Course> courses,
            List<Enrollment> enrollments)
        {
            InitializeComponent();
            this.students = students;
            this.courses = courses;
            this.enrollments = enrollments;
        }

        private void StudentViewForm_Load(object sender, EventArgs e)
        {
            var courseList = courses.Values
                .OrderBy(c => c.Title)
                .ToList();

            courseComboBox.DataSource = courseList;
            courseComboBox.DisplayMember = "DisplayInfo"; // e.g., CourseId - Title
            courseComboBox.ValueMember = "CourseId";
        }

        private void courseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (courseComboBox.SelectedItem is not Course selectedCourse)
                return;

            var studentList = enrollments
                .Where(e => e.CourseId == selectedCourse.CourseId)
                .Select(e => e.StudentId)
                .Where(id => students.ContainsKey(id))
                .Select(id => students[id])
                .ToList();

            studentListBox.DataSource = studentList;
            studentListBox.DisplayMember = "DisplayInfo";
            studentCountLabel.Text = $"Enrolled Students: {studentList.Count}";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
