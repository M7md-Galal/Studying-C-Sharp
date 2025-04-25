namespace Task1
{
    enum WeekDays
    {
        Saturday = 1, Sunday =2,Monday=3,Tuesday=4,Wednesday=5,Thursday=6,Friday=7
    }
    struct Person
    {
        public int _Id { get; set; }
        public string _Name { get; set; }
        public int _Age { get; set; }
    }
    enum Seasons
    {
        Spring, Summer, Autumn, Winter
    }
    enum Colors
    {
        Red = 0,
        Green = 1,
        Blue = 2,
    }

    [Flags]
    enum Permessions : byte
    {
        Read =1,
        Write =2,
        Delete =4,
        Execute =8
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // ===========>> 1
            foreach (var item in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(item);

                //  ==========>> 2
                Person[] persons =
                {
                new Person { _Id = 1,_Name = "Mohamed",_Age =21 },
                new Person { _Id = 2,_Name = "Ali",_Age=22},
                new Person { _Id = 3 , _Name = "Ahmed" , _Age = 23}
            };
                foreach (Person person in persons)
                {
                    Console.WriteLine($"Id => {person._Id}\nName => {person._Name}\nAge => {person._Age}");
                }
                //  ==========>> 3
                Console.WriteLine("Enter The Season Name ?");
                string input = Console.ReadLine();

                Seasons seasons;
                if (Enum.TryParse(input, out seasons))
                {
                    switch (seasons)
                    {
                        case Seasons.Spring:
                            Console.WriteLine("March To May");
                            break;
                        case Seasons.Summer:
                            Console.WriteLine("June To August");
                            break;
                        case Seasons.Autumn:
                            Console.WriteLine("September To November");
                            break;
                        case Seasons.Winter:
                            Console.WriteLine("December To February");
                            break;
                    }

                }
                //  ==========>> 4
                Console.WriteLine("Enter The Color Name ?");
                string _input = Console.ReadLine();
                Colors color;
                if (Enum.TryParse(_input, true, out color))
                    Console.WriteLine("Primary Color");
                else
                    Console.WriteLine("Not Primary Color");
                //  ==========>> 5
                Permessions permession = Permessions.Execute;
                permession ^= Permessions.Read;
                permession |= Permessions.Write;

                if ((permession & Permessions.Delete) == Permessions.Delete)
                    Console.WriteLine("Permession is Found");
                else
                    Console.WriteLine("Permession is Not Found");

            }
        }
    }
}
