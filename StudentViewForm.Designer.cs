namespace ciss311_TeamProject
{
    partial class StudentViewForm
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
            courseComboBox = new ComboBox();
            studentListBox = new ListBox();
            studentCountLabel = new Label();
            closeButton = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // courseComboBox
            // 
            courseComboBox.FormattingEnabled = true;
            courseComboBox.Location = new Point(141, 56);
            courseComboBox.Name = "courseComboBox";
            courseComboBox.Size = new Size(121, 23);
            courseComboBox.TabIndex = 0;
            courseComboBox.SelectedIndexChanged += courseComboBox_SelectedIndexChanged;
            // 
            // studentListBox
            // 
            studentListBox.FormattingEnabled = true;
            studentListBox.ItemHeight = 15;
            studentListBox.Location = new Point(80, 134);
            studentListBox.Name = "studentListBox";
            studentListBox.Size = new Size(266, 154);
            studentListBox.TabIndex = 1;
            // 
            // studentCountLabel
            // 
            studentCountLabel.AutoSize = true;
            studentCountLabel.Location = new Point(89, 301);
            studentCountLabel.Name = "studentCountLabel";
            studentCountLabel.Size = new Size(108, 15);
            studentCountLabel.TabIndex = 2;
            studentCountLabel.Text = "studentCountLabel";
            // 
            // closeButton
            // 
            closeButton.Location = new Point(271, 364);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 3;
            closeButton.Text = "&Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 59);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 4;
            label2.Text = "Course:";
            // 
            // StudentViewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 450);
            Controls.Add(label2);
            Controls.Add(closeButton);
            Controls.Add(studentCountLabel);
            Controls.Add(studentListBox);
            Controls.Add(courseComboBox);
            Name = "StudentViewForm";
            Text = "StudentViewForm";
            Load += StudentViewForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox courseComboBox;
        private ListBox studentListBox;
        private Label studentCountLabel;
        private Button closeButton;
        private Label label2;
    }
}