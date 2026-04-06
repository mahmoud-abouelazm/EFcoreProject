<<<<<<< HEAD
﻿using EFcoreProject.Models;
using EFcoreProject.Repository;
using System;
=======
﻿using System;
>>>>>>> 8a2c0ec93d207e28d0f711cfcd72e1202ea1edc2
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
<<<<<<< HEAD
        Instructor instructor;
        int id;
        InstructorRepo InstructorRepo = new();
        public InstructorForm(int id)
        {
            this.id = id;
                        InitializeComponent();
=======
        int InstructorId;
        public InstructorForm(int id)
        {
            InstructorId = id;
            InitializeComponent();
>>>>>>> 8a2c0ec93d207e28d0f711cfcd72e1202ea1edc2
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD
        private async void InstructorForm_Load(object sender, EventArgs e)
        {
            instructor = await InstructorRepo.GetInstructorById(id);
            lblInstructorName.Text = instructor.FirstName + " " + instructor.LastName;
=======
        private void InstructorForm_Load(object sender, EventArgs e)
        {

>>>>>>> 8a2c0ec93d207e28d0f711cfcd72e1202ea1edc2
        }
    }
}
