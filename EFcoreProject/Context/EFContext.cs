using EFcoreProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFcoreProject.Context
{
    public class EFContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EF_Final_Project;Trusted_Connection=True;encrypt = false;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .HasMany(d => d.Instructors)
                .WithOne(i => i.Department)
                .HasForeignKey(x=>x.DepartmentId);

            modelBuilder.Entity<Department>()
                .HasOne(d => d.Manager)
                .WithOne(i=>i.DepartmentManaged)
                .OnDelete(DeleteBehavior.NoAction);
            
            modelBuilder.Entity<Course>()
                .HasOne(c => c.Instructor)
                .WithMany(i => i.Courses)
                .HasForeignKey(c => c.InstructorId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<CourseSession>()
                .HasOne(c => c.Instructor)
                .WithMany(i => i.CourseSessions)
                .HasForeignKey(c => c.InstructorId)
                .OnDelete(DeleteBehavior.NoAction);

            // Seed Data
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "Computer Science", Location = "Building A", ManagerId = null },
                new Department { Id = 2, Name = "Mathematics", Location = "Building B", ManagerId = null }
            );

            modelBuilder.Entity<Instructor>().HasData(
                new Instructor { ID = 1, FirstName = "Ahmed", LastName = "Ali", Phone = "01012345678", DepartmentId = 1 },
                new Instructor { ID = 2, FirstName = "Mona", LastName = "Hassan", Phone = "01112345678", DepartmentId = 2 }
            );

            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 1, Name = "C# Programming", Duration = 40, DepartmentId = 1, InstructorId = 1 },
                new Course { Id = 2, Name = "Calculus", Duration = 30, DepartmentId = 2, InstructorId = 2 }
            );

            modelBuilder.Entity<CourseSession>().HasData(
                new CourseSession { Id = 1, Title = "Intro to C#", Date = new DateTime(2023, 10, 1), CourseId = 1, InstructorId = 1 },
                new CourseSession { Id = 2, Title = "Limits and Continuity", Date = new DateTime(2023, 10, 2), CourseId = 2, InstructorId = 2 }
            );

            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, FirstName = "Omar", LastName = "Tarek", Phone = "01212345678" },
                new Student { Id = 2, FirstName = "Sara", LastName = "Gamal", Phone = "01512345678" }
            );

            modelBuilder.Entity<CourseSessionAttendance>().HasData(
                new CourseSessionAttendance { Id = 1, CourseSessionId = 1, StudentId = 1, Grade = 90, Notes = "Good" },
                new CourseSessionAttendance { Id = 2, CourseSessionId = 2, StudentId = 2, Grade = 85, Notes = "Very Good" }
            );

            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseSession> CourseSessions { get; set; }
        public virtual DbSet<Department> Departments{ get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<CourseSessionAttendance> CourseSessionAttendances { get; set; }
    }
}
