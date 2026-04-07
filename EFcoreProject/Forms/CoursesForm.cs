using EFcoreProject.Models;
using EFcoreProject.Repository;
using EFcoreProject.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EFcoreProject.Forms
{
    public partial class CoursesForm : Form
    {
        int instructorId;
        CoursesRepo CoursesRepo = new();
        public CoursesForm(int InstructorId)
        {
            this.instructorId = InstructorId;
            InitializeComponent();
        }

        private async void CoursesForm_Load(object sender, EventArgs e)
        {
            CoursesGirdView.DataSource = await CoursesRepo.GetCoursesOfInstructor(instructorId);
            List<InstructorCourseVM> ls = (List<InstructorCourseVM>)CoursesGirdView.DataSource;
        }
    }
}
