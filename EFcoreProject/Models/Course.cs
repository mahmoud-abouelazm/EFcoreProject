using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace EFcoreProject.Models
{
    public  class Course
    {
        public int Id { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }

        // Navigation properties : 
        [ForeignKey(nameof(Department))]
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
        
        [ForeignKey(nameof(Instructor))]
        public int? InstructorId { get; set; }
        public Instructor? Instructor { get; set; }

        public ICollection<CourseSession> CourseSessions { get; set; } = new HashSet<CourseSession>();
    // Many-to-many: Students enrolled in this course
    public ICollection<StudentCourse> Students { get; set; } = new HashSet<StudentCourse>();
    }
}
