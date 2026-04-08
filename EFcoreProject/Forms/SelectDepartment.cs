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
        InstructorRepo instRepo;
        public SelectDepartment()
        {
            instRepo = new();
            InitializeComponent();
        }
        // Change signature from async Task -> async void
        private async void button1_Click(object sender, EventArgs e)
        {
            var id = (Convert.ToInt32(chooseInstructor.SelectedValue ?? 0));
            if (await instRepo.CheckInstructor(id))
            {
                InstructorForm instructorForm = new(id);
                Hide();
                await instructorForm.ShowDialogAsync();
                Close();
            }
            else
            {
                MessageBox.Show("No Instructor Found !!",
                    "Enter correct Id",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private async void userID_Load(object sender, EventArgs e)
        {
            chooseInstructor.DataSource = await instRepo.GetAllInstructors();
            chooseInstructor.DisplayMember = "FirstName";
            chooseInstructor.ValueMember = "ID";
        }
    }
}
