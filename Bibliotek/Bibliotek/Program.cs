using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotek
{
    class Program
    {
        static void Main(string[] args)
        {
            Book harryPotter1 = new Book("Harry Potter and the philosophers stone", "Jane Kathleen Rowling", 1997, 30, 400);
            Book harryPotter2 = new Book("Harry Potter and the chamber of secrets", "Jane Kathleen Rowling", 1998, 28, 400);
            Book harryPotter3 = new Book("Harry Potter and the Prisoner of Azkaban", "Jane Kathleen Rowling", 1999, 30, 350);
            Book harryPotter4 = new Book("Harry Potter and the Triwizard tournament", "Jane Kathleen Rowling", 2000, 30, 450);
            Book harryPotter5 = new Book("Harry Potter and the order of the phoenix", "Jane Kathleen Rowling", 2003, 28, 500);
            Book harryPotter6 = new Book("Harry Potter and the half blood prince", "Jane Kathleen Rowling", 2005, 30, 400);
            Book harryPotter7 = new Book("Harry Potter and the deadly hallows", "Jane Kathleen Rowling", 2007, 30, 500);
        }
    }        
}
