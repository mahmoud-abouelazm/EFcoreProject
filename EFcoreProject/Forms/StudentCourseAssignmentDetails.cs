using EFcoreProject.Context;
using EFcoreProject.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EFcoreProject.Forms
{
    public partial class StudentCourseAssignmentDetails : Form
    {
        private readonly int deptId;
        private readonly int? oldStudentId;
        private readonly int? oldCourseId;
        private readonly EFContext context;

        public StudentCourseAssignmentDetails(int deptId, int? oldStudentId = null, int? oldCourseId = null)
        {
            InitializeComponent();
            this.deptId = deptId;
            this.oldStudentId = oldStudentId;
            this.oldCourseId = oldCourseId;
            context = new EFContext();
        }

        private void StudentCourseAssignmentDetails_Load(object sender, EventArgs e)
        {
            var students = context.Students
                .Select(s => new
                {
                    s.Id,
                    FullName = s.FirstName + " " + s.LastName
                })
                .ToList();

            var courses = context.Courses
                .Where(c => c.DepartmentId == deptId)
                .Select(c => new
                {
                    c.Id,
                    c.Name
                })
                .ToList();

            studentBox.DataSource = students;
            studentBox.DisplayMember = "FullName";
            studentBox.ValueMember = "Id";

            courseBox.DataSource = courses;
            courseBox.DisplayMember = "Name";
            courseBox.ValueMember = "Id";

            if (oldStudentId != null && oldCourseId != null)
            {
                Text = "Update Assignment";
                studentBox.SelectedValue = oldStudentId.Value;
                courseBox.SelectedValue = oldCourseId.Value;
            }
            else
            {
                Text = "Add Assignment";
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (studentBox.SelectedValue == null || courseBox.SelectedValue == null)
            {
                MessageBox.Show("Please select student and course.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newStudentId = Convert.ToInt32(studentBox.SelectedValue);
            var newCourseId = Convert.ToInt32(courseBox.SelectedValue);

            if (oldStudentId == null || oldCourseId == null)
            {
                var exists = context.StudentCourses.Any(sc => sc.StudentId == newStudentId && sc.CourseId == newCourseId);
                if (exists)
                {
                    MessageBox.Show("This assignment already exists.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                context.StudentCourses.Add(new StudentCourse
                {
                    StudentId = newStudentId,
                    CourseId = newCourseId
                });
            }
            else
            {
                if (oldStudentId.Value == newStudentId && oldCourseId.Value == newCourseId)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                    return;
                }

                var exists = context.StudentCourses.Any(sc => sc.StudentId == newStudentId && sc.CourseId == newCourseId);
                if (exists)
                {
                    MessageBox.Show("This assignment already exists.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var oldRecord = context.StudentCourses.Find(oldStudentId.Value, oldCourseId.Value);
                if (oldRecord == null)
                {
                    MessageBox.Show("Assignment not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                context.StudentCourses.Remove(oldRecord);
                context.StudentCourses.Add(new StudentCourse
                {
                    StudentId = newStudentId,
                    CourseId = newCourseId
                });
            }

            context.SaveChanges();
            MessageBox.Show("Assignment saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
