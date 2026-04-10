using EFcoreProject.Context;
using EFcoreProject.Models;
using EFcoreProject.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFcoreProject.Repository
{
    internal class CoursesRepo
    {
        EFContext context = new();
        public async Task<Course> GetCourseById(int id)
        {
            return await context.Courses.FindAsync(id);
        }
        public async Task<List<InstructorCourseVM>> GetCoursesOfInstructor(int instId)
        {
            return await context.Courses
                .Include(i => i.Department)
                .AsNoTracking()
                .Where(i => i.InstructorId == instId)
                .Select(i => new InstructorCourseVM()
                {
                    Name = i.Name,
                    DepartmentName = i.Department.Name,
                    Duration = i.Duration,
                    Id = i.Id
                })
                .ToListAsync();
        }

    }
}
