using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Title = "Programming";
            book1.Author = "Waqar";
            book1.ISBN = "2335637";
            book1.Price = 20.0;
            book1.DisplayBookInfo();
            book1.ApplyDiscount(10);
            Console.Write("Updated Book Details: ");
            book1.DisplayBookInfo();
        }
    }
}
