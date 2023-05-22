using System;

namespace _01.Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine();

            int bookCount = 0;

            while (favoriteBook != "No More Books")
            {
                string book = Console.ReadLine();

                if(book == favoriteBook)
                {
                    Console.WriteLine($"You checked {bookCount} books and found it.");
                    break;
                }

                if (book == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {bookCount} books.");
                    break;
                }

                bookCount++;

            }
           


        }
    }
}
