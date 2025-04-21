﻿namespace ciss311_TeamProject
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
            enrollButton.Location = new Point(93, 263);
            enrollButton.Margin = new Padding(3, 4, 3, 4);
            enrollButton.Name = "enrollButton";
            enrollButton.Size = new Size(154, 31);
            enrollButton.TabIndex = 0;
            enrollButton.Text = "&Enroll in a course";
            enrollButton.UseVisualStyleBackColor = true;
            enrollButton.Click += enrollButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(719, 491);
            closeButton.Margin = new Padding(3, 4, 3, 4);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(136, 31);
            closeButton.TabIndex = 1;
            closeButton.Text = "Save and &Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(247, 95);
            label1.Name = "label1";
            label1.Size = new Size(450, 54);
            label1.TabIndex = 2;
            label1.Text = "College Course Tracker";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(93, 207);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 3;
            label2.Text = "Student";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(378, 207);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 4;
            label3.Text = "Instructor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(671, 207);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 5;
            label4.Text = "Admin";
            // 
            // studentViewCoursesButton
            // 
            studentViewCoursesButton.Location = new Point(93, 324);
            studentViewCoursesButton.Margin = new Padding(3, 4, 3, 4);
            studentViewCoursesButton.Name = "studentViewCoursesButton";
            studentViewCoursesButton.Size = new Size(154, 31);
            studentViewCoursesButton.TabIndex = 6;
            studentViewCoursesButton.Text = "&View my Courses";
            studentViewCoursesButton.UseVisualStyleBackColor = true;
            studentViewCoursesButton.Click += studentViewCoursesButton_Click;
            // 
            // searchCoursesButton
            // 
            searchCoursesButton.Location = new Point(93, 387);
            searchCoursesButton.Margin = new Padding(3, 4, 3, 4);
            searchCoursesButton.Name = "searchCoursesButton";
            searchCoursesButton.Size = new Size(154, 31);
            searchCoursesButton.TabIndex = 7;
            searchCoursesButton.Text = "&Search for Courses";
            searchCoursesButton.UseVisualStyleBackColor = true;
            // 
            // instructorViewCoursesButton
            // 
            instructorViewCoursesButton.Location = new Point(378, 263);
            instructorViewCoursesButton.Margin = new Padding(3, 4, 3, 4);
            instructorViewCoursesButton.Name = "instructorViewCoursesButton";
            instructorViewCoursesButton.Size = new Size(154, 31);
            instructorViewCoursesButton.TabIndex = 8;
            instructorViewCoursesButton.Text = "V&iew my Students";
            instructorViewCoursesButton.UseVisualStyleBackColor = true;
            instructorViewCoursesButton.Click += instructorViewCoursesButton_Click;
            // 
            // manageEnrollmentsButton
            // 
            manageEnrollmentsButton.Location = new Point(671, 263);
            manageEnrollmentsButton.Margin = new Padding(3, 4, 3, 4);
            manageEnrollmentsButton.Name = "manageEnrollmentsButton";
            manageEnrollmentsButton.Size = new Size(154, 31);
            manageEnrollmentsButton.TabIndex = 9;
            manageEnrollmentsButton.Text = "&Manage Enrollments";
            manageEnrollmentsButton.UseVisualStyleBackColor = true;
            manageEnrollmentsButton.Click += manageEnrollmentsButton_Click;
            // 
            // addStudentButton
            // 
            addStudentButton.Location = new Point(673, 324);
            addStudentButton.Margin = new Padding(2, 1, 2, 1);
            addStudentButton.Name = "addStudentButton";
            addStudentButton.Size = new Size(152, 31);
            addStudentButton.TabIndex = 10;
            addStudentButton.Text = "Add a Student";
            addStudentButton.UseVisualStyleBackColor = true;
            addStudentButton.Click += addStudentButton_Click;
            // 
            // addCourseButton
            // 
            addCourseButton.Location = new Point(673, 388);
            addCourseButton.Margin = new Padding(2, 1, 2, 1);
            addCourseButton.Name = "addCourseButton";
            addCourseButton.Size = new Size(152, 29);
            addCourseButton.TabIndex = 11;
            addCourseButton.Text = "Add a Course";
            addCourseButton.UseVisualStyleBackColor = true;
            addCourseButton.Click += addCourseButton_Click;
            // 
            // CourseTracker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
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
            Margin = new Padding(3, 4, 3, 4);
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
