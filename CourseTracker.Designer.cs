namespace ciss311_TeamProject
{
    partial class CourseTracker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            enrollButton = new Button();
            closeButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            studentViewCoursesButton = new Button();
            searchCoursesButton = new Button();
            instructorViewCoursesButton = new Button();
            manageEnrollmentsButton = new Button();
            addStudentButton = new Button();
            addCourseButton = new Button();
            SuspendLayout();
            // 
            // enrollButton
            // 
            enrollButton.Location = new Point(150, 420);
            enrollButton.Margin = new Padding(6);
            enrollButton.Name = "enrollButton";
            enrollButton.Size = new Size(251, 49);
            enrollButton.TabIndex = 0;
            enrollButton.Text = "&Enroll in a course";
            enrollButton.UseVisualStyleBackColor = true;
            enrollButton.Click += enrollButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(1168, 785);
            closeButton.Margin = new Padding(6);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(221, 49);
            closeButton.TabIndex = 1;
            closeButton.Text = "Save and &Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(401, 151);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(722, 86);
            label1.TabIndex = 2;
            label1.Text = "College Course Tracker";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(150, 331);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(102, 32);
            label2.TabIndex = 3;
            label2.Text = "Student";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(615, 331);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(128, 32);
            label3.TabIndex = 4;
            label3.Text = "Instructor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1090, 331);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(90, 32);
            label4.TabIndex = 5;
            label4.Text = "Admin";
            // 
            // studentViewCoursesButton
            // 
            studentViewCoursesButton.Location = new Point(150, 518);
            studentViewCoursesButton.Margin = new Padding(6);
            studentViewCoursesButton.Name = "studentViewCoursesButton";
            studentViewCoursesButton.Size = new Size(251, 49);
            studentViewCoursesButton.TabIndex = 6;
            studentViewCoursesButton.Text = "&View my Courses";
            studentViewCoursesButton.UseVisualStyleBackColor = true;
            // 
            // searchCoursesButton
            // 
            searchCoursesButton.Location = new Point(150, 619);
            searchCoursesButton.Margin = new Padding(6);
            searchCoursesButton.Name = "searchCoursesButton";
            searchCoursesButton.Size = new Size(251, 49);
            searchCoursesButton.TabIndex = 7;
            searchCoursesButton.Text = "&Search for Courses";
            searchCoursesButton.UseVisualStyleBackColor = true;
            // 
            // instructorViewCoursesButton
            // 
            instructorViewCoursesButton.Location = new Point(615, 420);
            instructorViewCoursesButton.Margin = new Padding(6);
            instructorViewCoursesButton.Name = "instructorViewCoursesButton";
            instructorViewCoursesButton.Size = new Size(251, 49);
            instructorViewCoursesButton.TabIndex = 8;
            instructorViewCoursesButton.Text = "V&iew my Students";
            instructorViewCoursesButton.UseVisualStyleBackColor = true;
            // 
            // manageEnrollmentsButton
            // 
            manageEnrollmentsButton.Location = new Point(1090, 420);
            manageEnrollmentsButton.Margin = new Padding(6);
            manageEnrollmentsButton.Name = "manageEnrollmentsButton";
            manageEnrollmentsButton.Size = new Size(251, 49);
            manageEnrollmentsButton.TabIndex = 9;
            manageEnrollmentsButton.Text = "&Manage Enrollments";
            manageEnrollmentsButton.UseVisualStyleBackColor = true;
            // 
            // addStudentButton
            // 
            addStudentButton.Location = new Point(150, 702);
            addStudentButton.Name = "addStudentButton";
            addStudentButton.Size = new Size(247, 56);
            addStudentButton.TabIndex = 10;
            addStudentButton.Text = "Add a Student";
            addStudentButton.UseVisualStyleBackColor = true;
            addStudentButton.Click += addStudentButton_Click;
            // 
            // addCourseButton
            // 
            addCourseButton.Location = new Point(150, 800);
            addCourseButton.Name = "addCourseButton";
            addCourseButton.Size = new Size(247, 46);
            addCourseButton.TabIndex = 11;
            addCourseButton.Text = "Add a Course";
            addCourseButton.UseVisualStyleBackColor = true;
            addCourseButton.Click += addCourseButton_Click;
            // 
            // CourseTracker
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(addCourseButton);
            Controls.Add(addStudentButton);
            Controls.Add(manageEnrollmentsButton);
            Controls.Add(instructorViewCoursesButton);
            Controls.Add(searchCoursesButton);
            Controls.Add(studentViewCoursesButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(closeButton);
            Controls.Add(enrollButton);
            Margin = new Padding(6);
            Name = "CourseTracker";
            Text = "Course Tracker";
            Load += CourseTracker_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button enrollButton;
        private Button closeButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button studentViewCoursesButton;
        private Button searchCoursesButton;
        private Button instructorViewCoursesButton;
        private Button manageEnrollmentsButton;
        private Button addStudentButton;
        private Button addCourseButton;
    }
}
