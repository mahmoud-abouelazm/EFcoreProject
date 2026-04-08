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

            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });

            
            // Seed Data (10+ records each)
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "Computer Science", Location = "Building A", ManagerId = null },
                new Department { Id = 2, Name = "Mathematics", Location = "Building B", ManagerId = null },
                new Department { Id = 3, Name = "Physics", Location = "Building C", ManagerId = null },
                new Department { Id = 4, Name = "Chemistry", Location = "Building D", ManagerId = null },
                new Department { Id = 5, Name = "Biology", Location = "Building E", ManagerId = null },
                new Department { Id = 6, Name = "English", Location = "Building F", ManagerId = null },
                new Department { Id = 7, Name = "History", Location = "Building G", ManagerId = null },
                new Department { Id = 8, Name = "Economics", Location = "Building H", ManagerId = null },
                new Department { Id = 9, Name = "Art", Location = "Building I", ManagerId = null },
                new Department { Id = 10, Name = "Music", Location = "Building J", ManagerId = null }
            );

            modelBuilder.Entity<Instructor>().HasData(
                new Instructor { ID = 1, FirstName = "Ahmed", LastName = "Ali", Phone = "01012345678", DepartmentId = 1 },
                new Instructor { ID = 2, FirstName = "Mona", LastName = "Hassan", Phone = "01112345678", DepartmentId = 2 },
                new Instructor { ID = 3, FirstName = "Khaled", LastName = "Ibrahim", Phone = "01212345678", DepartmentId = 3 },
                new Instructor { ID = 4, FirstName = "Lina", LastName = "Youssef", Phone = "01098765432", DepartmentId = 4 },
                new Instructor { ID = 5, FirstName = "Youssef", LastName = "Saeed", Phone = "01155556666", DepartmentId = 5 },
                new Instructor { ID = 6, FirstName = "Dina", LastName = "Farid", Phone = "01233334444", DepartmentId = 6 },
                new Instructor { ID = 7, FirstName = "Ola", LastName = "Mahmoud", Phone = "01022223333", DepartmentId = 7 },
                new Instructor { ID = 8, FirstName = "Samir", LastName = "Nabil", Phone = "01111112222", DepartmentId = 8 },
                new Instructor { ID = 9, FirstName = "Rana", LastName = "Fahmy", Phone = "01244445555", DepartmentId = 9 },
                new Instructor { ID = 10, FirstName = "Tamer", LastName = "Sami", Phone = "01066667777", DepartmentId = 10 }
            );

            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 1, Name = "C# Programming", Duration = 40, DepartmentId = 1, InstructorId = 1 },
                new Course { Id = 2, Name = "Calculus", Duration = 30, DepartmentId = 2, InstructorId = 2 },
                new Course { Id = 3, Name = "Physics 1", Duration = 35, DepartmentId = 3, InstructorId = 3 },
                new Course { Id = 4, Name = "Organic Chemistry", Duration = 45, DepartmentId = 4, InstructorId = 4 },
                new Course { Id = 5, Name = "Cell Biology", Duration = 32, DepartmentId = 5, InstructorId = 5 },
                new Course { Id = 6, Name = "English Literature", Duration = 28, DepartmentId = 6, InstructorId = 6 },
                new Course { Id = 7, Name = "Modern History", Duration = 30, DepartmentId = 7, InstructorId = 7 },
                new Course { Id = 8, Name = "Microeconomics", Duration = 36, DepartmentId = 8, InstructorId = 8 },
                new Course { Id = 9, Name = "Drawing", Duration = 20, DepartmentId = 9, InstructorId = 9 },
                new Course { Id = 10, Name = "Music Theory", Duration = 22, DepartmentId = 10, InstructorId = 10 }
            );

            modelBuilder.Entity<CourseSession>().HasData(
                new CourseSession { Id = 1, Title = "Intro to C#", Date = new DateTime(2023, 10, 1), CourseId = 1, InstructorId = 1 },
                new CourseSession { Id = 2, Title = "Limits and Continuity", Date = new DateTime(2023, 10, 2), CourseId = 2, InstructorId = 2 },
                new CourseSession { Id = 3, Title = "Mechanics", Date = new DateTime(2023, 10, 3), CourseId = 3, InstructorId = 3 },
                new CourseSession { Id = 4, Title = "Hydrocarbons", Date = new DateTime(2023, 10, 4), CourseId = 4, InstructorId = 4 },
                new CourseSession { Id = 5, Title = "Cell Structure", Date = new DateTime(2023, 10, 5), CourseId = 5, InstructorId = 5 },
                new CourseSession { Id = 6, Title = "Shakespeare Overview", Date = new DateTime(2023, 10, 6), CourseId = 6, InstructorId = 6 },
                new CourseSession { Id = 7, Title = "WW2 Events", Date = new DateTime(2023, 10, 7), CourseId = 7, InstructorId = 7 },
                new CourseSession { Id = 8, Title = "Supply & Demand", Date = new DateTime(2023, 10, 8), CourseId = 8, InstructorId = 8 },
                new CourseSession { Id = 9, Title = "Figure Drawing", Date = new DateTime(2023, 10, 9), CourseId = 9, InstructorId = 9 },
                new CourseSession { Id = 10, Title = "Harmony Basics", Date = new DateTime(2023, 10, 10), CourseId = 10, InstructorId = 10 }
            );

            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, FirstName = "Omar", LastName = "Tarek", Phone = "01212345678" },
                new Student { Id = 2, FirstName = "Sara", LastName = "Gamal", Phone = "01512345678" },
                new Student { Id = 3, FirstName = "Ali", LastName = "Hassan", Phone = "01187654321" },
                new Student { Id = 4, FirstName = "Mariam", LastName = "Saeed", Phone = "01010101010" },
                new Student { Id = 5, FirstName = "Hassan", LastName = "Kamal", Phone = "01120202020" },
                new Student { Id = 6, FirstName = "Nora", LastName = "Fadel", Phone = "01230303030" },
                new Student { Id = 7, FirstName = "Yara", LastName = "Adel", Phone = "01040404040" },
                new Student { Id = 8, FirstName = "Karim", LastName = "Ibraheem", Phone = "01150505050" },
                new Student { Id = 9, FirstName = "Dalia", LastName = "Mostafa", Phone = "01260606060" },
                new Student { Id = 10, FirstName = "Mostafa", LastName = "Nagy", Phone = "01070707070" }
            );

            modelBuilder.Entity<StudentCourse>().HasData(
                new StudentCourse { StudentId = 1, CourseId = 1 },
                new StudentCourse { StudentId = 1, CourseId = 2 },
                new StudentCourse { StudentId = 2, CourseId = 2 },
                new StudentCourse { StudentId = 2, CourseId = 3 },
                new StudentCourse { StudentId = 3, CourseId = 1 },
                new StudentCourse { StudentId = 4, CourseId = 4 },
                new StudentCourse { StudentId = 5, CourseId = 5 },
                new StudentCourse { StudentId = 6, CourseId = 6 },
                new StudentCourse { StudentId = 7, CourseId = 7 },
                new StudentCourse { StudentId = 8, CourseId = 8 },
                new StudentCourse { StudentId = 9, CourseId = 9 },
                new StudentCourse { StudentId = 10, CourseId = 10 }
            );

            modelBuilder.Entity<CourseSessionAttendance>().HasData(
                new CourseSessionAttendance { Id = 1, CourseSessionId = 1, StudentId = 1, Grade = 90, Notes = "Good" },
                new CourseSessionAttendance { Id = 2, CourseSessionId = 2, StudentId = 2, Grade = 85, Notes = "Very Good" },
                new CourseSessionAttendance { Id = 3, CourseSessionId = 3, StudentId = 3, Grade = 95, Notes = "Excellent" },
                new CourseSessionAttendance { Id = 4, CourseSessionId = 4, StudentId = 4, Grade = 88, Notes = "Well Done" },
                new CourseSessionAttendance { Id = 5, CourseSessionId = 5, StudentId = 5, Grade = 76, Notes = "Satisfactory" },
                new CourseSessionAttendance { Id = 6, CourseSessionId = 6, StudentId = 6, Grade = 82, Notes = "Good" },
                new CourseSessionAttendance { Id = 7, CourseSessionId = 7, StudentId = 7, Grade = 79, Notes = "Needs Improvement" },
                new CourseSessionAttendance { Id = 8, CourseSessionId = 8, StudentId = 8, Grade = 91, Notes = "Very Good" },
                new CourseSessionAttendance { Id = 9, CourseSessionId = 9, StudentId = 9, Grade = 87, Notes = "Good" },
                new CourseSessionAttendance { Id = 10, CourseSessionId = 10, StudentId = 10, Grade = 93, Notes = "Excellent" }
            );

            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseSession> CourseSessions { get; set; }
        public virtual DbSet<Department> Departments{ get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<CourseSessionAttendance> CourseSessionAttendances { get; set; }
        public virtual DbSet<StudentCourse> StudentCourses { get; set; }
    }
}
