using EFcoreProject.Forms;
using EFcoreProject.Models;
using EFcoreProject.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EFcoreProject
{
    public partial class InstructorForm : Form
    {
        Instructor instructor;
        int id;
        InstructorRepo InstructorRepo = new();
        public InstructorForm(int id)
        {
            this.id = id;

            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void InstructorForm_Load(object sender, EventArgs e)
        {
            instructor = await InstructorRepo.GetInstructorById(id);
            lblInstructorName.Text = instructor.FirstName + " " + instructor.LastName;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            CoursesForm coursesForm = new(id);
            await coursesForm.ShowDialogAsync();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            InstructorDetails instructorDetails = new(instructor);
            instructorDetails.ShowDialog();
            InstructorForm_Load(null ,null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CourseSessionsForm courseSessionsForm = new CourseSessionsForm(id);
            courseSessionsForm.ShowDialog();
        }

        private void courseSessionAttendance_Click(object sender, EventArgs e)
        {
            CourseSessionAttendanceForm courseSessionAttendanceForm = new CourseSessionAttendanceForm(id);
            courseSessionAttendanceForm.ShowDialog();
        }
    }
}
