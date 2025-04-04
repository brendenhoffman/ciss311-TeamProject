namespace ciss311_TeamProject
{
    partial class EnrollForm
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
            studentTextbox = new TextBox();
            coursesListbox = new ListBox();
            enrollButton = new Button();
            closeButton = new Button();
            findButton = new Button();
            enrolledListbox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // studentTextbox
            // 
            studentTextbox.Location = new Point(135, 45);
            studentTextbox.Name = "studentTextbox";
            studentTextbox.Size = new Size(121, 23);
            studentTextbox.TabIndex = 0;
            // 
            // coursesListbox
            // 
            coursesListbox.FormattingEnabled = true;
            coursesListbox.ItemHeight = 15;
            coursesListbox.Location = new Point(53, 132);
            coursesListbox.Name = "coursesListbox";
            coursesListbox.Size = new Size(203, 199);
            coursesListbox.TabIndex = 1;
            // 
            // enrollButton
            // 
            enrollButton.Location = new Point(53, 389);
            enrollButton.Name = "enrollButton";
            enrollButton.Size = new Size(75, 23);
            enrollButton.TabIndex = 2;
            enrollButton.Text = "&Enroll";
            enrollButton.UseVisualStyleBackColor = true;
            enrollButton.Click += enrollButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(451, 389);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 3;
            closeButton.Text = "&Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // findButton
            // 
            findButton.Location = new Point(323, 45);
            findButton.Name = "findButton";
            findButton.Size = new Size(75, 23);
            findButton.TabIndex = 4;
            findButton.Text = "&Find";
            findButton.UseVisualStyleBackColor = true;
            findButton.Click += findButton_Click;
            // 
            // enrolledListbox
            // 
            enrolledListbox.FormattingEnabled = true;
            enrolledListbox.ItemHeight = 15;
            enrolledListbox.Location = new Point(323, 132);
            enrolledListbox.Name = "enrolledListbox";
            enrolledListbox.Size = new Size(203, 199);
            enrolledListbox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 48);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 6;
            label1.Text = "Student ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 98);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 7;
            label2.Text = "Courses";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(323, 98);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 8;
            label3.Text = "Enrolled";
            // 
            // EnrollForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(enrolledListbox);
            Controls.Add(findButton);
            Controls.Add(closeButton);
            Controls.Add(enrollButton);
            Controls.Add(coursesListbox);
            Controls.Add(studentTextbox);
            Name = "EnrollForm";
            Text = "EnrollForm";
            Load += EnrollForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox studentTextbox;
        private ListBox coursesListbox;
        private Button enrollButton;
        private Button closeButton;
        private Button findButton;
        private ListBox enrolledListbox;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}