using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace studentmanagementsystem.Models
{
    public class studentmanagementsystemContext : DbContext
    {
        public studentmanagementsystemContext (DbContextOptions<studentmanagementsystemContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }

        public DbSet<Assignment> Assignments { get; set; }

    }
}
