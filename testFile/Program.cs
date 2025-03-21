using System.IO;
using System.Runtime.CompilerServices;

namespace testFile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Read File
            //StreamReader st = new StreamReader(@"D:\file.txt");
            //string line;
            //while((line = st.ReadLine()) != null)
            //{
            //    Console.WriteLine(line);
            //}

            //string[] res = File.ReadAllLines(@"D:\file.txt");
            //foreach (string line in res)
            //{
            //    Console.WriteLine(line);
            //}

            // Wite File

            //string filepath = @"D:\file.txt";
            //StreamWriter writer = new StreamWriter(filepath);
            //writer.Write("input file");
            //writer.Close();

            // Append file

            //File.Create(@"D:\file.txt");

            //if(!File.Exists(@"D:\file.txt"))
            //{
            //    Console.WriteLine("the file is not eXist");
            //    return;
            //}
            //string content = "Mohamed Galal\n";
            //for (int i=1;i<=100;i++)
            //{
            //    File.AppendAllText(@"D:\file.txt", content);
            //}
            File.WriteAllText(@"D:\file.txt", "Mohamed");
        }
    }
}
