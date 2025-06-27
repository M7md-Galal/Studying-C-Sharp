using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCC.Entities
{
    internal class FullTimeEmployee : Employee
    {
        public string startDate { get; set; }
        public decimal Salary { get; set; }

    }
}
