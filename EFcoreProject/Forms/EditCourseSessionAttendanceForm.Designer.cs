namespace EFcoreProject.Forms
{
    partial class EditCourseSessionAttendanceForm
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
            lblSession = new System.Windows.Forms.Label();
            comboBoxSession = new System.Windows.Forms.ComboBox();
            lblStudent = new System.Windows.Forms.Label();
            comboBoxStudent = new System.Windows.Forms.ComboBox();
            lblGrade = new System.Windows.Forms.Label();
            numericUpDownGrade = new System.Windows.Forms.NumericUpDown();
            lblNotes = new System.Windows.Forms.Label();
            txtNotes = new System.Windows.Forms.TextBox();
            btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGrade).BeginInit();
            SuspendLayout();
            
            // lblSession
            lblSession.AutoSize = true;
            lblSession.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblSession.Location = new System.Drawing.Point(58, 50);
            lblSession.Name = "lblSession";
            lblSession.Size = new System.Drawing.Size(90, 31);
            lblSession.TabIndex = 0;
            lblSession.Text = "Session";
            
            // comboBoxSession
            comboBoxSession.FormattingEnabled = true;
            comboBoxSession.Location = new System.Drawing.Point(206, 54);
            comboBoxSession.Name = "comboBoxSession";
            comboBoxSession.Size = new System.Drawing.Size(284, 28);
            comboBoxSession.TabIndex = 1;
            
            // lblStudent
            lblStudent.AutoSize = true;
            lblStudent.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblStudent.Location = new System.Drawing.Point(58, 106);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new System.Drawing.Size(93, 31);
            lblStudent.TabIndex = 2;
            lblStudent.Text = "Student";
            
            // comboBoxStudent
            comboBoxStudent.FormattingEnabled = true;
            comboBoxStudent.Location = new System.Drawing.Point(206, 110);
            comboBoxStudent.Name = "comboBoxStudent";
            comboBoxStudent.Size = new System.Drawing.Size(284, 28);
            comboBoxStudent.TabIndex = 3;
            
            // lblGrade
            lblGrade.AutoSize = true;
            lblGrade.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblGrade.Location = new System.Drawing.Point(58, 162);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new System.Drawing.Size(76, 31);
            lblGrade.TabIndex = 4;
            lblGrade.Text = "Grade";
            
            // numericUpDownGrade
            numericUpDownGrade.Location = new System.Drawing.Point(206, 167);
            numericUpDownGrade.Name = "numericUpDownGrade";
            numericUpDownGrade.Size = new System.Drawing.Size(284, 27);
            numericUpDownGrade.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDownGrade.TabIndex = 5;
            
            // lblNotes
            lblNotes.AutoSize = true;
            lblNotes.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblNotes.Location = new System.Drawing.Point(58, 218);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new System.Drawing.Size(75, 31);
            lblNotes.TabIndex = 6;
            lblNotes.Text = "Notes";
            
            // txtNotes
            txtNotes.Location = new System.Drawing.Point(206, 222);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new System.Drawing.Size(284, 27);
            txtNotes.TabIndex = 7;
            
            // btnSave
            btnSave.Location = new System.Drawing.Point(134, 290);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(228, 44);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            
            // EditCourseSessionAttendanceForm
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(558, 390);
            Controls.Add(btnSave);
            Controls.Add(txtNotes);
            Controls.Add(lblNotes);
            Controls.Add(numericUpDownGrade);
            Controls.Add(lblGrade);
            Controls.Add(comboBoxStudent);
            Controls.Add(lblStudent);
            Controls.Add(comboBoxSession);
            Controls.Add(lblSession);
            Name = "EditCourseSessionAttendanceForm";
            Text = "Edit Course Session Attendance";
            Load += EditCourseSessionAttendanceForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownGrade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblSession;
        private System.Windows.Forms.ComboBox comboBoxSession;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.ComboBox comboBoxStudent;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.NumericUpDown numericUpDownGrade;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnSave;
    }
}
