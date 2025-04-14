namespace ciss311_TeamProject
{
    partial class AddStudent
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
            addStudentButton = new Button();
            closeButton = new Button();
            studentTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            studentIdTextBox = new TextBox();
            SuspendLayout();
            // 
            // addStudentButton
            // 
            addStudentButton.Location = new Point(90, 244);
            addStudentButton.Margin = new Padding(2, 1, 2, 1);
            addStudentButton.Name = "addStudentButton";
            addStudentButton.Size = new Size(117, 22);
            addStudentButton.TabIndex = 0;
            addStudentButton.Text = "Add Student";
            addStudentButton.UseVisualStyleBackColor = true;
            addStudentButton.Click += addStudentButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(320, 244);
            closeButton.Margin = new Padding(2, 1, 2, 1);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(109, 22);
            closeButton.TabIndex = 1;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // studentTextBox
            // 
            studentTextBox.Location = new Point(192, 101);
            studentTextBox.Margin = new Padding(2, 1, 2, 1);
            studentTextBox.Name = "studentTextBox";
            studentTextBox.Size = new Size(237, 23);
            studentTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 104);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 3;
            label1.Text = "New Student Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 67);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 4;
            label2.Text = "Student ID:";
            // 
            // studentIdTextBox
            // 
            studentIdTextBox.Location = new Point(192, 64);
            studentIdTextBox.Name = "studentIdTextBox";
            studentIdTextBox.Size = new Size(237, 23);
            studentIdTextBox.TabIndex = 5;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 333);
            Controls.Add(studentIdTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(studentTextBox);
            Controls.Add(closeButton);
            Controls.Add(addStudentButton);
            Margin = new Padding(2, 1, 2, 1);
            Name = "AddStudent";
            Text = "AddStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addStudentButton;
        private Button closeButton;
        private TextBox studentTextBox;
        private Label label1;
        private Label label2;
        private TextBox studentIdTextBox;
    }
}