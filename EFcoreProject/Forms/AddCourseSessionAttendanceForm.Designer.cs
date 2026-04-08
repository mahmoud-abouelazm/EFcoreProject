namespace EFcoreProject.Forms
{
    partial class AddCourseSessionAttendanceForm
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
            lblSession = new Label();
            comboBoxSession = new ComboBox();
            lblStudent = new Label();
            comboBoxStudent = new ComboBox();
            lblGrade = new Label();
            numericUpDownGrade = new NumericUpDown();
            lblNotes = new Label();
            txtNotes = new TextBox();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGrade).BeginInit();
            SuspendLayout();
            // 
            // lblSession
            // 
            lblSession.AutoSize = true;
            lblSession.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSession.Location = new Point(58, 50);
            lblSession.Name = "lblSession";
            lblSession.Size = new Size(90, 31);
            lblSession.TabIndex = 0;
            lblSession.Text = "Session";
            // 
            // comboBoxSession
            // 
            comboBoxSession.FormattingEnabled = true;
            comboBoxSession.Location = new Point(206, 54);
            comboBoxSession.Name = "comboBoxSession";
            comboBoxSession.Size = new Size(284, 28);
            comboBoxSession.TabIndex = 1;
            comboBoxSession.SelectedIndexChanged += comboBoxSession_SelectedIndexChanged;
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudent.Location = new Point(58, 106);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(93, 31);
            lblStudent.TabIndex = 2;
            lblStudent.Text = "Student";
            // 
            // comboBoxStudent
            // 
            comboBoxStudent.FormattingEnabled = true;
            comboBoxStudent.Location = new Point(206, 110);
            comboBoxStudent.Name = "comboBoxStudent";
            comboBoxStudent.Size = new Size(284, 28);
            comboBoxStudent.TabIndex = 3;
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrade.Location = new Point(58, 162);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(76, 31);
            lblGrade.TabIndex = 4;
            lblGrade.Text = "Grade";
            // 
            // numericUpDownGrade
            // 
            numericUpDownGrade.Location = new Point(206, 167);
            numericUpDownGrade.Name = "numericUpDownGrade";
            numericUpDownGrade.Size = new Size(284, 27);
            numericUpDownGrade.TabIndex = 5;
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNotes.Location = new Point(58, 218);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(74, 31);
            lblNotes.TabIndex = 6;
            lblNotes.Text = "Notes";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(206, 222);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(284, 27);
            txtNotes.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(134, 290);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(228, 44);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // AddCourseSessionAttendanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 390);
            Controls.Add(btnSave);
            Controls.Add(txtNotes);
            Controls.Add(lblNotes);
            Controls.Add(numericUpDownGrade);
            Controls.Add(lblGrade);
            Controls.Add(comboBoxStudent);
            Controls.Add(lblStudent);
            Controls.Add(comboBoxSession);
            Controls.Add(lblSession);
            Name = "AddCourseSessionAttendanceForm";
            Text = "Add Course Session Attendance";
            Load += AddCourseSessionAttendanceForm_Load;
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
