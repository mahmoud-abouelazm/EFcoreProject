namespace EFcoreProject
{
    partial class InstructorForm
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
            label1 = new Label();
            lblInstructorName = new Label();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            courseSessionAttendance = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(108, 31);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // lblInstructorName
            // 
            lblInstructorName.AutoSize = true;
            lblInstructorName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstructorName.Location = new Point(126, 9);
            lblInstructorName.Name = "lblInstructorName";
            lblInstructorName.Size = new Size(131, 31);
            lblInstructorName.TabIndex = 1;
            lblInstructorName.Text = "-------------";
            lblInstructorName.Click += label2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(21, 133);
            button1.Name = "button1";
            button1.Size = new Size(139, 54);
            button1.TabIndex = 2;
            button1.Text = "Courses";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(422, 133);
            button2.Name = "button2";
            button2.Size = new Size(216, 54);
            button2.TabIndex = 3;
            button2.Text = "instructor details";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(189, 133);
            button4.Name = "button4";
            button4.Size = new Size(198, 54);
            button4.TabIndex = 5;
            button4.Text = "Course sessions";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // courseSessionAttendance
            // 
            courseSessionAttendance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courseSessionAttendance.Location = new Point(97, 208);
            courseSessionAttendance.Name = "courseSessionAttendance";
            courseSessionAttendance.Size = new Size(420, 54);
            courseSessionAttendance.TabIndex = 6;
            courseSessionAttendance.Text = "Course sessions Attendance";
            courseSessionAttendance.UseVisualStyleBackColor = true;
            courseSessionAttendance.Click += courseSessionAttendance_Click;
            // 
            // InstructorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 274);
            Controls.Add(courseSessionAttendance);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblInstructorName);
            Controls.Add(label1);
            Name = "InstructorForm";
            Text = "Instructor";
            Load += InstructorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblInstructorName;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button courseSessionAttendance;
    }
}