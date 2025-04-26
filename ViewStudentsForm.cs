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
    public partial class ViewStudentsForm : Form
    {
        private Dictionary<string, Student> students;
        private DataTable studentTable;

        public ViewStudentsForm(Dictionary<string, Student> students)
        {
            InitializeComponent();
            this.students = students;
            this.Load += StudentListForm_Load;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            closeButton.Click += closeButton_Click;
        }

        private void StudentListForm_Load(object sender, EventArgs e)
        {
            studentTable = new DataTable();
            studentTable.Columns.Add("Student ID");
            studentTable.Columns.Add("Name");
            studentTable.Columns.Add("GPA");
            studentTable.Columns.Add("Credit Hours");

            foreach (var s in students.Values)
            {
                studentTable.Rows.Add(s.StudentId, s.Name, s.Gpa.ToString("0.00"), s.Hours);
            }

            studentGridView.DataSource = studentTable;
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string filter = searchTextBox.Text.Trim().Replace("'", "''"); // Escape quotes
            if (string.IsNullOrEmpty(filter))
            {
                studentTable.DefaultView.RowFilter = "";
            }
            else
            {
                studentTable.DefaultView.RowFilter =
                    $"[Student ID] LIKE '%{filter}%' OR [Name] LIKE '%{filter}%'";
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
