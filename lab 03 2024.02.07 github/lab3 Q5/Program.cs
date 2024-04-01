using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_Q5
{

    public class LibraryBook
    {
        public string Title;
        public string Author;
        public bool Available;

        public LibraryBook(string title, string author)
        {
            Title = title;
            Author = author;
            Available = true;
        }
        public void BorrowBook()
        {
            if (Available)
            {
                Available = false;
                Console.WriteLine($"Book '(Title)' by {Author} has been borrowed");
            }
            else
            {
                Console.WriteLine($"sorry, '(Title)' by {Author} is not available for borrowing");
            }
        }

    }

    class program
    {
        static void Main()
        {
            LibraryBook[] books = new LibraryBook[3];
            books[0] = new LibraryBook("The Great Gatsby", "F. Scott Fitzgerald");
            books[1] = new LibraryBook("To Kill a Mockingbird", "Harper Lee");
            books[2] = new LibraryBook("1984", "George Orwell");

            books[0].BorrowBook();
            books[1].BorrowBook();
            books[2].BorrowBook();

            DisplayLibraryStatus(books);

            Console.ReadLine();
        }


        static void DisplayLibraryStatus(LibraryBook[] books)
        {
            Console.WriteLine("\n Library status");

            for (int i = 0; i < books.Length; i++)
            {
                LibraryBook book = books[i];
                Console.WriteLine("{book.Title} by { book.Author} - Available: { book.Available}");
            }

            Console.WriteLine();
        }
    }
}

