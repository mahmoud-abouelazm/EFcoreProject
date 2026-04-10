using EFcoreProject.Context;
using EFcoreProject.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EFcoreProject.Forms
{
    public partial class AddCourseSessionForm : Form
    {
        private int instructorId;
        private EFContext context;

        public AddCourseSessionForm(int instructorId)
        {
            InitializeComponent();
            this.instructorId = instructorId;
            context = new EFContext();
        }

        private void AddCourseSessionForm_Load(object sender, EventArgs e)
        {
            var courses = context.Courses
                .Where(i=>i.InstructorId == instructorId)
                .ToList();
            comboBoxCourse.DataSource = courses;
            comboBoxCourse.DisplayMember = "Name";
            comboBoxCourse.ValueMember = "Id";

            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Please enter a title.");
                return;
            }

            var session = new CourseSession
            {
                Title = txtTitle.Text,
                Date = dateTimePicker1.Value,
                InstructorId = instructorId,
                CourseId = (int)comboBoxCourse.SelectedValue
            };

            context.CourseSessions.Add(session);
            context.SaveChanges();

            MessageBox.Show("Course Session added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
