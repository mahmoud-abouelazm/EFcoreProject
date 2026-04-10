using EFcoreProject.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EFcoreProject.Forms
{
    public partial class DepartmentDetails : Form
    {
        private readonly int deptId;
        private readonly EFContext context;

        public DepartmentDetails(int deptId)
        {
            InitializeComponent();
            this.deptId = deptId;
            context = new EFContext();

            AddBtn.Click += AddBtn_Click;
            updateBtn.Click += updateBtn_Click;
            deleteBtn.Click += deleteBtn_Click;
            deptInfoEdit.Click += deptInfoEdit_Click;
            assignStudentBtn.Click += assignStudentBtn_Click;
        }

        private async void DepartmentDetails_Load(object? sender, EventArgs e)
        {
            var department = await context.Departments.FindAsync(deptId);
            if (department == null)
            {
                MessageBox.Show("Department not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            Text = $"Department Details - {department.Name}";
            LoadCourses();
        }

        private void LoadCourses()
        {
            var courses = context.Courses
                .AsNoTracking()
                .Include(c => c.Instructor)
                .Where(c => c.DepartmentId == deptId)
                .Select(c => new
                {
                    c.Id,
                    c.Name,
                    c.Duration,
                    Instructor = c.Instructor != null
                        ? c.Instructor.FirstName + " " + c.Instructor.LastName
                        : "-"
                })
                .ToList();

            Courses.DataSource = courses;
        }

        private int? GetSelectedCourseId()
        {
            if (Courses.CurrentRow == null || Courses.CurrentRow.Cells["Id"].Value == null)
            {
                return null;
            }

            return Convert.ToInt32(Courses.CurrentRow.Cells["Id"].Value);
        }

        private void AddBtn_Click(object? sender, EventArgs e)
        {
            CourseDetails addCourseForm = new(deptId);
            if (addCourseForm.ShowDialog() == DialogResult.OK)
            {
                LoadCourses();
            }
        }

        private void updateBtn_Click(object? sender, EventArgs e)
        {
            var selectedCourseId = GetSelectedCourseId();
            if (selectedCourseId == null)
            {
                MessageBox.Show("Please select a course to update.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            CourseDetails editCourseForm = new(deptId, selectedCourseId.Value);
            if (editCourseForm.ShowDialog() == DialogResult.OK)
            {
                LoadCourses();
            }
        }

        private void deleteBtn_Click(object? sender, EventArgs e)
        {
            var selectedCourseId = GetSelectedCourseId();
            if (selectedCourseId == null)
            {
                MessageBox.Show("Please select a course to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this course?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                return;
            }

            var course = context.Courses.Find(selectedCourseId.Value);
            if (course == null)
            {
                MessageBox.Show("Course not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            context.Courses.Remove(course);
            context.SaveChanges();
            MessageBox.Show("Course deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadCourses();
        }

        private void deptInfoEdit_Click(object? sender, EventArgs e)
        {
            DepartmentInfoDetails departmentInfoForm = new(deptId);
            if (departmentInfoForm.ShowDialog() == DialogResult.OK)
            {
                LoadCourses();
            }
        }

        private void assignStudentBtn_Click(object? sender, EventArgs e)
        {
            DepartmentStudentCoursesForm studentCoursesForm = new(deptId);
            studentCoursesForm.ShowDialog();
        }

    }
}
