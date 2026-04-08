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
    public partial class CourseSessionsForm : Form
    {
        private readonly int instructorId;
        private EFContext context;

        public CourseSessionsForm(int instructorId)
        {
            InitializeComponent();
            this.instructorId = instructorId;
            context = new EFContext();

            this.Load += CourseSessionsForm_Load;
            AddBtn.Click += AddBtn_Click;
            updateBtn.Click += updateBtn_Click;
            deleteBtn.Click += deleteBtn_Click;
        }

        private void CourseSessionsForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            context.ChangeTracker.Clear();
            context.CourseSessions
                .Where(cs => cs.InstructorId == instructorId)
                .Load();

            dataGridView1.DataSource = context.CourseSessions.Local.ToBindingList();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var addForm = new AddCourseSessionForm(instructorId);
            addForm.ShowDialog();
            LoadData();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                context.SaveChanges();
                MessageBox.Show("Changes saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving changes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var session = dataGridView1.CurrentRow.DataBoundItem as CourseSession;
                if (session != null)
                {
                    context.CourseSessions.Remove(session);
                    context.SaveChanges();
                    MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
