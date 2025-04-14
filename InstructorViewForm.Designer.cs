namespace ciss311_TeamProject
{
    partial class InstructorViewForm
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
            instructorComboBox = new ComboBox();
            studentListBox = new ListBox();
            courseListBox = new ListBox();
            studentCountLabel = new Label();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // instructorComboBox
            // 
            instructorComboBox.FormattingEnabled = true;
            instructorComboBox.Location = new Point(198, 55);
            instructorComboBox.Name = "instructorComboBox";
            instructorComboBox.Size = new Size(121, 23);
            instructorComboBox.TabIndex = 0;
            instructorComboBox.SelectedIndexChanged += instructorComboBox_SelectedIndexChanged;
            // 
            // studentListBox
            // 
            studentListBox.FormattingEnabled = true;
            studentListBox.ItemHeight = 15;
            studentListBox.Location = new Point(87, 106);
            studentListBox.Name = "studentListBox";
            studentListBox.Size = new Size(232, 124);
            studentListBox.TabIndex = 1;
            studentListBox.SelectedIndexChanged += studentListBox_SelectedIndexChanged;
            // 
            // courseListBox
            // 
            courseListBox.FormattingEnabled = true;
            courseListBox.ItemHeight = 15;
            courseListBox.Location = new Point(398, 106);
            courseListBox.Name = "courseListBox";
            courseListBox.Size = new Size(229, 124);
            courseListBox.TabIndex = 2;
            courseListBox.SelectedIndexChanged += courseListBox_SelectedIndexChanged;
            // 
            // studentCountLabel
            // 
            studentCountLabel.AutoSize = true;
            studentCountLabel.Location = new Point(87, 276);
            studentCountLabel.Name = "studentCountLabel";
            studentCountLabel.Size = new Size(80, 15);
            studentCountLabel.TabIndex = 3;
            studentCountLabel.Text = "studentCount";
            studentCountLabel.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(552, 276);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(340, 106);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 5;
            label1.Text = "Courses:";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 106);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 6;
            label2.Text = "Students:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 58);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 7;
            label3.Text = "Instructor:";
            // 
            // InstructorViewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 369);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(studentCountLabel);
            Controls.Add(courseListBox);
            Controls.Add(studentListBox);
            Controls.Add(instructorComboBox);
            Name = "InstructorViewForm";
            Text = "InstructorViewForm";
            Load += InstructorViewForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox instructorComboBox;
        private ListBox studentListBox;
        private ListBox courseListBox;
        private Label studentCountLabel;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}