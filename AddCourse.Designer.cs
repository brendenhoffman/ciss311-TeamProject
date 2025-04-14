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
            SuspendLayout();
            // 
            // addCourseButton
            // 
            addCourseButton.Location = new Point(150, 682);
            addCourseButton.Name = "addCourseButton";
            addCourseButton.Size = new Size(220, 66);
            addCourseButton.TabIndex = 0;
            addCourseButton.Text = "Add Course";
            addCourseButton.UseVisualStyleBackColor = true;
            addCourseButton.Click += addCourseButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(626, 682);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(216, 66);
            closeButton.TabIndex = 1;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // courseTitleTextBox
            // 
            courseTitleTextBox.Location = new Point(371, 228);
            courseTitleTextBox.Name = "courseTitleTextBox";
            courseTitleTextBox.Size = new Size(411, 39);
            courseTitleTextBox.TabIndex = 2;
            // 
            // semesterOfferedTextBox
            // 
            semesterOfferedTextBox.Location = new Point(371, 335);
            semesterOfferedTextBox.Name = "semesterOfferedTextBox";
            semesterOfferedTextBox.Size = new Size(411, 39);
            semesterOfferedTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(184, 235);
            label1.Name = "label1";
            label1.Size = new Size(146, 32);
            label1.TabIndex = 4;
            label1.Text = "Course Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 335);
            label2.Name = "label2";
            label2.Size = new Size(207, 32);
            label2.TabIndex = 5;
            label2.Text = "Semester Offered:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 80);
            label3.Name = "label3";
            label3.Size = new Size(206, 32);
            label3.TabIndex = 6;
            label3.Text = "Enter Course Data";
            // 
            // AddCourse
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 810);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(semesterOfferedTextBox);
            Controls.Add(courseTitleTextBox);
            Controls.Add(closeButton);
            Controls.Add(addCourseButton);
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
    }
}