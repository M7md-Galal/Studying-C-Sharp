using System.Collections;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            ////var ress = Enumerable.Where(list, i => i % 2 == 0);
            //var res = list.Where(i => i % 2 == 0).Select(i => i * i);
            ////foreach (var i in res)
            ////    Console.WriteLine(i);

            //var ress = list.OrderBy(i => i);
            //foreach ( var i in ress )
            //    Console.WriteLine(i);

            //var evenNum = from N in list
            //              where N % 2 == 0
            //              select N;

            //foreach( var item in evenNum )
            //    Console.WriteLine( item );

            var enenNumber = list.Where(N => N % 2 == 0).ToList();
            list.AddRange(new int[] { 11, 23, 54, 2, 56, 2, 2 });

            foreach (var item in enenNumber)
                Console.WriteLine(item);
        }
    }
}
