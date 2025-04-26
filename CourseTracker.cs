using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ciss311_TeamProject
{
    public partial class CourseTracker : Form
    {
        private Dictionary<string, Student> students = new();
        private Dictionary<string, Course> courses = new();
        private List<Enrollment> enrollments = new();

        public CourseTracker()
        {
            InitializeComponent();
        }

        private void CourseTracker_Load(object sender, EventArgs e)
        {
            LoadStudents("students.csv");
            LoadCourses("courses.csv");
            LoadEnrollments("enrollments.csv");
        }

        private void enrollButton_Click(object sender, EventArgs e)
        {
            EnrollForm enrollForm = new EnrollForm(students, courses, enrollments);
            enrollForm.ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            savingLabel.Visible = true;
            savingLabel.Refresh();
            SaveStudents("students.csv");
            SaveCourses("courses.csv");
            SaveEnrollments("enrollments.csv");
            SaveToDatabase(); // new
            Close();
        }

        private void LoadStudents(string path)
        {
            if (!File.Exists(path)) return;

            using StreamReader sr = new StreamReader(path);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] parts = line.Split('|');

                if (parts.Length >= 2)
                {
                    string id = parts[0].Trim();
                    string name = parts[1].Trim();

                    double gpa = 0.0;
                    double hours = 0.0;

                    if (parts.Length >= 3)
                        double.TryParse(parts[2], out gpa);
                    if (parts.Length >= 4)
                        double.TryParse(parts[3], out hours);

                    students[id] = new Student(id, name, gpa, hours);
                }
            }
        }

        private void SaveStudents(string path)
        {
            using StreamWriter sw = new StreamWriter(path);
            foreach (Student s in students.Values)
            {
                sw.WriteLine(s.ToString());
            }
        }

        private void LoadCourses(string path)
        {
            if (!File.Exists(path)) return;

            using StreamReader sr = new StreamReader(path);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 4)
                {
                    courses[parts[0]] = new Course(parts[0], parts[1], parts[2], parts[3]);
                }
            }
        }

        private void SaveCourses(string path)
        {
            using StreamWriter sw = new StreamWriter(path);
            foreach (Course c in courses.Values)
            {
                sw.WriteLine(c.ToString());
            }
        }

        private void LoadEnrollments(string path)
        {
            if (!File.Exists(path)) return;

            using StreamReader sr = new StreamReader(path);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 2)
                {
                    enrollments.Add(new Enrollment(parts[0], parts[1]));
                }
            }
        }

        private void SaveEnrollments(string path)
        {
            using StreamWriter sw = new StreamWriter(path);
            foreach (Enrollment e in enrollments)
            {
                sw.WriteLine(e.ToString());
            }
        }

        private void SaveToDatabase()
        {
            try
            {
                using SqlConnection conn = new SqlConnection(Properties.Settings.Default.connString);
                conn.Open();

                // Wipe existing data
                new SqlCommand("DELETE FROM Enrollment", conn).ExecuteNonQuery();
                new SqlCommand("DELETE FROM Course", conn).ExecuteNonQuery();
                new SqlCommand("DELETE FROM Student", conn).ExecuteNonQuery();

                // Save students
                foreach (var s in students.Values)
                {
                    using SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Student (StudentId, Name, Gpa, Hours) VALUES (@id, @name, @gpa, @hours)", conn);

                    cmd.Parameters.AddWithValue("@id", s.StudentId);
                    cmd.Parameters.AddWithValue("@name", s.Name);
                    cmd.Parameters.AddWithValue("@gpa", s.Gpa);
                    cmd.Parameters.AddWithValue("@hours", s.Hours);

                    cmd.ExecuteNonQuery();
                }

                // Save courses
                foreach (var c in courses.Values)
                {
                    using SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Course (CourseId, Title, Instructor, Semester) VALUES (@id, @title, @instructor, @semester)", conn);

                    cmd.Parameters.AddWithValue("@id", c.CourseId);
                    cmd.Parameters.AddWithValue("@title", c.Title);
                    cmd.Parameters.AddWithValue("@instructor", c.Instructor);
                    cmd.Parameters.AddWithValue("@semester", c.Semester);

                    cmd.ExecuteNonQuery();
                }

                // Save enrollments
                foreach (var e in enrollments)
                {
                    using SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Enrollment (StudentId, CourseId) VALUES (@studentId, @courseId)", conn);

                    cmd.Parameters.AddWithValue("@studentId", e.StudentId);
                    cmd.Parameters.AddWithValue("@courseId", e.CourseId);

                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                // Fail quietly
            }
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            AddStudent addStudentForm = new AddStudent(students);
            addStudentForm.ShowDialog();
        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            AddCourse addCourseForm = new AddCourse(students, courses, enrollments);
            addCourseForm.ShowDialog();
        }

        private void studentViewCoursesButton_Click(object sender, EventArgs e)
        {
            ViewCoursesForm viewCoursesForm = new ViewCoursesForm(courses);
            viewCoursesForm.ShowDialog();
        }

        private void instructorViewCoursesButton_Click(object sender, EventArgs e)
        {
            InstructorViewForm form = new InstructorViewForm(students, courses, enrollments);
            form.ShowDialog();
        }

        private void manageEnrollmentsButton_Click(object sender, EventArgs e)
        {
            ManageEnrollmentsForm form = new ManageEnrollmentsForm(students, courses, enrollments);
            form.ShowDialog();
        }

        private void searchCoursesButton_Click(object sender, EventArgs e)
        {
            StudentViewForm form = new StudentViewForm(students, courses, enrollments);
            form.ShowDialog();
        }

        private void viewStudentsButton_Click(object sender, EventArgs e)
        {
            ViewStudentsForm form = new ViewStudentsForm(students);
            form.ShowDialog();
        }
    }
}
