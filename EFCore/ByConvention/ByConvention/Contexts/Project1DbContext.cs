using ByConvention.Confiurations;
using ByConvention.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
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



        // Fluent API
        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            // This method is used to configure the model using Fluent API.
            // The modelBuilder parameter is used to configure the model.
            // The ToTable method is called to specify the table name for each entity.
            // The HasKey method is called to specify the primary key for each entity.
            // The Property method is called to configure properties of each entity.
            // The HasColumnName method is called to specify the column name for each property.
            // The IsRequired method is called to specify that a property is required.
            // The HasMaxLength method is called to specify the maximum length of a string property.
            // The HasPrecision method is called to specify the precision and scale of a decimal property.



            modelBuilder.Entity<Employee>()
                        .Property(e => e.EmpId)
                        .HasColumnName("EmpId");

            modelBuilder.Entity<Employee>()
                        .Property(e => e.Name)
                        .HasDefaultValue("Test")
                        .IsRequired(false)
                        .HasMaxLength(50);

            modelBuilder.Entity<Employee>()
                        .Property(e => e.Salary)
                        .HasPrecision(18, 2);

            modelBuilder.Entity<Employee>()
                        .Property(e => e.Age)
                        .IsRequired(false);



            ////Department
            //modelBuilder.Entity<Department>()
            //            .HasKey(D => D.Id);
            //modelBuilder.Entity<Department>()
            //            .Property(D => D.Id)
            //            .UseIdentityColumn(10, 10);

            //modelBuilder.Entity<Department>()
            //            .Property(D => D.Name)
            //            .HasColumnName("DepartmentName")
            //            .HasColumnType("varchar")
            //            .HasMaxLength(50)
            //            .IsRequired(false)
            //            .HasDefaultValue("Test Department");

            //modelBuilder.Entity<Department>()
            //            .Property(D => D.DateOfCreation)
            //            .HasDefaultValueSql("getdate()");

            // EfCore Feuture 3.1
            

            modelBuilder.ApplyConfiguration<Department>(new DepartmentConfiguration());


            modelBuilder.Entity<Department>()
                        .HasMany(D => D.Employees)
                        .WithOne(E => E.Dept)
                        .HasForeignKey(E => E.DepartmentDeptId)
                        .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Employee>()
                        .HasOne(E => E.Dept)
                        .WithMany(D => D.Employees);



            //modelBuilder.Entity<Student>()
            //            .HasMany(S => S.Courses)
            //            .WithMany(C => C.Students);  

            modelBuilder.Entity<StudentCourse>()
                        .HasKey(SC => new { SC.StudentId, SC.CourseId }); // Composite primary key

            modelBuilder.Entity<Student>()
                        .HasMany(S => S.StudentCourses)
                        .WithOne(SC => SC.student)
                        .HasForeignKey(SC => SC.StudentId);

            modelBuilder.Entity<Course>()
                        .HasMany(C => C.CourseStudents)
                        .WithOne(SC => SC.course)
                        .HasForeignKey(SC => SC.CourseId);

            base.OnModelCreating(modelBuilder);
        }



        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

    }
}
