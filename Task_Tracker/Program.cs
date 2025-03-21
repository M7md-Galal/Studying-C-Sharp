namespace Task_Tracker
{
    internal class Program
    {
        static string[] Tasks = new string[100];
        static int TaskIndex = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Task Tracker");
            Console.WriteLine("==========================");

            while (true)
            {
                Console.WriteLine("[1] Add Task");
                Console.WriteLine("[2] View Tasks");
                Console.WriteLine("[3] Mark Task Completed");
                Console.WriteLine("[4] Remove Task");
                Console.WriteLine("[5] Exit");

                Console.Write("Please Choise Number ? : ");
                string choise;
                choise = Console.ReadLine();
                switch (choise)
                {
                    case "1":
                        Add_Task();
                        Console.WriteLine("==========================");
                        break;
                    case "2":
                        View_Tasks();
                        Console.WriteLine("==========================");
                        break;
                    case "3":
                        Mark_Task_Completed();
                        Console.WriteLine("==========================");
                        break;
                    case "4":
                        Remove_Task();
                        Console.WriteLine("==========================");
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Choise");
                        break;
                }
            }
        }
        public static void Add_Task()
        {
            Console.Write("Enter The Task Title : ");
            string userInput = Console.ReadLine();
            Tasks[TaskIndex] = userInput;
            TaskIndex++;
        }
        public static void View_Tasks()
        {
            Console.WriteLine("List of Tasks :");
            for(int i=0;i<TaskIndex;i++)
            {
                Console.WriteLine($"Title {i+1} : {Tasks[i]}");
            }
                
        }
        public static void Mark_Task_Completed()
        {
            Console.Write("Enter The Task Number : ");
            string userInput = Console.ReadLine();
            int TaskNumber = Convert.ToInt32(userInput);
            Tasks[TaskNumber] += " >> Completed";
        }
        public static void Remove_Task()
        {
            Console.Write("Enter The Task Number : ");
            string userInput = Console.ReadLine();
            int TaskNumber = Convert.ToInt32(userInput);

            Tasks[TaskNumber] = string.Empty;
            Console.WriteLine("Task Removed Sucessfuly");
        }
    }
}
