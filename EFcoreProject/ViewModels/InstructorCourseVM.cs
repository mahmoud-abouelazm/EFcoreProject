using EFcoreProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFcoreProject.ViewModels
{
    internal class InstructorCourseVM
    {
        public int Id { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        [DisplayName("Department")]
        public string DepartmentName { get; set; }
    }
}
