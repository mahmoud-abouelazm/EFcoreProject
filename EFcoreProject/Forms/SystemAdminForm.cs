using System;
using System.Windows.Forms;

namespace EFcoreProject.Forms
{
    public partial class SystemAdminForm : Form
    {
        public SystemAdminForm()
        {
            InitializeComponent();
        }

        private void btnManageDepartments_Click(object sender, EventArgs e)
        {
            ManageDepartmentsForm form = new();
            form.ShowDialog();
        }

        private void btnManageInstructors_Click(object sender, EventArgs e)
        {
            ManageInstructorsForm form = new();
            form.ShowDialog();
        }

        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            ManageStudentsForm form = new();
            form.ShowDialog();
        }
    }
}
