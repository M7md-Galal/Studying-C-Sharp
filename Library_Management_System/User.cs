using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public abstract class User
    {
        public string Name { get; set; }

        public void DisblyBooks(Library library)
        {
            // Add logic
            library.Display();
        }
    }
}
