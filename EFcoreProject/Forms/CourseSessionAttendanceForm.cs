using EFcoreProject.Context;
using EFcoreProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EFcoreProject.Forms
{
    public partial class CourseSessionAttendanceForm : Form
    {
        private readonly int instructorId;
        private EFContext context;

        public CourseSessionAttendanceForm(int instructorId)
        {
            InitializeComponent();
            this.instructorId = instructorId;
            context = new EFContext();

            this.Load += CourseSessionAttendanceForm_Load;
            AddBtn.Click += AddBtn_Click;
            updateBtn.Click += updateBtn_Click;
            deleteBtn.Click += deleteBtn_Click;
        }

        private void CourseSessionAttendanceForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            context.CourseSessionAttendances
                .Include(c => c.CourseSession)
                .Where(cs => cs.CourseSession.InstructorId == instructorId)
                .Load();

            dataGridView1.DataSource = context.CourseSessionAttendances.Local.ToBindingList();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var addForm = new AddCourseSessionAttendanceForm(instructorId);
            addForm.ShowDialog();
            LoadData();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var attendance = dataGridView1.CurrentRow.DataBoundItem as CourseSessionAttendance;
                if (attendance != null)
                {
                    var editForm = new EditCourseSessionAttendanceForm(attendance.Id, instructorId);
                    editForm.ShowDialog();
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Please select a record to update.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var attendance = dataGridView1.CurrentRow.DataBoundItem as CourseSessionAttendance;
                if (attendance != null)
                {
                    context.CourseSessionAttendances.Remove(attendance);
                    context.SaveChanges();
                    MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
        }
    }
}
