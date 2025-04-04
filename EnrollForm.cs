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
    public partial class EnrollForm : Form
    {
        private Dictionary<string, Student> students;
        private Dictionary<string, Course> courses;
        private List<Enrollment> enrollments;
        public EnrollForm()
        {
            InitializeComponent();
        }

        public EnrollForm(Dictionary<string, Student> studentsRef, Dictionary<string, Course> coursesRef, List<Enrollment> enrollmentsRef)
        {
            InitializeComponent();
            students = studentsRef;
            courses = coursesRef;
            enrollments = enrollmentsRef;
        }

        private void EnrollForm_Load(object sender, EventArgs e)
        {
            coursesListbox.Items.Clear();
            foreach (Course c in courses.Values)
            {
                coursesListbox.Items.Add($"{c.CourseId} - {c.Title}");
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            string id = studentTextbox.Text.Trim();
            if (!students.ContainsKey(id))
            {
                MessageBox.Show("Student not found.");
                return;
            }

            enrolledListbox.Items.Clear();
            foreach (Enrollment enrollment in enrollments.Where(e => e.StudentId == id))
            {
                if (courses.TryGetValue(enrollment.CourseId, out Course c))
                {
                    enrolledListbox.Items.Add($"{c.CourseId} - {c.Title}");
                }
            }
        }

        private void enrollButton_Click(object sender, EventArgs e)
        {
            string id = studentTextbox.Text.Trim();
            if (!students.ContainsKey(id))
            {
                MessageBox.Show("Student not found.");
                return;
            }

            if (coursesListbox.SelectedIndex == -1)
            {
                MessageBox.Show("Select a course.");
                return;
            }

            string selectedCourseId = coursesListbox.SelectedItem.ToString().Split(' ')[0];

            if (enrollments.Any(e => e.StudentId == id && e.CourseId == selectedCourseId))
            {
                MessageBox.Show("Already enrolled in this course.");
                return;
            }

            enrollments.Add(new Enrollment(id, selectedCourseId));
            enrolledListbox.Items.Add(courses[selectedCourseId].CourseId + " - " + courses[selectedCourseId].Title);
            MessageBox.Show("Enrollment successful.");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
