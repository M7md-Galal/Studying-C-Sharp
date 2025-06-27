using Microsoft.EntityFrameworkCore;
using TPCC.Contexts;
using TPCC.Entities;

namespace TPCC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyDbContexte companyDbContexte = new CompanyDbContexte();

            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee
            { 
                Name = "John Doe",
                Age = 30,
                Address = "123 Main St",
                startDate = "2023-01-01",
                Salary = 60000.00m
            };

            PartTimeEmployee partTimeEmployee = new PartTimeEmployee
            {
                Name = "Jane Smith",
                Age = 25,
                Address = "456 Elm St",
                HourRate = 20.00m,
                CountOfHours = 20
            };

            //companyDbContexte.FullTimeEmployees.Add(fullTimeEmployee);
            //companyDbContexte.PartTimeEmployees.Add(partTimeEmployee);

            //companyDbContexte.SaveChanges();


            var ftEmployee = from fte in companyDbContexte.FullTimeEmployees
                             select fte;

            var ptEmployee = from pte in companyDbContexte.PartTimeEmployees
                             select pte;

            foreach(var employee in ftEmployee)
                Console.WriteLine($"Full Time Employee: {employee.Name}, Age: {employee.Age}, Address: {employee.Address}, Start Date: {employee.startDate}, Salary: {employee.Salary}");

            foreach (var employee in ptEmployee)
                Console.WriteLine($"Part Time Employee: {employee.Name}, Age: {employee.Age}, Address: {employee.Address}, Hour Rate: {employee.HourRate}, Count of Hours: {employee.CountOfHours}");
        }
    }
}
