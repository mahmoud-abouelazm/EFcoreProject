using EFcoreProject.Context;
using EFcoreProject.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EFcoreProject.Forms
{
    public partial class EditCourseSessionForm : Form
    {
        private int sessionId;
        private int instructorId;
        private EFContext context;
        private CourseSession session;

        public EditCourseSessionForm(int sessionId, int instructorId)
        {
            InitializeComponent();
            this.sessionId = sessionId;
            this.instructorId = instructorId;
            context = new EFContext();
        }

        private void EditCourseSessionForm_Load(object sender, EventArgs e)
        {
            var courses = context.Courses
                .Where(i => i.InstructorId == instructorId)
                .ToList();
            comboBoxCourse.DataSource = courses;
            comboBoxCourse.DisplayMember = "Name";
            comboBoxCourse.ValueMember = "Id";

            session = context.CourseSessions.Find(sessionId);
            if (session != null)
            {
                txtTitle.Text = session.Title;
                dateTimePicker1.Value = session.Date;
                comboBoxCourse.SelectedValue = session.CourseId;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Please enter a title.");
                return;
            }

            if (session != null)
            {
                session.Title = txtTitle.Text;
                session.Date = dateTimePicker1.Value;
                session.CourseId = (int)comboBoxCourse.SelectedValue;

                context.SaveChanges();

                MessageBox.Show("Course Session updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
