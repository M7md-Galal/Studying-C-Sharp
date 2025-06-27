using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCC.Entities;

namespace TPCC.Contexts
{
    internal class CompanyDbContexte : DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= .; Database = Company ; Trusted_Connection = true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent Api
            // TPC
            modelBuilder.Entity<FullTimeEmployee>()
                        .HasBaseType<Employee>();

            modelBuilder.Entity<PartTimeEmployee>()
                        .HasBaseType<Employee>();


            base.OnModelCreating(modelBuilder);
        }
        //public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        //public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
