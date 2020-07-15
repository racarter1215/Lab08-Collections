using System;
using System.Collections.Generic;

namespace Lab08_Collections
{
    class Program
    {
        public static Library<Book> Library { get; set; }
        public static List<Book> BookBag { get; set; }
        static void Main(string[] args)
        {
            Library = new Library<Book>();
            BookBag = new List<Book>();

            LoadBooks();
            UserInterface();
        }

        static void UserInterface()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine();

                Console.WriteLine("Welcome to Phil’s Lending Library");
                Console.WriteLine("Please select one of the options below");
                Console.WriteLine("1. View all Books");
                Console.WriteLine("2. Add a Book");
                Console.WriteLine("Borrow a Book");
                Console.WriteLine("Return a Book");
                Console.WriteLine("View Book Bag");
                Console.WriteLine("Exit");

                string userInput = Console.ReadLine();

                if(userInput == "1")
                {
                    Console.Clear();
                    ShowAllBooks();
                }
                else if(userInput == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Please fill out the following information:");
                    Console.WriteLine("Title: ");
                    string userTitle = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("Author First Name: ");
                    string userFirstName = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("Author Last Name: ");
                    string userLastName = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("Book Length: ");
                    string userBookLength = Console.ReadLine();
                    Console.WriteLine();

                    
                }
            }
        }
    }
}
