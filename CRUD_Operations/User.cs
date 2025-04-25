using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Operations
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }

        
        public void AddUser(List<User> users)
        {
            Console.WriteLine($"============================Add User================================");
            Console.WriteLine("Enter The User ID");
            short inputID = short.Parse(Console.ReadLine());
            Console.WriteLine("Enter User Name");
            string inputName = Console.ReadLine();
            Console.WriteLine("Enter The User Phone");
            string inputPhone = Console.ReadLine();
            Console.WriteLine("Enter You Gender");
            string inputGender = Console.ReadLine();

            User NewUser = new User
            {
                ID = inputID,
                Name = inputName,
                Phone = inputPhone,
                Gender = inputGender
            };
            users.Add(NewUser);

            Console.WriteLine("The User Added Sucsessfuly");
            Console.WriteLine($"User ID : {NewUser.ID}\nUser Name : {NewUser.Name}\nUser Phone : {NewUser.Phone}\nUser Phone : {NewUser.Gender}");

        }
        public void UpdateUser(List<User> users)
        {
            Console.WriteLine($"============================ Update User ================================");

            Console.WriteLine("Enter The ID You Want To Update");
            int inputID = int.Parse(Console.ReadLine());

            User GetPhoneOutOfList = users.FirstOrDefault(x => x.ID == inputID);
             
            bool flag = false;
            if(GetPhoneOutOfList != null)
            {
                Console.WriteLine("[1] Update Name\n[2] Update Phone\n[3] Update Gender");
                short inputChoice = short.Parse(Console.ReadLine());

                if(inputChoice == 1)
                {
                    Console.Write("Enter Your New Name : ");
                    string NewName = Console.ReadLine();
                    GetPhoneOutOfList.Name = NewName;
                    flag = true;
                }
                else if(inputChoice == 2)
                {
                    Console.Write("Enter New Phone : ");
                    string NewPhone = Console.ReadLine();
                    GetPhoneOutOfList.Phone = NewPhone;
                    flag = true;
                }
                else if (inputChoice == 3)
                {
                    Console.Write("Enter New Gender : ");
                    string NewGender = Console.ReadLine();
                    GetPhoneOutOfList.Gender = NewGender;
                    flag = true;
                }
                else
                {
                    Console.WriteLine("Wrong Number Try Again From First");
                }

                if (flag == true)
                {
                    Console.WriteLine($"============================New User Information you Edited================================");
                    Console.WriteLine($"ID: {GetPhoneOutOfList.ID}");
                    Console.WriteLine($"Name: {GetPhoneOutOfList.Name}");
                    Console.WriteLine($"Phone: {GetPhoneOutOfList.Phone}");
                    Console.WriteLine($"Gender: {GetPhoneOutOfList.Gender}");
                }
            }
            else
            {
                Console.WriteLine("No user Like this");
            }
        }
        public void DeleteUser(List<User> users)
        {
            Console.WriteLine($"============================ Delete User ================================");
            Console.Write("Enter The ID You Want To Delete : ");
            int inputID = int.Parse(Console.ReadLine());
            User GetPhoneOutOfList = users.FirstOrDefault(x => x.ID == inputID);
            if(GetPhoneOutOfList != null)
            {
                users.Remove(GetPhoneOutOfList);
                Console.WriteLine("The User Deleted Sucsessfully");
            }
            else
            {
                Console.WriteLine("No user Like this");
            }
        }
        public void SearchUser(List<User> users)
        {
            Console.WriteLine($"============================ Search User ================================");
            Console.Write("Enter The ID User You Want To Search : ");
            int inputID = int.Parse(Console.ReadLine());
            if(users.Exists(x => x.ID == inputID))
            {
                foreach(User SearchID in users)
                {
                    if(SearchID.ID == inputID)
                    {
                        Console.WriteLine($"User ID : {SearchID.ID}\nUser Name : {SearchID.Name}\nUser Phone : {SearchID.Phone}\nUser Phone : {SearchID.Gender}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No user Like this");
            }
        }
        public void ShowAllUsers(List<User> users)
        {

            int count = 1;
            if (users.Count == 0)
            {
                Console.WriteLine($"===================================================================");

                Console.WriteLine("No users to print");
            }
            else
            {
                Console.WriteLine($"============================Print All User================================");
            }

            foreach (dynamic user in users)
            {
                Console.WriteLine($"User {count}");
                Console.WriteLine($"User ID : {user.ID}");
                Console.WriteLine($"User Name : {user.Name}");
                Console.WriteLine($"User Phone : {user.Phone}");
                Console.WriteLine($"User Gender : {user.Gender}");
                count++;
                if (count <= users.Count)
                {
                    Console.WriteLine("----------------");
                }
            }
        }
    }
}
