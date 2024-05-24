using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using studentdatabase.Model;

namespace studentdatabase.Data
{
    public class studentdatabaseContext : DbContext
    {
        public studentdatabaseContext (DbContextOptions<studentdatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<studentdatabase.Model.Course> Course { get; set; } = default!;

        public DbSet<studentdatabase.Model.Student> Student { get; set; } = default!;

        public DbSet<studentdatabase.Model.StudentInformation> StudentInformation { get; set; } = default!;
    }
}
