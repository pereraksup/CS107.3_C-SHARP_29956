using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    
    
        class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }

        public void DisplayInformation()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Pages: " + Pages);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an object of the Book class
            Book myBook = new Book();

            // Set values for the properties
            myBook.Title = "Sample Title";
            myBook.Author = "John Doe";
            myBook.Pages = 200;

            // Display the information on the console
            myBook.DisplayInformation();
        }
    }


}


