
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
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label1, label2, label3, label4, label5;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            comboBoxStudents = new ComboBox();
            listBoxCourses = new ListBox();
            textBoxCourse = new TextBox();
            textBoxTitle = new TextBox();
            textBoxInstructor = new TextBox();
            buttonDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            closeButton = new Button();
            SuspendLayout();
            // 
            // comboBoxStudents
            // 
            comboBoxStudents.Location = new Point(150, 20);
            comboBoxStudents.Name = "comboBoxStudents";
            comboBoxStudents.Size = new Size(200, 23);
            comboBoxStudents.TabIndex = 1;
            comboBoxStudents.SelectedIndexChanged += comboBoxStudents_SelectedIndexChanged;
            // 
            // listBoxCourses
            // 
            listBoxCourses.ItemHeight = 15;
            listBoxCourses.Location = new Point(150, 60);
            listBoxCourses.Name = "listBoxCourses";
            listBoxCourses.Size = new Size(300, 79);
            listBoxCourses.TabIndex = 3;
            listBoxCourses.SelectedIndexChanged += listBoxCourses_SelectedIndexChanged;
            // 
            // textBoxCourse
            // 
            textBoxCourse.Location = new Point(150, 150);
            textBoxCourse.Name = "textBoxCourse";
            textBoxCourse.ReadOnly = true;
            textBoxCourse.Size = new Size(200, 23);
            textBoxCourse.TabIndex = 5;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(150, 190);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.ReadOnly = true;
            textBoxTitle.Size = new Size(200, 23);
            textBoxTitle.TabIndex = 7;
            // 
            // textBoxInstructor
            // 
            textBoxInstructor.Location = new Point(150, 230);
            textBoxInstructor.Name = "textBoxInstructor";
            textBoxInstructor.ReadOnly = true;
            textBoxInstructor.Size = new Size(200, 23);
            textBoxInstructor.TabIndex = 9;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(250, 270);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 11;
            buttonDelete.Text = "Delete";
            buttonDelete.Click += buttonDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Select Student:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 60);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 2;
            label2.Text = "Enrolled Courses:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 150);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 4;
            label3.Text = "Course Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 190);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 6;
            label4.Text = "Course Title:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 230);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 8;
            label5.Text = "Instructor Name:";
            // 
            // closeButton
            // 
            closeButton.Location = new Point(357, 270);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 12;
            closeButton.Text = "&Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // ManageEnrollmentsForm
            // 
            ClientSize = new Size(500, 330);
            Controls.Add(closeButton);
            Controls.Add(label1);
            Controls.Add(comboBoxStudents);
            Controls.Add(label2);
            Controls.Add(listBoxCourses);
            Controls.Add(label3);
            Controls.Add(textBoxCourse);
            Controls.Add(label4);
            Controls.Add(textBoxTitle);
            Controls.Add(label5);
            Controls.Add(textBoxInstructor);
            Controls.Add(buttonDelete);
            Name = "ManageEnrollmentsForm";
            Text = "Manage Enrollments";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button closeButton;
    }
}
