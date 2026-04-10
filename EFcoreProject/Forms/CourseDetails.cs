using EFcoreProject.Context;
using EFcoreProject.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EFcoreProject.Forms
{
    public partial class CourseDetails : Form
    {
        private readonly int deptId;
        private readonly int? courseId;
        private readonly EFContext context;

        private class InstructorItem
        {
            public int ID { get; set; }
            public string FullName { get; set; }
        }

        public CourseDetails(int deptId, int? courseId = null)
        {
            InitializeComponent();
            this.deptId = deptId;
            this.courseId = courseId;
            context = new EFContext();
        }

        private void CourseDetails_Load(object sender, EventArgs e)
        {
            var instructors = context.Instructors
                .Where(i => i.DepartmentId == deptId)
                .Select(i => new InstructorItem
                {
                    ID = i.ID,
                    FullName = i.FirstName + " " + i.LastName
                })
                .ToList();

            instructors.Insert(0, new InstructorItem { ID = 0, FullName = "No Instructor" });
            instructorBox.DataSource = instructors;
            instructorBox.DisplayMember = "FullName";
            instructorBox.ValueMember = "ID";

            if (courseId == null)
            {
                Text = "Add Course";
                instructorBox.SelectedValue = 0;
                return;
            }

            Text = "Edit Course";
            var course = context.Courses.FirstOrDefault(c => c.Id == courseId && c.DepartmentId == deptId);
            if (course == null)
            {
                MessageBox.Show("Course not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            IdBox.Text = course.Id.ToString();
            nameBox.Text = course.Name;
            durationBox.Value = course.Duration;
            instructorBox.SelectedValue = course.InstructorId ?? 0;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameBox.Text))
            {
                MessageBox.Show("Please enter course name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (courseId == null)
            {
                Course course = new()
                {
                    Name = nameBox.Text.Trim(),
                    Duration = (int)durationBox.Value,
                    DepartmentId = deptId,
                    InstructorId = instructorBox.SelectedValue != null && Convert.ToInt32(instructorBox.SelectedValue) != 0
                        ? Convert.ToInt32(instructorBox.SelectedValue)
                        : null
                };

                context.Courses.Add(course);
            }
            else
            {
                var course = context.Courses.FirstOrDefault(c => c.Id == courseId && c.DepartmentId == deptId);
                if (course == null)
                {
                    MessageBox.Show("Course not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                course.Name = nameBox.Text.Trim();
                course.Duration = (int)durationBox.Value;
                course.InstructorId = instructorBox.SelectedValue != null && Convert.ToInt32(instructorBox.SelectedValue) != 0
                    ? Convert.ToInt32(instructorBox.SelectedValue)
                    : null;
            }

            context.SaveChanges();
            MessageBox.Show("Course saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
