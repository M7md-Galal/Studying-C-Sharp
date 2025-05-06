using ByConvention.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByConvention.Contexts
{
    // This namespace contains the DbContext class for the application.
    internal class Project1DbContext : DbContext
    {
        public Project1DbContext() : base()
        {
            // This constructor is used to initialize the DbContext.
            // It does not take any parameters and calls the base constructor.
            // The base constructor initializes the context with default options.
            // You can also pass options to the base constructor if needed.                 
        }
        // This class is used to configure the database context for the application.
        // It inherits from DbContext, which is part of Entity Framework Core.
        // The DbContext class is responsible for managing the database connection and mapping entities to database tables.
        // The constructor takes a DbContextOptions<Project1DbContext> parameter, which is used to configure the context.
        // The base constructor is called with the options parameter to initialize the context.
        // The OnModelCreating method is overridden to configure the model using Fluent API.
        // This method is called when the model for a derived context is being created.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            // This method is used to configure the database connection for the context.
            // The UseSqlServer method is called to specify that SQL Server should be used as the database provider.
            // The connection string is specified in the method.
            // The connection string specifies the server name, database name, and authentication method.
            // In this case, it uses a trusted connection (Windows Authentication).
            optionsBuilder.UseSqlServer("Server = . ; Database = Project1; Trusted_Connection = True;");

        public DbSet<Employee> Employees { get; set; }

    }
}
