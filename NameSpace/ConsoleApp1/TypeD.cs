using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TypeD : TypeB
    {
        public TypeD(int _y, int _x) : base(_y, _x)
        {
        }

        //public override void Print02()
        //{
             // {Error} This Method is not Virtual 
        //}
    }
}
