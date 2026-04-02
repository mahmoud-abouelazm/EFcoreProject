using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFcoreProject.Models
{
    public class CourseSession
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }

        // Navigation properties : 
        
        [ForeignKey(nameof(Course))]
        public int CourseId { get; set; }
        public Course? Course { get; set; }

        [ForeignKey(nameof(Instructor))]
        public int InstructorId { get; set; }
        public Instructor? Instructor { get; set; }
        
        
        // Relationships : 
        public ICollection<CourseSessionAttendance> courseSessionAttendances { get; set; } = new HashSet<CourseSessionAttendance>();
    }
}
