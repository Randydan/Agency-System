using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First.Models
{
    public class CodeFirstContext : DbContext
    {
        public CodeFirstContext(DbContextOptions<CodeFirstContext> options) : base(options)
        {

        }

        public virtual DbSet<Administrators> Administrators { get; set; }
        public virtual DbSet<Classroom> Classrooms { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Department> Departments { get; set; } 
        public virtual DbSet<Lecturer> Lecturers { get; set; } 
        public virtual DbSet<Office> Offices { get; set; } 
        public virtual DbSet<Student> Students { get; set; }

    }
}
