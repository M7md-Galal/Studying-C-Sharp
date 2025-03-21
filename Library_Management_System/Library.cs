using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class Library
    {
        private Book[] books = new Book[100];
        private Book[] BorrowedBooks = new Book[50];

        int countbooks = 0;
        int countborrewbook = 0;
        public void AddBook(Book book)
        {
            // Add logic
            if(countbooks<books.Length)
            {
                books[countbooks] = book;
                countbooks++;
                Console.WriteLine("The Book Added Sucessfuly");
            }
            else
            {
                Console.WriteLine("The Libaray is Full");
            }
        }
        public void RemoveBook(Book book)
        {
            // Add logic
           // int index = Array.IndexOf(books, book);
           // books[index] = null;
           //countbooks--;
           for(int i=0;i<countbooks;i++)
            {
                if (books[i] == book)
                {
                    books[i] = null;
                    countbooks--;
                    break;
                }
            }
           Console.WriteLine("The Book Removed Sucessfuly");
        }
        public void Display()
        {
            // Add logic
            for(int i=0;i<countbooks; i++)
            {
                Console.WriteLine($"Title : {books[i].Title}\nAuther : {books[i].Auther}\nYear : {books[i].Year}");
            }
        }

        public void BorrowedBook(Book book)
        {
            if (countborrewbook < BorrowedBooks.Length)
            {
                books[countborrewbook] = book;
                countborrewbook++;
                Console.WriteLine("The Book Borrowed Sucessfuly");
            }
            else
            {
                Console.WriteLine("The Libaray is Full");
            }
        }
    }
}
