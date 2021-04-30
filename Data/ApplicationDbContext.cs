using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leave_Manager.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { 
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Leave_Type> Leave_Types { get; set; }
        public DbSet<Leave_History> Leave_Historie { get; set; }
        public DbSet<Leave_ALlocation> Leave_ALlocations { get; set; }

    }
}
