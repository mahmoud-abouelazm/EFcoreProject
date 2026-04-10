using EFcoreProject.Context;
using EFcoreProject.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EFcoreProject.Forms
{
    public partial class StudentAdminDetailsForm : Form
    {
        private readonly int? studentId;
        private readonly EFContext context;

        public StudentAdminDetailsForm(int? studentId = null)
        {
            InitializeComponent();
            this.studentId = studentId;
            context = new EFContext();
        }

        private void StudentAdminDetailsForm_Load(object sender, EventArgs e)
        {
            if (studentId == null)
            {
                Text = "Add Student";
                return;
            }

            Text = "Update Student";
            var student = context.Students.FirstOrDefault(s => s.Id == studentId.Value);
            if (student == null)
            {
                MessageBox.Show("Student not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            idBox.Text = student.Id.ToString();
            firstNameBox.Text = student.FirstName;
            lastNameBox.Text = student.LastName;
            phoneBox.Text = student.Phone;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstNameBox.Text) || string.IsNullOrWhiteSpace(lastNameBox.Text) || string.IsNullOrWhiteSpace(phoneBox.Text))
            {
                MessageBox.Show("First name, last name and phone are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (studentId == null)
            {
                Student student = new()
                {
                    FirstName = firstNameBox.Text.Trim(),
                    LastName = lastNameBox.Text.Trim(),
                    Phone = phoneBox.Text.Trim()
                };

                context.Students.Add(student);
            }
            else
            {
                var student = context.Students.FirstOrDefault(s => s.Id == studentId.Value);
                if (student == null)
                {
                    MessageBox.Show("Student not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                student.FirstName = firstNameBox.Text.Trim();
                student.LastName = lastNameBox.Text.Trim();
                student.Phone = phoneBox.Text.Trim();
            }

            context.SaveChanges();
            MessageBox.Show("Student saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
