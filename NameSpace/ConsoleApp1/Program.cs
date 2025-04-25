using ConsoleApp1.Interface;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1
{
    public delegate int del(int x,int y);

    internal class Program
    {
        
        static void Main(string[] args)
        {
            TypeB obj = new TypeB(10, 20);

            obj.Print01();
            obj.Print02();
            TypeA obj1 = new TypeA(30);
            obj1.Print01();
            obj1.Print02();

            TypeA obj2 = new TypeB(10, 20);
            obj2.Print01();
            obj2.Print02();


            IPayment payment = new CreditCardPayment();
            payment.Salary = 1;
            payment.ProcessPayment();

            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 4, 5, 6 };

            Console.WriteLine(arr1.GetHashCode()); // 43942917
            Console.WriteLine(arr2.GetHashCode()); // 59941933

            Console.WriteLine(arr1[0]);
            Console.WriteLine(arr2[0]);

            Console.WriteLine("\n=============");
            //arr2 = arr1; // Shallw Copy
            arr2 = (int[])arr1.Clone(); // Deep Copy
            arr2[0] = 999;
            Console.WriteLine(arr1.GetHashCode()); // 43942917
            Console.WriteLine(arr2.GetHashCode()); // 43942917
            Console.WriteLine(arr1[0]);
            //Console.WriteLine(arr2[0]);


            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 4, 5, 6 };

            Console.WriteLine(arr1.GetHashCode()); // 43942917
            Console.WriteLine(arr2.GetHashCode()); // 59941933

            Console.WriteLine(arr1[0]);
            Console.WriteLine(arr2[0]);

            Console.WriteLine("\n=============");

            arr2 = (int[])arr1.Clone(); // Deep Copy
            arr2[0] = 999;
            Console.WriteLine(arr1.GetHashCode()); // 43942917
            Console.WriteLine(arr2.GetHashCode()); // 
            Console.WriteLine(arr1[0]);
            Console.WriteLine(arr2[0]);

            string[] arr1 = { "a", "b", "c" };
            string[] arr2 = { "d", "f", "g" };

            Console.WriteLine(arr1.GetHashCode()); // 43942917
            Console.WriteLine(arr2.GetHashCode()); // 59941933

            Console.WriteLine(arr1[0]);
            Console.WriteLine(arr2[0]);

            Console.WriteLine("\n=============");
            arr2 = (string[])arr1.Clone();

            arr2[0] = "z";

            Console.WriteLine(arr1[0]);
            Console.WriteLine(arr2[0]);
            Console.WriteLine(arr1.GetHashCode());
            Console.WriteLine(arr2.GetHashCode());



            /////////////////////////


            Employee employee01 = new Employee();
            employee01.Id = 1;
            employee01.Name = "Ali";
            employee01.Salary = 1000;

            Employee employee02 = new Employee()
            {
                Id = 2,
                Name = "Aya",
                Salary = 2000
            };


            Console.WriteLine(employee01.GetHashCode()); // 43942917
            Console.WriteLine(employee02.GetHashCode()); // 59941933

            Console.WriteLine(employee01);
            Console.WriteLine(employee02);

            employee02 = employee01; // Shalow Copy

            Console.WriteLine("After Shalow Copy");

            Console.WriteLine(employee01.GetHashCode()); // 43942917
            Console.WriteLine(employee02.GetHashCode()); // 43942917

            Console.WriteLine(employee01);
            Console.WriteLine(employee02);


            Console.WriteLine(employee01.GetHashCode()); // 43942917
            Console.WriteLine(employee02.GetHashCode()); // 59941933

            Console.WriteLine(employee01);
            Console.WriteLine(employee02);

            employee02 = (Employee)employee01.Clone(); // Deep Copy
            employee02 = new Employee(employee01);     // Deep Copy

            Console.WriteLine("After Deep Copy");

            Console.WriteLine(employee01.GetHashCode()); // 43942917
            Console.WriteLine(employee02.GetHashCode()); // 2606490

            employee01.Id = 20;
            employee01.Name = "Omar";
            employee01.Salary = 7000;

            Console.WriteLine(employee01);
            Console.WriteLine(employee02);

            ////////////////////

            IComparable

           Employee[] employees = new Employee[]
           {
                new Employee{Id = 1, Name ="Mohamed",Salary = 9000},
                new Employee{Id = 2, Name ="Ali",Salary = 4300},
                new Employee{Id = 3, Name ="Omar",Salary = 34000},
                new Employee{Id = 4, Name ="Aya",Salary = 1000}
           };

            Array.Sort(employees);

            foreach (Employee employee in employees)
                Console.WriteLine(employee);

            /////////////////////////////



            List<int> list = new List<int>();
            list.Add(1);
            list.Add(36);
            list.Add(34);
            list.Add(23);
            Console.WriteLine($"Count: {list.Count} , Capacty: {list.Capacity}");
            list.Add(23);
            Console.WriteLine($"Count: {list.Count} , Capacty: {list.Capacity}");
            list.TrimExcess();
            Console.WriteLine($"Count: {list.Count} , Capacty: {list.Capacity}");

            Dictionary<string, int> Phone = new Dictionary<string, int>();

            Phone.Add("Ali", 123);
            Phone.Add("Mohamed", 123);
            Phone.Add("Hema", 123);
            Phone.Add("Aya", 123);

            Phone["Aya"] = 5;

            foreach (KeyValuePair<string, int> person in Phone)
                Console.WriteLine(person);


            del calculate = Calculator.Add;

            int Res = calculate.Invoke(2, 4);
            Console.WriteLine(Res);

            calculate += Calculator.Multiply;
            Res = calculate.Invoke(2, 4);
            Console.WriteLine(Res);

            int[] arr = { 100, 23, 90, 10, 53, 34, 67 };

            Func<int, int, bool> del1;
            del1 = (x, y) => x < y;
            //del1 += SortingAlgorithms.SortDsc;
            SortingAlgorithms<int>.BubbleSort(arr, del1);

            //SortingAlgorithms<int>.BubbleSort(arr, Calculator.SortAsc);

            foreach (int x in arr)
                Console.WriteLine(x);


            string[] arr = { "Mohamed", "Ali", "Hema", "Asraf" };

            SortingAlgorithms<string>.BubbleSort(arr, Calculator.SortStringDsc);

            foreach (string x in arr)
                Console.WriteLine(x);

            makesomecarbage();
            Console.WriteLine($"Before Clean {GC.GetTotalMemory(false):N0}");
            Console.WriteLine($"After Clean {GC.GetTotalMemory(true):N0}");

            A a1 = new A();

            Console.WriteLine(a1.classB.Name);




        }

        static void makesomecarbage()
        {
            Version v;
            for (int i = 0; i < 1000; i++) 
                v = new Version();

        }

        class A
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public B classB { get; set; }

            public A() => classB = new B(); 

            public class B
            {
                public int Id { get; set; }
                public string Name { get; set; }
            }

        }

    }
}
