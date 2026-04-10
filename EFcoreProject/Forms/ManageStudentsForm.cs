using EFcoreProject.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EFcoreProject.Forms
{
    public partial class ManageStudentsForm : Form
    {
        private readonly EFContext context;

        public ManageStudentsForm()
        {
            InitializeComponent();
            context = new EFContext();
        }

        private void ManageStudentsForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var data = context.Students
                .AsNoTracking()
                .Select(s => new
                {
                    s.Id,
                    s.FirstName,
                    s.LastName,
                    s.Phone
                })
                .ToList();

            studentsGrid.DataSource = data;
        }

        private int? GetSelectedStudentId()
        {
            if (studentsGrid.CurrentRow == null || studentsGrid.CurrentRow.Cells["Id"].Value == null)
            {
                return null;
            }

            return Convert.ToInt32(studentsGrid.CurrentRow.Cells["Id"].Value);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            StudentAdminDetailsForm form = new();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            var id = GetSelectedStudentId();
            if (id == null)
            {
                MessageBox.Show("Please select a student to update.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            StudentAdminDetailsForm form = new(id.Value);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var id = GetSelectedStudentId();
            if (id == null)
            {
                MessageBox.Show("Please select a student to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show("Delete selected student?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                return;
            }

            var student = context.Students.Find(id.Value);
            if (student == null)
            {
                MessageBox.Show("Student not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                context.Students.Remove(student);
                context.SaveChanges();
                MessageBox.Show("Student deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (DbUpdateException)
            {
                MessageBox.Show("Cannot delete this student because it has related data.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
