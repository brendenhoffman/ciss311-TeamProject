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
            SuspendLayout();
            // 
            // addStudentButton
            // 
            addStudentButton.Location = new Point(167, 521);
            addStudentButton.Name = "addStudentButton";
            addStudentButton.Size = new Size(218, 46);
            addStudentButton.TabIndex = 0;
            addStudentButton.Text = "Add Student";
            addStudentButton.UseVisualStyleBackColor = true;
            addStudentButton.Click += addStudentButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(534, 521);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(202, 46);
            closeButton.TabIndex = 1;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // studentTextBox
            // 
            studentTextBox.Location = new Point(357, 216);
            studentTextBox.Name = "studentTextBox";
            studentTextBox.Size = new Size(436, 39);
            studentTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 216);
            label1.Name = "label1";
            label1.Size = new Size(223, 32);
            label1.TabIndex = 3;
            label1.Text = "New Student Name";
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 710);
            Controls.Add(label1);
            Controls.Add(studentTextBox);
            Controls.Add(closeButton);
            Controls.Add(addStudentButton);
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
    }
}