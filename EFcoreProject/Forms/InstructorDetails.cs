using EFcoreProject.Context;
using EFcoreProject.Models;
using Microsoft.Identity.Client;
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
    public partial class InstructorDetails : Form
    {
        private readonly Instructor instructor;
        private readonly EFContext eFContext;

        public InstructorDetails(Instructor instructor)
        {
            InitializeComponent();
            eFContext = new();
            this.instructor = instructor;
        }

        private void InstructorDetails_Load(object sender, EventArgs e)
        {
            IdBox.Text = instructor.ID.ToString();
            firstNameBox.Text = instructor.FirstName;
            LastNameBox.Text = instructor.LastName;
            PhoneBox.Text = instructor.Phone;

            var departments = eFContext.Departments.ToList();
            comboBox1.DataSource = departments;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            if (instructor.DepartmentId > 0)
            {
                comboBox1.SelectedValue = instructor.DepartmentId;
            }

            SaveBtn.Click += SaveBtn_Click;
        }

        private void SaveBtn_Click(object? sender, EventArgs e)
        {
            instructor.FirstName = firstNameBox.Text;
            instructor.LastName = LastNameBox.Text;
            instructor.Phone = PhoneBox.Text;

            if (comboBox1.SelectedValue != null)
            {
                instructor.DepartmentId = (int)comboBox1.SelectedValue;
            }

            eFContext.SaveChanges();
            MessageBox.Show("Instructor updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
