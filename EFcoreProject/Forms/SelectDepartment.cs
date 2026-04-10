using EFcoreProject.Context;
using EFcoreProject.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace EFcoreProject
{
    public partial class SelectDepartment : Form
    {
        DepartmentRepo departmentRepo;
        // create new department repo
        public SelectDepartment()
        {
            departmentRepo = new();
            InitializeComponent();
        }
        // Change signature from async Task -> async void
        private async void button1_Click(object sender, EventArgs e)
        {
            // update following section to choose department id , and go to it's portal
            var id = (Convert.ToInt32(chooseInstructor.SelectedValue ?? 0));
            if (await departmentRepo.CheckDepartment(id))
            {
                Forms.DepartmentDetails departmentDetails = new(id);
                Hide();
                departmentDetails.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("No Department Found !!",
                    "Enter correct Id",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private async void userID_Load(object sender, EventArgs e)
        {
            chooseInstructor.DataSource = await departmentRepo.GetAllDepartments();
            chooseInstructor.DisplayMember = "Name";
            chooseInstructor.ValueMember = "Id";
        }
    }
}
