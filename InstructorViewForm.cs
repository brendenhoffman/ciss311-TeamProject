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
                                         .Select(c => c.Instructor)
                                         .Distinct()
                                         .ToList();
            instructorComboBox.DataSource = instructorNames;
        }

        private void instructorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string instructor = instructorComboBox.SelectedItem.ToString();
            var courseList = courses.Values
                                    .Where(c => c.Instructor == instructor)
                                    .ToList();

            courseListBox.DataSource = courseList;
        }

        private void courseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (courseListBox.SelectedItem is not Course selectedCourse) return;

            var studentIds = enrollments
                .Where(e => e.CourseId == selectedCourse.CourseId)
                .Select(e => e.StudentId);

            var studentList = studentIds
                .Where(id => students.ContainsKey(id))
                .Select(id => students[id])
                .ToList();

            studentListBox.DataSource = studentList;
            studentListBox.DisplayMember = "Name"; // assuming Student has Name property
            studentCountLabel.Text = $"Total students: {studentList.Count}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void studentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
