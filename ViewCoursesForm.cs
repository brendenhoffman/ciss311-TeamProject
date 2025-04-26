
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ciss311_TeamProject
{
    public partial class ViewCoursesForm : Form
    {
        private Dictionary<string, Course> _courses;
        private DataTable _courseTable;

        public ViewCoursesForm(Dictionary<string, Course> courses)
        {
            InitializeComponent();
            _courses = courses;
            LoadCourses();
            textBoxSearch.TextChanged += TextBoxSearch_TextChanged;
        }

        private void LoadCourses()
        {
            _courseTable = new DataTable();
            _courseTable.Columns.Add("Course Number");
            _courseTable.Columns.Add("Course Title");
            _courseTable.Columns.Add("Instructor");
            _courseTable.Columns.Add("Semester");

            foreach (var course in _courses.Values)
            {
                _courseTable.Rows.Add(course.CourseId, course.Title, course.Instructor, course.Semester);
            }

            dataGridViewCourses.DataSource = _courseTable;
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string filterText = textBoxSearch.Text.Trim();
            if (string.IsNullOrEmpty(filterText))
            {
                dataGridViewCourses.DataSource = _courseTable;
            }
            else
            {
                var filteredTable = _courseTable.Clone();
                foreach (DataRow row in _courseTable.Rows)
                {
                    if (row.ItemArray.Any(field => field.ToString().IndexOf(filterText, StringComparison.OrdinalIgnoreCase) >= 0))
                    {
                        filteredTable.ImportRow(row);
                    }
                }
                dataGridViewCourses.DataSource = filteredTable;
            }
        }
    }
}
