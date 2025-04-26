
namespace ciss311_TeamProject
{
    partial class ViewCoursesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewCourses;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewCourses = new DataGridView();
            textBoxSearch = new TextBox();
            labelSearch = new Label();
            closeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCourses
            // 
            dataGridViewCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCourses.Location = new Point(10, 38);
            dataGridViewCourses.Margin = new Padding(3, 2, 3, 2);
            dataGridViewCourses.Name = "dataGridViewCourses";
            dataGridViewCourses.RowHeadersWidth = 51;
            dataGridViewCourses.RowTemplate.Height = 29;
            dataGridViewCourses.Size = new Size(679, 254);
            dataGridViewCourses.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(66, 9);
            textBoxSearch.Margin = new Padding(3, 2, 3, 2);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(624, 23);
            textBoxSearch.TabIndex = 1;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(10, 11);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(45, 15);
            labelSearch.TabIndex = 2;
            labelSearch.Text = "Search:";
            // 
            // closeButton
            // 
            closeButton.Location = new Point(22, 303);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 3;
            closeButton.Text = "&Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // ViewCoursesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(closeButton);
            Controls.Add(labelSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(dataGridViewCourses);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ViewCoursesForm";
            Text = "View Courses";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button closeButton;
    }
}