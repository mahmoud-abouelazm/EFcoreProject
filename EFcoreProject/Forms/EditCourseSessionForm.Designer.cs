namespace EFcoreProject.Forms
{
    partial class EditCourseSessionForm
    {
        private System.ComponentModel.IContainer components = null;

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

        private void InitializeComponent()
        {
            lblTitle = new System.Windows.Forms.Label();
            txtTitle = new System.Windows.Forms.TextBox();
            lblDate = new System.Windows.Forms.Label();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            lblCourse = new System.Windows.Forms.Label();
            comboBoxCourse = new System.Windows.Forms.ComboBox();
            btnSave = new System.Windows.Forms.Button();
            SuspendLayout();
            
            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblTitle.Location = new System.Drawing.Point(58, 50);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(58, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title";
            
            // txtTitle
            txtTitle.Location = new System.Drawing.Point(206, 54);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new System.Drawing.Size(284, 27);
            txtTitle.TabIndex = 1;
            
            // lblDate
            lblDate.AutoSize = true;
            lblDate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblDate.Location = new System.Drawing.Point(58, 106);
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(62, 31);
            lblDate.TabIndex = 2;
            lblDate.Text = "Date";
            
            // dateTimePicker1
            dateTimePicker1.Location = new System.Drawing.Point(206, 111);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(284, 27);
            dateTimePicker1.TabIndex = 3;
            
            // lblCourse
            lblCourse.AutoSize = true;
            lblCourse.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblCourse.Location = new System.Drawing.Point(58, 175);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new System.Drawing.Size(85, 31);
            lblCourse.TabIndex = 4;
            lblCourse.Text = "Course";
            
            // comboBoxCourse
            comboBoxCourse.FormattingEnabled = true;
            comboBoxCourse.Location = new System.Drawing.Point(206, 179);
            comboBoxCourse.Name = "comboBoxCourse";
            comboBoxCourse.Size = new System.Drawing.Size(284, 28);
            comboBoxCourse.TabIndex = 5;
            
            // btnSave
            btnSave.Location = new System.Drawing.Point(134, 260);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(228, 44);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            
            // EditCourseSessionForm
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(558, 370);
            Controls.Add(btnSave);
            Controls.Add(comboBoxCourse);
            Controls.Add(lblCourse);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblDate);
            Controls.Add(txtTitle);
            Controls.Add(lblTitle);
            Name = "EditCourseSessionForm";
            Text = "Edit Course Session";
            Load += EditCourseSessionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.Button btnSave;
    }
}
