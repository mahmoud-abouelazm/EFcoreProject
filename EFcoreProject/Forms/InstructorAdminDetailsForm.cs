using EFcoreProject.Context;
using EFcoreProject.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EFcoreProject.Forms
{
    public partial class InstructorAdminDetailsForm : Form
    {
        private readonly int? instructorId;
        private readonly EFContext context;

        public InstructorAdminDetailsForm(int? instructorId = null)
        {
            InitializeComponent();
            this.instructorId = instructorId;
            context = new EFContext();
        }

        private void InstructorAdminDetailsForm_Load(object sender, EventArgs e)
        {
            var departments = context.Departments
                .Select(d => new { d.Id, d.Name })
                .ToList();

            departmentBox.DataSource = departments;
            departmentBox.DisplayMember = "Name";
            departmentBox.ValueMember = "Id";

            if (instructorId == null)
            {
                Text = "Add Instructor";
                return;
            }

            Text = "Update Instructor";
            var instructor = context.Instructors.FirstOrDefault(i => i.ID == instructorId.Value);
            if (instructor == null)
            {
                MessageBox.Show("Instructor not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            idBox.Text = instructor.ID.ToString();
            firstNameBox.Text = instructor.FirstName;
            lastNameBox.Text = instructor.LastName;
            phoneBox.Text = instructor.Phone;
            departmentBox.SelectedValue = instructor.DepartmentId;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstNameBox.Text) || string.IsNullOrWhiteSpace(lastNameBox.Text))
            {
                MessageBox.Show("First name and last name are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (departmentBox.SelectedValue == null)
            {
                MessageBox.Show("Department is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var departmentId = Convert.ToInt32(departmentBox.SelectedValue);

            if (instructorId == null)
            {
                Instructor instructor = new()
                {
                    FirstName = firstNameBox.Text.Trim(),
                    LastName = lastNameBox.Text.Trim(),
                    Phone = phoneBox.Text.Trim(),
                    DepartmentId = departmentId
                };

                context.Instructors.Add(instructor);
            }
            else
            {
                var instructor = context.Instructors.FirstOrDefault(i => i.ID == instructorId.Value);
                if (instructor == null)
                {
                    MessageBox.Show("Instructor not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                instructor.FirstName = firstNameBox.Text.Trim();
                instructor.LastName = lastNameBox.Text.Trim();
                instructor.Phone = phoneBox.Text.Trim();
                instructor.DepartmentId = departmentId;
            }

            context.SaveChanges();
            MessageBox.Show("Instructor saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
