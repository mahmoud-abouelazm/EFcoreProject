using EFcoreProject.Context;
using EFcoreProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EFcoreProject.Forms
{
    public partial class DepartmentInfoDetails : Form
    {
        private readonly int deptId;
        private readonly EFContext context;

        public DepartmentInfoDetails(int deptId)
        {
            InitializeComponent();
            this.deptId = deptId;
            context = new EFContext();
        }

        private void DepartmentInfoDetails_Load(object sender, EventArgs e)
        {
            var dept = context.Departments.Find(deptId);
            if (dept == null)
            {
                MessageBox.Show("Department not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            IdBox.Text = dept.Id.ToString();
            nameBox.Text = dept.Name;
            locationBox.Text = dept.Location;

            var managers = context.Instructors
                .Where(i => i.DepartmentId == deptId)
                .Select(i => new ManagerItem
                {
                    ID = i.ID,
                    FullName = i.FirstName + " " + i.LastName
                })
                .ToList();

            managers.Insert(0, new ManagerItem { ID = 0, FullName = "No Manager" });

            managerBox.DataSource = managers;
            managerBox.DisplayMember = "FullName";
            managerBox.ValueMember = "ID";
            managerBox.SelectedValue = dept.ManagerId ?? 0;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameBox.Text) || string.IsNullOrWhiteSpace(locationBox.Text))
            {
                MessageBox.Show("Name and location are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dept = context.Departments.Find(deptId);
            if (dept == null)
            {
                MessageBox.Show("Department not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dept.Name = nameBox.Text.Trim();
            dept.Location = locationBox.Text.Trim();

            if (managerBox.SelectedValue != null)
            {
                var managerId = Convert.ToInt32(managerBox.SelectedValue);
                dept.ManagerId = managerId == 0 ? null : managerId;
            }

            context.SaveChanges();
            MessageBox.Show("Department updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private class ManagerItem
        {
            public int ID { get; set; }
            public string FullName { get; set; }
        }
    }
}
