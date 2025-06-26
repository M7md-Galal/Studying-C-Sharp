using ByConvention.Contexts;
using ByConvention.Entities;
using Microsoft.EntityFrameworkCore;

namespace ByConvention
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // This line is used to create the database if it does not exist.
            //dbContext.Employees.Add(new Entities.Employee
            //{
            //    Id = 1,
            //    Name = "Mohamed Galal",
            //    Salary = 50000,
            //    Age = 21
            //});


            // Apply Migrations To Database
            // 1. Code
            //dbContext.Database.Migrate(); // Apply Ups
            // 2. Package Manager Console
            
            
            using Project1DbContext dbContext = new Project1DbContext();


            // Add new employees to the database
            Employee employee01 = new Employee
            {
                
                Name = "Mohamed Galal",
                Salary = 50000,
                Age = 21
            };
            Employee employee02 = new Employee
            {
                Name = "Ahmed Ali",
                Salary = 60000,
                Age = 22
            };
            //Console.WriteLine(dbContext.Entry(employee01).State); // Detached
            //Console.WriteLine(dbContext.Entry(employee02).State); // Detached
            //dbContext.Employees.Add(employee01); // Added
            //dbContext.Employees.Add(employee02); // Added
            //Console.WriteLine(dbContext.Entry(employee01).State); // Detached
            //dbContext.SaveChanges();

            // Read employees from the database

            var Employee = (from E in dbContext.Employees
                            where E.EmpId == 2
                            select E).FirstOrDefault();

            //Console.WriteLine(Employee?.Name ?? "No employee found with EmpId 1");


            // Update an employee in the database

            Employee = (from E in dbContext.Employees
                           where E.EmpId == 2
                           select E).FirstOrDefault();

            //Employee.Name = "Ali Mansour";
            //dbContext.SaveChanges();

            // Delete an employee from the database

            Employee = (from E in dbContext.Employees
                        where E.EmpId == 2
                        select E).FirstOrDefault();
            dbContext.Employees.Remove(Employee); 
            dbContext.SaveChanges();
        }
    }
}
