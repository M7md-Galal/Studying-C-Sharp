using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface
{
    internal interface IPayment
    {
        public decimal Salary { get; set; }

        public void ProcessPayment();
    }
}
