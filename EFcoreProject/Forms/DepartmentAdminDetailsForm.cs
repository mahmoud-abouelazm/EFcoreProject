using EFcoreProject.Context;
using EFcoreProject.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EFcoreProject.Forms
{
    public partial class DepartmentAdminDetailsForm : Form
    {
        private readonly int? departmentId;
        private readonly EFContext context;

        public DepartmentAdminDetailsForm(int? departmentId = null)
        {
            InitializeComponent();
            this.departmentId = departmentId;
            context = new EFContext();
        }

        private void DepartmentAdminDetailsForm_Load(object sender, EventArgs e)
        {
            if (departmentId == null)
            {
                Text = "Add Department";
                return;
            }

            Text = "Update Department";
            var department = context.Departments.FirstOrDefault(d => d.Id == departmentId.Value);
            if (department == null)
            {
                MessageBox.Show("Department not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            idBox.Text = department.Id.ToString();
            nameBox.Text = department.Name;
            locationBox.Text = department.Location;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameBox.Text) || string.IsNullOrWhiteSpace(locationBox.Text))
            {
                MessageBox.Show("Name and location are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (departmentId == null)
            {
                Department department = new()
                {
                    Name = nameBox.Text.Trim(),
                    Location = locationBox.Text.Trim()
                };

                context.Departments.Add(department);
            }
            else
            {
                var department = context.Departments.FirstOrDefault(d => d.Id == departmentId.Value);
                if (department == null)
                {
                    MessageBox.Show("Department not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                department.Name = nameBox.Text.Trim();
                department.Location = locationBox.Text.Trim();
            }

            context.SaveChanges();
            MessageBox.Show("Department saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
