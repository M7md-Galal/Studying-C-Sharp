using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TypeA
    {
        public int x { get; set; }

        public TypeA(int _x)
        {
            x = _x;
        }
        public void Print01()
        {
            Console.WriteLine("I am Perant01");
        }

        public virtual void Print02()
        {
            Console.WriteLine("I am Perant02");
        }

    }
}
