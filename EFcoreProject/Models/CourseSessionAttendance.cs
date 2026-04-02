using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace EFcoreProject.Models
{
    public class CourseSessionAttendance
    {
        public int  Id { get; set; }
        public int Grade { get; set; } = 0;
        [MaxLength]
        public string? Notes { get; set; }

        // Navigation Properties :
        [ForeignKey(nameof(CourseSession))]
        public int CourseSessionId { get; set; }
        public CourseSession? CourseSession { get; set; }
        
        [ForeignKey(nameof(Student))]
        public int StudentId { get; set; }
        public Student? Student { get; set; }


    }
}
