using EFcoreProject.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EFcoreProject.Forms
{
    public partial class ManageDepartmentsForm : Form
    {
        private readonly EFContext context;

        public ManageDepartmentsForm()
        {
            InitializeComponent();
            context = new EFContext();
        }

        private void ManageDepartmentsForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var data = context.Departments
                .AsNoTracking()
                .Select(d => new
                {
                    d.Id,
                    d.Name,
                    d.Location,
                    d.ManagerId
                })
                .ToList();

            departmentsGrid.DataSource = data;
        }

        private int? GetSelectedDepartmentId()
        {
            if (departmentsGrid.CurrentRow == null || departmentsGrid.CurrentRow.Cells["Id"].Value == null)
            {
                return null;
            }

            return Convert.ToInt32(departmentsGrid.CurrentRow.Cells["Id"].Value);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            DepartmentAdminDetailsForm form = new();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            var id = GetSelectedDepartmentId();
            if (id == null)
            {
                MessageBox.Show("Please select a department to update.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DepartmentAdminDetailsForm form = new(id.Value);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var id = GetSelectedDepartmentId();
            if (id == null)
            {
                MessageBox.Show("Please select a department to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show("Delete selected department?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
            {
                return;
            }

            var department = context.Departments.Find(id.Value);
            if (department == null)
            {
                MessageBox.Show("Department not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                context.Departments.Remove(department);
                context.SaveChanges();
                MessageBox.Show("Department deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (DbUpdateException)
            {
                MessageBox.Show("Cannot delete this department because it has related data.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
