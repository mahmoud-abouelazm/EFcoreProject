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
        int InstructorId;
        public InstructorForm(int id)
        {
            InstructorId = id;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void InstructorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
