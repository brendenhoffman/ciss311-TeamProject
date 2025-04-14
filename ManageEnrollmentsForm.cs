
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ciss311_TeamProject
{
    public partial class ManageEnrollmentsForm : Form
    {
        private Dictionary<string, string> students = new();
        private Dictionary<string, (string Title, string Instructor)> courses = new();
        private List<Enrollment> enrollments = new();

        public ManageEnrollmentsForm()
        {
            InitializeComponent();
            LoadData();
            PopulateStudentDropdown();
        }

        private void LoadData()
        {
            // Load students
            if (File.Exists("students.csv"))
            {
                foreach (var line in File.ReadAllLines("students.csv"))
                {
                    var parts = line.Split('|');
                    if (parts.Length >= 2)
                        students[parts[0]] = parts[1];
                }
            }

            // Load courses
            if (File.Exists("courses.csv"))
            {
                foreach (var line in File.ReadAllLines("courses.csv"))
                {
                    var parts = line.Split('|');
                    if (parts.Length >= 3)
                        courses[parts[0]] = (parts[1], parts[2]);
                }
            }

            // Load enrollments
            if (File.Exists("enrollments.csv"))
            {
                foreach (var line in File.ReadAllLines("enrollments.csv"))
                {
                    var parts = line.Split('|');
                    if (parts.Length >= 2)
                    {
                        enrollments.Add(new Enrollment(parts[0], parts[1]));
                    }
                }
            }
        }

        private void PopulateStudentDropdown()
        {
            var dt = new DataTable();
            dt.Columns.Add("StudentId");
            dt.Columns.Add("FullName");

            foreach (var kvp in students)
            {
                var row = dt.NewRow();
                row["StudentId"] = kvp.Key;
                row["FullName"] = kvp.Value;
                dt.Rows.Add(row);
            }

            comboBoxStudents.DisplayMember = "FullName";
            comboBoxStudents.ValueMember = "StudentId";
            comboBoxStudents.DataSource = dt;
        }

        private void comboBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxCourses.Items.Clear();
            textBoxCourse.Clear();
            textBoxTitle.Clear();
            textBoxInstructor.Clear();

            string studentId = comboBoxStudents.SelectedValue?.ToString();
            if (string.IsNullOrWhiteSpace(studentId)) return;

            foreach (var enrollment in enrollments.Where(e => e.StudentId == studentId))
            {
                var courseId = enrollment.CourseId;
                {
                    if (courses.TryGetValue(courseId, out var info))
                    {
                        listBoxCourses.Items.Add($"{courseId} - {info.Title} ({info.Instructor})");
                    }
                    else
                    {
                        listBoxCourses.Items.Add($"{courseId} - (Unknown)");
                    }
                }
            }
        }

        private void listBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCourses.SelectedItem == null) return;

            string courseId = listBoxCourses.SelectedItem.ToString().Split('-')[0].Trim();
            if (courses.TryGetValue(courseId, out var info))
            {
                textBoxCourse.Text = courseId;
                textBoxTitle.Text = info.Title;
                textBoxInstructor.Text = info.Instructor;
            }
            else
            {
                textBoxCourse.Text = courseId;
                textBoxTitle.Text = "(Unknown)";
                textBoxInstructor.Text = "";
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string studentId = comboBoxStudents.SelectedValue.ToString();
            if (!enrollments.Any(e => e.StudentId == studentId)) return;

            string oldCourseId = null;
            if (listBoxCourses.SelectedItem != null)
            {
                oldCourseId = listBoxCourses.SelectedItem.ToString().Split('-')[0].Trim();
            }

            string newCourseId = textBoxCourse.Text.Trim();
            if (string.IsNullOrWhiteSpace(newCourseId) || oldCourseId == null) return;

            enrollments.RemoveAll(e => e.StudentId == studentId && e.CourseId == oldCourseId);
            enrollments.Add(new Enrollment(studentId, newCourseId));
            SaveEnrollments();
            MessageBox.Show("Enrollment updated.");
            comboBoxStudents_SelectedIndexChanged(null, null);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string studentId = comboBoxStudents.SelectedValue.ToString();
            if (!enrollments.Any(e => e.StudentId == studentId)) return;

            string courseId = null;
            if (listBoxCourses.SelectedItem != null)
            {
                courseId = listBoxCourses.SelectedItem.ToString().Split('-')[0].Trim();
            }

            if (courseId != null)
            {
                enrollments.RemoveAll(e => e.StudentId == studentId && e.CourseId == courseId);
                SaveEnrollments();
                MessageBox.Show("Enrollment removed.");
                comboBoxStudents_SelectedIndexChanged(null, null);
            }
        }

        private void SaveEnrollments()
        {
            var lines = new List<string>();
            foreach (var enrollment in enrollments)
            {
                lines.Add($"{enrollment.StudentId}|{enrollment.CourseId}");
            }
            File.WriteAllLines("enrollments.csv", lines);
        }

        private void ManageEnrollmentsForm_Load(object sender, EventArgs e)
        {
        }
    }
}
