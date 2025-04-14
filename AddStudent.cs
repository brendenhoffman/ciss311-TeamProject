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
        public AddStudent()
        {
            InitializeComponent();
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            string studentName = studentTextBox.Text;

            if (string.IsNullOrWhiteSpace(studentName))
            {
                MessageBox.Show("Please enter a valid student name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Specify the path to the CSV file
                string filePath = "students.csv";

                // Append the student name to the CSV file
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(studentName);
                }

                MessageBox.Show("Student name added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                studentTextBox.Clear(); // Clear the textbox after successful addition
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
