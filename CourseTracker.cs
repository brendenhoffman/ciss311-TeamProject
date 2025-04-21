namespace ciss311_TeamProject
{
    public partial class CourseTracker : Form
    {
        private Dictionary<string, Student> students = new();
        private Dictionary<string, Course> courses = new();
        private List<Enrollment> enrollments = new(); public CourseTracker()
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
            SaveStudents("students.csv");
            SaveEnrollments("enrollments.csv");
            Close();
        }

        private void LoadStudents(string path)
        {
            if (!File.Exists(path)) return;

            using StreamReader sr = new StreamReader(path);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] parts = line.Split('|'); // or ',' if you're using CSV-style instead

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
                sw.WriteLine(s.ToString()); // Format: ID|Name|Gpa|Hours
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
                sw.WriteLine(e.ToString()); // Format: StudentId|CourseId
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
    }
}

