namespace ciss311_TeamProject
{
    partial class ViewStudentsForm
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
            searchTextBox = new TextBox();
            studentGridView = new DataGridView();
            closeButton = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)studentGridView).BeginInit();
            SuspendLayout();
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(192, 75);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(100, 23);
            searchTextBox.TabIndex = 0;
            // 
            // studentGridView
            // 
            studentGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentGridView.Location = new Point(87, 120);
            studentGridView.Name = "studentGridView";
            studentGridView.Size = new Size(523, 232);
            studentGridView.TabIndex = 1;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(91, 387);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 2;
            closeButton.Text = "&Close";
            closeButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 79);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Student:";
            // 
            // ViewStudentsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 450);
            Controls.Add(label1);
            Controls.Add(closeButton);
            Controls.Add(studentGridView);
            Controls.Add(searchTextBox);
            Name = "ViewStudentsForm";
            Text = "ViewStudentsForm";
            ((System.ComponentModel.ISupportInitialize)studentGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchTextBox;
        private DataGridView studentGridView;
        private Button closeButton;
        private Label label1;
    }
}