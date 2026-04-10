using EFcoreProject.Context;
using EFcoreProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFcoreProject.Repository
{
    internal class DepartmentRepo
    {
        EFContext context = new();
        public async Task<Department> GetDepartmentById(int id)
        {
            return await context.Departments.FindAsync(id);
        }
        public async Task<List<Department>> GetAllDepartments()
        {
            return await context.Departments.ToListAsync();
        }
        public async Task<bool> CheckDepartment(int id)
        {
            return await context.Departments.AnyAsync(d=>d.Id == id);
        }
    }
}