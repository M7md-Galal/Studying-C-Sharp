using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class Librarian : User
    {
        public int EmpNumber { get; set; }

        public Librarian(string name) 
        {
            Name = name;
        }
        public void AddBook(Book book , Library library)
        {
            // Add logic
            library.AddBook(book);
        }
        public void RemoveBook(Book book , Library library)
        {
            // Add logic
            library.RemoveBook(book);
        }
    }
}
