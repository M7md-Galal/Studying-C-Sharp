using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByConvention.Entities
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly DateOfCreation { get; set; }

        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>(); //Navigational property 
    }
}
