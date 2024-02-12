using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using P3EmployeeMain.Models;

namespace P3EmployeeMain.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext (DbContextOptions<EmployeeDbContext> options)
            : base(options)
        {
        }

        public DbSet<P3EmployeeMain.Models.Employee> Employee { get; set; } = default!;
    }
}
