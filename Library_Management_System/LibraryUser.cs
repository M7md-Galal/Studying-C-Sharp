using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class LibraryUser : User
    {
        public LIbraryCard Card { get; set; }


        public LibraryUser(string name)
        {
            Name = name;
        }

        public void BorrowBook(Book book , Library library)
        {
            // Add logic
            library.BorrowedBook(book);
        }

    }
}
