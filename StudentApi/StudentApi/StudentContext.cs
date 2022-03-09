using System;
using Microsoft.EntityFrameworkCore;
using StudentApi.Models;

namespace StudentApi
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions opt):base(opt)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
