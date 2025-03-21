using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface
{
    internal class CreditCardPayment : IPayment
    {
        public decimal Salary { get ; set ; }

        public void ProcessPayment()
        {
            Console.WriteLine("Process Payment");
        }
    }
}
