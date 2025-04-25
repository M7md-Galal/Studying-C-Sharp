using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TypeB : TypeA
    {
        public int y { get; set; }

        public TypeB(int _y , int _x) : base(_x)
        {
            y = _y;
        }

        public new void Print01()
        {
            Console.WriteLine("I am Child01 typeB");
        }
        override public void Print02()
        {
            Console.WriteLine("I am Child02 typeB");
        }
    }
}
