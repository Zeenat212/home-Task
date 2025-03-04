using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
    internal class Book
    {
        public string Title;
        public string Author;
        public string ISBN;
        public double Price;


        public void DisplayBookInfo()
        {
            Console.WriteLine("Book Info is :");
            Console.WriteLine($"Book Title is {Title}");
            Console.WriteLine($"Book Author is {Author}");
            Console.WriteLine($"Book ISBN is {ISBN}");
            Console.WriteLine($"Book Price is {Price}");
        }
        public void ApplyDiscount(double percentage)
        {
             if(percentage >= 0 && percentage <= 100)
            {
                Price=Price-(Price*percentage/100);
                Console.WriteLine($"Discount Applied is {Price} ");
            }
            else
            {
                Console.WriteLine("Invalid Discount Percentage");
            }
        }

    }
}
