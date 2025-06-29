﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByConvention.Entities
{
    public class Department
    {
        public  virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual DateOnly DateOfCreation { get; set; }

        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>(); //Navigational property 
    }
}
