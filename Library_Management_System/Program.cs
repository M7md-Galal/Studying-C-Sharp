namespace Library_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            Console.WriteLine("\n\n\t\t====================== Welcome to Library Managment System ======================\n\n");
            Console.WriteLine("Are you Admin Or User (A/U)");
            char input = Console.ReadLine().ToUpper()[0];
            if(input =='A')
            {
                Console.WriteLine("Enter your Name");
                string name = Console.ReadLine();
                Librarian librarian = new Librarian(name);
                Console.WriteLine($"========  Hi {librarian.Name}  ========");
                while (true)
                {
                    Console.WriteLine("(((((   Are You Want ADD Book [A]   )))))");
                    Console.WriteLine("((((( Are You Want Remove Book [R]  )))))");
                    Console.WriteLine("((((( Are You Want Display Book [D] )))))");
                    char inputAdmin = Console.ReadLine().ToUpper()[0];
                    switch (inputAdmin)
                    {
                        case 'A':
                            Console.WriteLine("Enter The Book Detalis");
                            string title = Console.ReadLine();
                            string auther = Console.ReadLine();
                            int year = int.Parse(Console.ReadLine());
                            Book book1 = new Book()
                            {
                                Title = title,
                                Auther = auther,
                                Year = year
                            };
                            librarian.AddBook(book1, library);
                            break;

                        case 'R':
                            Console.WriteLine("Enter The Book You Want to Remove");
                            string titleRemoved = Console.ReadLine();
                            string autherRemoed = Console.ReadLine();
                            int yearRemoved = int.Parse(Console.ReadLine());
                            Book book2 = new Book()
                            {
                                Title = titleRemoved,
                                Auther = autherRemoed,
                                Year = yearRemoved
                            };
                            librarian.RemoveBook(book2, library);
                            break;
                        case 'D':
                            Console.WriteLine("The Book List :");
                            librarian.DisblyBooks(library);
                            break;
                        default:
                            Environment.Exit(0);
                            break;
                    }
                }
            }
            else if(input == 'U')
            {
                Console.WriteLine("Enter your Name");
                string libraryUsername = Console.ReadLine();
                LibraryUser libraryUser = new LibraryUser(libraryUsername);
                Console.WriteLine($"========  Hi {libraryUser.Name}  ========");

                while (true)
                {
                    Console.WriteLine("((((( Are You Want Borrow Book [B]  ))))");
                    Console.WriteLine("((((( Are You Want Display Book [D] )))))");
                    char inputAdmin = Console.ReadLine().ToUpper()[0];
                    switch (inputAdmin)
                    {
                        case 'B':
                            Console.WriteLine("Enter The Book Detalis");
                            string title = Console.ReadLine();
                            string auther = Console.ReadLine();
                            int year = int.Parse(Console.ReadLine());
                            Book book1 = new Book()
                            {
                                Title = title,
                                Auther = auther,
                                Year = year
                            };
                            libraryUser.BorrowBook(book1, library);
                            break;

                        case 'D':
                            Console.WriteLine("The Book List :");
                            libraryUser.DisblyBooks(library);
                            break;
                        default:
                            Environment.Exit(0);
                            break;
                    }
                }
            }
        }
    }
}
