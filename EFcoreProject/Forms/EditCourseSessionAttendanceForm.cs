using EFcoreProject.Context;
using EFcoreProject.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace EFcoreProject.Forms
{
    public partial class EditCourseSessionAttendanceForm : Form
    {
        private int attendanceId;
        private int instructorId;
        private EFContext context;
        private CourseSessionAttendance attendance;

        public EditCourseSessionAttendanceForm(int attendanceId, int instructorId)
        {
            InitializeComponent();
            this.attendanceId = attendanceId;
            this.instructorId = instructorId;
            context = new EFContext();
        }

        private void EditCourseSessionAttendanceForm_Load(object sender, EventArgs e)
        {
            var sessions = context.CourseSessions
                .Where(s => s.InstructorId == instructorId)
                .ToList();
            comboBoxSession.DataSource = sessions;
            comboBoxSession.DisplayMember = "Title";
            comboBoxSession.ValueMember = "Id";

            var students = context.Students.ToList();
            comboBoxStudent.DataSource = students;
            comboBoxStudent.DisplayMember = "FirstName";
            comboBoxStudent.ValueMember = "Id";

            attendance = context.CourseSessionAttendances.Find(attendanceId);
            if (attendance != null)
            {
                comboBoxSession.SelectedValue = attendance.CourseSessionId;
                comboBoxStudent.SelectedValue = attendance.StudentId;
                numericUpDownGrade.Value = attendance.Grade;
                txtNotes.Text = attendance.Notes;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (attendance != null)
            {
                attendance.CourseSessionId = (int)comboBoxSession.SelectedValue;
                attendance.StudentId = (int)comboBoxStudent.SelectedValue;
                attendance.Grade = (int)numericUpDownGrade.Value;
                attendance.Notes = txtNotes.Text;

                context.SaveChanges();

                MessageBox.Show("Attendance updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
