namespace EFcoreProject.Forms
{
    partial class StudentCourseAssignmentDetails
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
            if (disposing && context != null)
            {
                context.Dispose();
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
            label1 = new Label();
            label2 = new Label();
            studentBox = new ComboBox();
            courseBox = new ComboBox();
            saveBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 62);
            label1.Name = "label1";
            label1.Size = new Size(93, 31);
            label1.TabIndex = 0;
            label1.Text = "Student";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 128);
            label2.Name = "label2";
            label2.Size = new Size(78, 31);
            label2.TabIndex = 1;
            label2.Text = "Course";
            // 
            // studentBox
            // 
            studentBox.DropDownStyle = ComboBoxStyle.DropDownList;
            studentBox.FormattingEnabled = true;
            studentBox.Location = new Point(177, 66);
            studentBox.Name = "studentBox";
            studentBox.Size = new Size(296, 28);
            studentBox.TabIndex = 2;
            // 
            // courseBox
            // 
            courseBox.DropDownStyle = ComboBoxStyle.DropDownList;
            courseBox.FormattingEnabled = true;
            courseBox.Location = new Point(177, 132);
            courseBox.Name = "courseBox";
            courseBox.Size = new Size(296, 28);
            courseBox.TabIndex = 3;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(177, 200);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(206, 45);
            saveBtn.TabIndex = 4;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // StudentCourseAssignmentDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 286);
            Controls.Add(saveBtn);
            Controls.Add(courseBox);
            Controls.Add(studentBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StudentCourseAssignmentDetails";
            Text = "Student Course Assignment";
            Load += StudentCourseAssignmentDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox studentBox;
        private ComboBox courseBox;
        private Button saveBtn;
    }
}
