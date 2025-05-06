using ByConvention.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ByConvention
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // This line is used to create the database if it does not exist.
            Project1DbContext dbContext = new Project1DbContext();
            dbContext.Employees.Add(new Entities.Employee
            {
                Id = 1,
                Name = "Mohamed Galal",
                Salary = 50000,
                Age = 21
            });


            // Apply Migrations To Database
            // 1. Code
            //dbContext.Database.Migrate(); // Apply Ups
            // 2. Package Manager Console
        }
    }
}
