using EFcoreProject.Context;
using EFcoreProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFcoreProject.Repository
{
    internal class InstructorRepo
    {
        EFContext context = new();
        public async Task<Instructor> GetInstructorById(int id)
        {
            return await context.Instructors.FindAsync(id);
        }
        public async Task<List<Instructor>> GetAllInstructors()
        {
            return await context.Instructors.ToListAsync();
        }
        public async Task<bool> CheckInstructor(int id)
        {
            return await context.Instructors.AnyAsync(i=>i.ID == id);
        }

    }
}
