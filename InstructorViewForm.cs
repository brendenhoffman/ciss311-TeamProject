using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ciss311_TeamProject
{
    public partial class InstructorViewForm : Form
    {
        private Dictionary<string, Student> students;
        private Dictionary<string, Course> courses;
        private List<Enrollment> enrollments;

        public InstructorViewForm(
          Dictionary<string, Student> students,
          Dictionary<string, Course> courses,
          List<Enrollment> enrollments)
        {
            InitializeComponent();
            this.students = students;
            this.courses = courses;
            this.enrollments = enrollments;
        }

        private void InstructorViewForm_Load(object sender, EventArgs e)
        {
            var instructorNames = courses.Values
                                         .Select(c => c.Instructor?.Trim())
                                         .Where(name => !string.IsNullOrEmpty(name))
                                         .Distinct(StringComparer.OrdinalIgnoreCase)
                                         .ToList();

            instructorComboBox.DataSource = instructorNames;

            if (instructorNames.Count > 0)
                instructorComboBox.SelectedIndex = 0; // Trigger first instructor load
        }

        private void instructorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (instructorComboBox.SelectedItem == null)
                return;

            string selectedInstructor = instructorComboBox.SelectedItem.ToString().Trim();

            var courseList = courses.Values
                                    .Where(c => c.Instructor != null &&
                                                c.Instructor.Trim()
                                                  .Equals(selectedInstructor, StringComparison.OrdinalIgnoreCase))
                                    .ToList();

            if (courseList.Count > 0)
            {
                courseListBox.DataSource = courseList;
                courseListBox.DisplayMember = "DisplayInfo";
            }
            else
            {
                courseListBox.DataSource = null;
                studentListBox.DataSource = null;
                studentCountLabel.Text = "Total students: 0";
            }
        }

        private void courseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (courseListBox.SelectedItem is not Course selectedCourse)
                return;

            var studentIds = enrollments
              .Where(enroll => enroll.CourseId == selectedCourse.CourseId)
              .Select(enroll => enroll.StudentId);

            var studentList = studentIds
              .Where(id => students.ContainsKey(id))
              .Select(id => students[id])
              .ToList();

            studentListBox.DataSource = studentList;
            studentListBox.DisplayMember = "DisplayInfo";
            studentCountLabel.Text = $"Total students: {studentList.Count}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label1_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void studentListBox_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
