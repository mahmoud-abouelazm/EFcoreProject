using EFcoreProject.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EFcoreProject.Forms
{
    public partial class ManageInstructorsForm : Form
    {
        private readonly EFContext context;

        public ManageInstructorsForm()
        {
            InitializeComponent();
            context = new EFContext();
        }

        private void ManageInstructorsForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var data = context.Instructors
                .AsNoTracking()
                .Include(i => i.Department)
                .Select(i => new
                {
                    i.ID,
                    i.FirstName,
                    i.LastName,
                    i.Phone,
                    Department = i.Department != null ? i.Department.Name : "-"
                })
                .ToList();

            instructorsGrid.DataSource = data;
        }

        private int? GetSelectedInstructorId()
        {
            if (instructorsGrid.CurrentRow == null || instructorsGrid.CurrentRow.Cells["ID"].Value == null)
            {
                return null;
            }

            return Convert.ToInt32(instructorsGrid.CurrentRow.Cells["ID"].Value);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            InstructorAdminDetailsForm form = new();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            var id = GetSelectedInstructorId();
            if (id == null)
            {
                MessageBox.Show("Please select an instructor to update.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            InstructorAdminDetailsForm form = new(id.Value);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var id = GetSelectedInstructorId();
            if (id == null)
            {
                MessageBox.Show("Please select an instructor to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show("Delete selected instructor?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                return;
            }

            var instructor = context.Instructors.Find(id.Value);
            if (instructor == null)
            {
                MessageBox.Show("Instructor not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                context.Instructors.Remove(instructor);
                context.SaveChanges();
                MessageBox.Show("Instructor deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (DbUpdateException)
            {
                MessageBox.Show("Cannot delete this instructor because it has related data.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
