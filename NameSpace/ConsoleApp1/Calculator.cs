using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Calculator
    {
        public static bool SortAsc(int x, int y)
        {
            return x > y;
        }
        
        public static bool SortDsc(int x, int y)
        {
            return x < y;
        }
        public static bool SortStringAsc(string s1,string s2)
        {
            return s1?.Length > s2?.Length;
        }
        public static bool SortStringDsc(string s1,string s2)
        {
            return s1?.Length < s2?.Length;
        }
    }
}
