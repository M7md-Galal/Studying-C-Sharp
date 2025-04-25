// Mohamed Galal
namespace CRUD_Operations
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            while (true)
            {
                
                Console.WriteLine("[1] Add User");
                Console.WriteLine("[2] Update User");
                Console.WriteLine("[3] Delete User");
                Console.WriteLine("[4] Search User");
                Console.WriteLine("[5] Show All Users");

                bool check = false;
                int inputUser = 0;
                do
                {
                    Console.Write("Enter Your Choice : ");
                    check = int.TryParse(Console.ReadLine(), out inputUser);
                    if (check == false)
                        Console.WriteLine("Invalid Input User");

                } while (check == false);

                User user = new User();
                switch (inputUser)
                {
                    case 1:
                        user.AddUser(users);
                        break;
                    case 2:
                        user.UpdateUser(users);
                        break;
                    case 3:
                        user.DeleteUser(users);
                        break;
                    case 4:
                        user.SearchUser(users);
                        break;
                    case 5:
                        user.ShowAllUsers(users);
                        break;
                    default:
                        break;

                }
            }
        }
    }
}
