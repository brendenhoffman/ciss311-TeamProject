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
                string[] parts = line.Split('|'); // | delimiter for clarity
                if (parts.Length == 4)
                {
                    string id = parts[0];
                    string name = parts[1];
                    double gpa = double.Parse(parts[2]);
                    double hours = double.Parse(parts[3]);
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
                if (parts.Length == 2)
                {
                    courses[parts[0]] = new Course(parts[0], parts[1]);
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

        private void studentViewCoursesButton_Click(object sender, EventArgs e)
        {

        }

        private void instructorViewCoursesButton_Click(object sender, EventArgs e)
        {
            InstructorViewForm form = new InstructorViewForm(students, courses, enrollments);
            form.ShowDialog();
        }
    }
}

