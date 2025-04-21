
namespace ciss311_TeamProject
{
    partial class ManageEnrollmentsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxStudents;
        private System.Windows.Forms.ListBox listBoxCourses;
        private System.Windows.Forms.TextBox textBoxCourse;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxInstructor;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label1, label2, label3, label4, label5;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBoxStudents = new System.Windows.Forms.ComboBox();
            this.listBoxCourses = new System.Windows.Forms.ListBox();
            this.textBoxCourse = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxInstructor = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.label1.Text = "Select Student:";
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.AutoSize = true;

            this.comboBoxStudents.Location = new System.Drawing.Point(150, 20);
            this.comboBoxStudents.Width = 200;
            this.comboBoxStudents.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudents_SelectedIndexChanged);

            this.label2.Text = "Enrolled Courses:";
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.AutoSize = true;

            this.listBoxCourses.Location = new System.Drawing.Point(150, 60);
            this.listBoxCourses.Width = 300;
            this.listBoxCourses.Height = 80;
            this.listBoxCourses.SelectedIndexChanged += new System.EventHandler(this.listBoxCourses_SelectedIndexChanged);

            this.label3.Text = "Course Number:";
            this.label3.Location = new System.Drawing.Point(20, 150);
            this.label3.AutoSize = true;

            this.textBoxCourse.Location = new System.Drawing.Point(150, 150);
            this.textBoxCourse.Width = 200;

            this.label4.Text = "Course Title:";
            this.label4.Location = new System.Drawing.Point(20, 190);
            this.label4.AutoSize = true;

            this.textBoxTitle.Location = new System.Drawing.Point(150, 190);
            this.textBoxTitle.Width = 200;

            this.label5.Text = "Instructor Name:";
            this.label5.Location = new System.Drawing.Point(20, 230);
            this.label5.AutoSize = true;

            this.textBoxInstructor.Location = new System.Drawing.Point(150, 230);
            this.textBoxInstructor.Width = 200;

            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.Location = new System.Drawing.Point(150, 270);
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);

            this.buttonDelete.Text = "Delete";
            this.buttonDelete.Location = new System.Drawing.Point(250, 270);
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);

            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxStudents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxCourses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCourse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxInstructor);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);

            this.Text = "Manage Enrollments";
            this.ClientSize = new System.Drawing.Size(500, 330);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
