using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee : ICloneable , IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee() { }
        public Employee(Employee CopiedEmployee)
        {
            Id = CopiedEmployee.Id;
            Name = CopiedEmployee.Name;
            Salary = CopiedEmployee.Salary;
        }

        public object Clone()
        {

            //return new Employee()
            //{
            //    Id = this.Id,
            //    Name = this.Name,
            //    Salary = this.Salary
            //};

            return new Employee(this);
        }

        public override string ToString()
        {
            return $"{Id} :: {Name} :: {Salary}";
        }

        public int CompareTo(object? obj)
        {
            Employee PassedEmplyee = obj as Employee; // safe casting (as)
            
            return this.Salary.CompareTo(PassedEmplyee.Salary);

            if (this.Salary < PassedEmplyee.Salary)
                return 1;
            else if(this.Salary > PassedEmplyee.Salary)
                return -1;
            else
                return 0;
        }
    }
}
