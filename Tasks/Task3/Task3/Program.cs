using System.Security.Cryptography;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// ===================> P1
            ///
            Point3D point3D = new Point3D(1, 2, 3);

            Console.WriteLine(point3D);

            // ==> try Parse
            Console.WriteLine("Enter coordinates for Point P1:");

            double x, y, z;

            Console.Write("Enter x: ");

            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Invalid input. Please enter a valid number for x.");
            }
            Console.Write("Enter y: ");
            while (!double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Invalid input. Please enter a valid number for y.");
            }
            Console.Write("Enter z: ");
            while (!double.TryParse(Console.ReadLine(), out z))
            {
                Console.WriteLine("Invalid input. Please enter a valid number for z.");
            }
            //Point3D p1 = new Point3D(x, y, z);
            //Console.WriteLine(p1);

            // ==> Parse (throws exception if input is wrong)

            //Console.WriteLine("Enter coordinates for Point P2:");

            try
            {
                Console.Write("Enter x: ");
                x = double.Parse(Console.ReadLine());
                Console.Write("Enter y: ");
                y = double.Parse(Console.ReadLine());
                Console.Write("Enter z: ");
                // Convert (similar to Parse, but handles nulls)
                z = Convert.ToDouble(Console.ReadLine());
                //Point3D p2 = new Point3D(x, y, z);
                //Console.WriteLine(p2);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("One of the inputs ofr the p2 not valid  number");
            }
            catch (Exception ex)
            {
                Console.WriteLine("error " + ex.Message);
            }
            Point3D P1 = new Point3D(1, 2, 3);
            Point3D P2 = new Point3D(1, 2, 4);
            if (P1 == P2)
                Console.WriteLine("Points are equal");
            else
                Console.WriteLine("Points are not equal");

            Point3D[] point3Ds = new Point3D[]
            {
                new Point3D(1, 2, 3),
                new Point3D(4, 2, 7),
                new Point3D(8, 9, 4),
                new Point3D(2, 2, 5)
            };
            Array.Sort(point3Ds, (p1, p2) => p1.x.CompareTo(p2.x));

            var sortedPoints = point3Ds
                .OrderBy(p => p.x)
                .ThenBy(p => p.y)
                .ThenBy(p => p.z)
                .ToArray();

            Array.Sort(point3Ds);

            foreach (Point3D point in point3Ds)
            {
                Console.WriteLine(point);
            }

            Point3D p1 = new Point3D(1, 2, 3);
            Point3D p2 = (Point3D)p1.Clone();

            Console.WriteLine("Original: " + p1);
            Console.WriteLine("Clone: " + p2);
            p1.x = 6;
            Console.WriteLine("Comparison result: " + p1.CompareTo(p2)); // print 0 if p1 and p2 are equal otherwise print -1 or 1

            // ===================> P2
            Maths math = new Maths();

            double X = 10;
            double Y = 5;

            Console.WriteLine($"Add: {X} + {Y} = {Maths.Add(x, Y)}");
            Console.WriteLine($"Subtract: {X} - {Y} = {Maths.Subtract(X, Y)}");
            Console.WriteLine($"Multiply: {X} * {Y} = {Maths.Multiply(X, Y)}");
            Console.WriteLine($"Divide: {X} / {Y} = {Maths.Divide(X, Y)}");


             //// ====================== P3

            Duration duration1 = new Duration(2, 30, 45);
            Duration duration2 = new Duration(2, 30, 45);
            Duration duration3 = new Duration(1, 45, 30);


            Console.WriteLine(duration1.ToString());

            Console.WriteLine(duration1.Equals(duration2));
            Console.WriteLine(duration1.Equals(duration3));

            Console.WriteLine(duration1.GetHashCode());
            Console.WriteLine(duration2.GetHashCode());
            Console.WriteLine(duration3.GetHashCode());

            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString()); 

            Duration D2 = new Duration(3600);
            Console.WriteLine(D2.ToString()); 

            Duration D3 = new Duration(7800);
            Console.WriteLine(D3.ToString()); 

            Duration D4 = new Duration(666);
            Console.WriteLine(D4.ToString());
        }
    }
}
