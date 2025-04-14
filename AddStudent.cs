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
    public partial class AddStudent : Form
    {
        private const string FilePath = "students.csv";

        private Dictionary<string, Student> students;

        public AddStudent(Dictionary<string, Student> students)
        {
            InitializeComponent();
            this.students = students;
        }


        private void addStudentButton_Click(object sender, EventArgs e)
        {
            string studentId = studentIdTextBox.Text.Trim();
            string studentName = studentTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(studentId) || string.IsNullOrWhiteSpace(studentName))
            {
                MessageBox.Show("Please enter both Student ID and Name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the student ID already exists in the CSV
            if (File.Exists(FilePath))
            {
                var existingIds = File.ReadLines(FilePath)
                    .Select(line => line.Split('|')[0].Trim())
                    .ToHashSet();

                if (existingIds.Contains(studentId))
                {
                    MessageBox.Show("That Student ID already exists.", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            try
            {
                using (StreamWriter writer = new StreamWriter(FilePath, true))
                {
                    writer.WriteLine($"{studentId}|{studentName}");
                }

                students[studentId] = new Student(studentId, studentName, 0.0, 0.0);

                MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                studentIdTextBox.Clear();
                studentTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
