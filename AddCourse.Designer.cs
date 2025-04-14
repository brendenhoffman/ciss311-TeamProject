namespace ciss311_TeamProject
{
    partial class AddCourse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addCourseButton = new Button();
            closeButton = new Button();
            courseTitleTextBox = new TextBox();
            semesterOfferedTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            courseIdTextBox = new TextBox();
            instructorTextBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // addCourseButton
            // 
            addCourseButton.Location = new Point(81, 320);
            addCourseButton.Margin = new Padding(2, 1, 2, 1);
            addCourseButton.Name = "addCourseButton";
            addCourseButton.Size = new Size(118, 31);
            addCourseButton.TabIndex = 0;
            addCourseButton.Text = "Add Course";
            addCourseButton.UseVisualStyleBackColor = true;
            addCourseButton.Click += addCourseButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(337, 320);
            closeButton.Margin = new Padding(2, 1, 2, 1);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(116, 31);
            closeButton.TabIndex = 1;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // courseTitleTextBox
            // 
            courseTitleTextBox.Location = new Point(200, 107);
            courseTitleTextBox.Margin = new Padding(2, 1, 2, 1);
            courseTitleTextBox.Name = "courseTitleTextBox";
            courseTitleTextBox.Size = new Size(223, 23);
            courseTitleTextBox.TabIndex = 2;
            // 
            // semesterOfferedTextBox
            // 
            semesterOfferedTextBox.Location = new Point(200, 157);
            semesterOfferedTextBox.Margin = new Padding(2, 1, 2, 1);
            semesterOfferedTextBox.Name = "semesterOfferedTextBox";
            semesterOfferedTextBox.Size = new Size(223, 23);
            semesterOfferedTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 110);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 4;
            label1.Text = "Course Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 157);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 5;
            label2.Text = "Semester Offered:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 38);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 6;
            label3.Text = "Enter Course Data";
            // 
            // courseIdTextBox
            // 
            courseIdTextBox.Location = new Point(200, 71);
            courseIdTextBox.Name = "courseIdTextBox";
            courseIdTextBox.Size = new Size(223, 23);
            courseIdTextBox.TabIndex = 7;
            // 
            // instructorTextBox
            // 
            instructorTextBox.Location = new Point(200, 200);
            instructorTextBox.Name = "instructorTextBox";
            instructorTextBox.Size = new Size(223, 23);
            instructorTextBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(106, 74);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 9;
            label4.Text = "Course ID:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(106, 203);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 10;
            label5.Text = "Instructor:";
            // 
            // AddCourse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 380);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(instructorTextBox);
            Controls.Add(courseIdTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(semesterOfferedTextBox);
            Controls.Add(courseTitleTextBox);
            Controls.Add(closeButton);
            Controls.Add(addCourseButton);
            Margin = new Padding(2, 1, 2, 1);
            Name = "AddCourse";
            Text = "AddCourse";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addCourseButton;
        private Button closeButton;
        private TextBox courseTitleTextBox;
        private TextBox semesterOfferedTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox courseIdTextBox;
        private TextBox instructorTextBox;
        private Label label4;
        private Label label5;
    }
}