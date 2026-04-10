using EFcoreProject.Context;
using EFcoreProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EFcoreProject.Forms
{
    public partial class DepartmentStudentCoursesForm : Form
    {
        private readonly int deptId;
        private readonly EFContext context;

        public DepartmentStudentCoursesForm(int deptId)
        {
            InitializeComponent();
            this.deptId = deptId;
            context = new EFContext();
        }

        private async void DepartmentStudentCoursesForm_Load(object sender, EventArgs e)
        {
            var department = await context.Departments.FindAsync(deptId);
            if (department == null)
            {
                MessageBox.Show("Department not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            Text = $"Students Assigned To Courses - {department.Name}";
            LoadAssignments();
        }

        private void LoadAssignments()
        {
            context.ChangeTracker.Clear();

            var assignments = context.StudentCourses
                .AsNoTracking()
                .Include(sc => sc.Student)
                .Include(sc => sc.Course)
                .Where(sc => sc.Course.DepartmentId == deptId)
                .Select(sc => new
                {
                    sc.StudentId,
                    StudentName = sc.Student.FirstName + " " + sc.Student.LastName,
                    sc.CourseId,
                    CourseName = sc.Course.Name
                })
                .ToList();

            assignmentsGrid.DataSource = assignments;
        }

        private (int StudentId, int CourseId)? GetSelectedKey()
        {
            if (assignmentsGrid.CurrentRow == null)
            {
                return null;
            }

            var studentCell = assignmentsGrid.CurrentRow.Cells["StudentId"].Value;
            var courseCell = assignmentsGrid.CurrentRow.Cells["CourseId"].Value;
            if (studentCell == null || courseCell == null)
            {
                return null;
            }

            return (Convert.ToInt32(studentCell), Convert.ToInt32(courseCell));
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            StudentCourseAssignmentDetails form = new(deptId);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadAssignments();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedKey();
            if (selected == null)
            {
                MessageBox.Show("Please select a row to update.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            StudentCourseAssignmentDetails form = new(deptId, selected.Value.StudentId, selected.Value.CourseId);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadAssignments();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedKey();
            if (selected == null)
            {
                MessageBox.Show("Please select a row to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show("Delete selected assignment?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                return;
            }

            var record = context.StudentCourses.Find(selected.Value.StudentId, selected.Value.CourseId);
            if (record == null)
            {
                MessageBox.Show("Assignment not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            context.StudentCourses.Remove(record);
            context.SaveChanges();
            MessageBox.Show("Assignment deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadAssignments();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
