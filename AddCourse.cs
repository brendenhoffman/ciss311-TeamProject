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
        public AddCourse()
        {
            InitializeComponent();
        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            string courseTitle = courseTitleTextBox.Text;
            string semesterOffered = semesterOfferedTextBox.Text;

            if (string.IsNullOrWhiteSpace(courseTitle) || string.IsNullOrWhiteSpace(semesterOffered))
            {
                MessageBox.Show("Please fill in both fields.");
                return;
            }

            try
            {
                using (StreamWriter writer = new StreamWriter("courses.csv", true))
                {
                    writer.WriteLine($"{courseTitle},{semesterOffered}");
                }
                MessageBox.Show("Course added successfully!");
                courseTitleTextBox.Clear();
                semesterOfferedTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
