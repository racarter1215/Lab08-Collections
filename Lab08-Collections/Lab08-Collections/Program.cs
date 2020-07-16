using System;
using Lab08_Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Lab08_Collections
{
    class Program
    {//below is code that creates the Library and BookBag, which are instantiated in the Main method
        public static Library<Book> Library { get; set; }
        public static List<Book> BookBag { get; set; }
        /// <summary>
        /// below is a method that instantiates Library and Bookbag and calls two methods
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Library = new Library<Book>();
            BookBag = new List<Book>();

            LoadBooks();
            UserInterface();
        }

        /// <summary>
        /// below is a method that, when called, allows a user to interact with the app using preset options
        /// </summary>
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
                Console.WriteLine("3. Borrow a Book");
                Console.WriteLine("4. Return a Book");
                Console.WriteLine("5. View Book Bag");
                Console.WriteLine("Exit");

                string userInput = Console.ReadLine();
                ///below is code that runs when a user picks 1
                if (userInput == "1")
                {
                    Console.Clear();
                    ShowAllBooks();
                }
                ///below is code that runs when a user picks 2
                else if (userInput == "2")
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

                    AddABook(userTitle, userFirstName, userLastName);


                }
                ///below is code that runs when a user picks 3
                else if (userInput == "3")
                {
                    Console.Clear();

                    Dictionary<int, Book> books = new Dictionary<int, Book>();
                    Console.WriteLine("Please select a book. Only use available numbers.");
                    int counter = 1;
                    foreach (Book book in Library)
                    {
                        books.Add(counter, book);
                        Console.WriteLine($"{counter++}. {book.Title}, {book.Author.FirstName}, {book.Author.LastName}");
                    }

                    // we need to capture the user input. 
                    // user input will be the "key"
                    string input = Console.ReadLine();
                    // conver the input to a int
                    int option = int.Parse(input);
                    // let's GET The book from the library 
                    BookBag.Add(books[option]);

                    // let's remove from the library
                    Library.RemoveBook(option - 1);

                }
                ///below is code that runs when a user picks 5
                else if (userInput == "5")
                {
                    Console.Clear();

                    foreach (Book book in BookBag)
                    {
                        Console.WriteLine($"{book.Title}, {book.Author.FirstName}, {book.Author.LastName}");
                    }
                    break;
                }
                ///below is code that runs when a user picks 6
                else
                {
                    exit = true;
                    Environment.Exit(1);
                    break;
                }
            }

        }
        /// <summary>
        /// below is code that creates a book based off of user input for title, author, and genre
        /// </summary>
        /// <param name="title">the title of the book</param>
        /// <param name="firstName">the author's first name</param>
        /// <param name="lastName">the author's last name</param>
        static void AddABook(string title, string firstName, string lastName)
        {
            Book book = new Book()
            {
                Title = title,
                Author = new Author() { FirstName = firstName, LastName = lastName },
                Genre = Genre.SciFi
            };
            Library.AddBook(book);
        }
        /// <summary>
        /// when completed, the method below will load books into the bookshelf
        /// </summary>
        static void LoadBooks()
        {
            Book first = new Book { Title = "Alice in Wonderland", Author = new Author() { FirstName = "Lewis", LastName = "Carol" } };
            Book second = new Book { Title = "Green Eggs and Ham", Author = new Author() { FirstName = "Dr.", LastName = "Suess" }, Genre = Genre.Mystery };


            Library.AddBook(first);
            Library.AddBook(second);
        }


        /// <summary>
        /// Displays all books currently in the library to the user
        /// </summary>
        static void ShowAllBooks()
        {
            // how do we access all the itms in the library?

            foreach (Book book in Library)
            {
                Console.WriteLine(book.Title);
            }

        }


    }
}
