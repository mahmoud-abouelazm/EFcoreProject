using EFcoreProject.Context;
using EFcoreProject.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace EFcoreProject.Forms
{
    public partial class AddCourseSessionAttendanceForm : Form
    {
        private int instructorId;
        private EFContext context;
        List<CourseSession> sessions;

        public AddCourseSessionAttendanceForm(int instructorId)
        {
            InitializeComponent();
            this.instructorId = instructorId;
            context = new EFContext();
            
        }

        private void AddCourseSessionAttendanceForm_Load(object sender, EventArgs e)
        {
            sessions = context.CourseSessions
                .Where(s => s.InstructorId == instructorId)
                .ToList();
            comboBoxSession.DataSource = sessions;
            comboBoxSession.DisplayMember = "Title";
            comboBoxSession.ValueMember = "Id";

            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (comboBoxSession.SelectedValue == null || comboBoxStudent.SelectedValue == null)
            {
                MessageBox.Show("Please select a session and a student.");
                return;
            }

            int grade = (int)numericUpDownGrade.Value;

            var attendance = new CourseSessionAttendance
            {
                CourseSessionId = (int)comboBoxSession.SelectedValue,
                StudentId = (int)comboBoxStudent.SelectedValue,
                Grade = grade,
                Notes = txtNotes.Text
            };

            context.CourseSessionAttendances.Add(attendance);
            context.SaveChanges();

            MessageBox.Show("Attendance added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void comboBoxSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSession.SelectedItem is CourseSession selectedSession)
            {
                int courseId = selectedSession.CourseId;
                var students = context.Students
                    .Include(s=>s.Courses)
                    .Where(s => s.Courses.Any(c => c.CourseId == courseId))
                    .ToList();
                comboBoxStudent.DataSource = students;
                comboBoxStudent.DisplayMember = "FirstName";
                comboBoxStudent.ValueMember = "Id";
            }
        }
    }
}
