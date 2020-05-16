using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace NaukaNauka4
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu:
            Console.WriteLine("Press 1 if you want to create a new book. Press 2 to search a book by it's id. Pres 3 if you want to see a list of books. Press 4 to exit.");                                 //Menu
            string YesOrNo = Console.ReadLine();
            switch (YesOrNo)
            {
                case "1":
                    CreateOption();
                    Console.ReadKey();
                    Console.Clear();
                    goto Menu;
                case "2":
                    GetOption();
                    Console.ReadKey();
                    Console.Clear();
                    goto Menu;
                case "3":
                    ListOption();
                    Console.ReadKey();
                    Console.Clear();
                    goto Menu;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("wrong input");
                    break;
            }

            Console.ReadKey();


        }
        public static void GetOption()//An option to enable the Get method
        {
            BookRepository Repo = new BookRepository();
            Console.WriteLine("What's the id of the book you want to search?");
            int id = int.Parse(Console.ReadLine());
            Console.Clear();
            var book = Repo.Get(id);
            Console.WriteLine("Book Name: {0}", book.Name);
            Console.WriteLine("Book Release Date: {0}", book.ReleaseDate.ToString());
            Console.WriteLine("Book Author: {0}", book.Author);
            Console.WriteLine("Number of Pages: {0}", book.NumberOfPages.ToString());
            Console.WriteLine("Press any key to go back to the menu");
        }
        public static void CreateOption()//An option to enable the Create method
        {
            BookRepository Repo = new BookRepository();
            var book = new Book();
            Console.WriteLine("What's the name of the book?");
            book.Name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What's the release date of the book?");
            book.ReleaseDate = DateTime.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("What's the author of the book?");
            book.Author = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("How many pages does it have?");
            book.NumberOfPages = int.Parse(Console.ReadLine());
            Console.Clear();
            Repo.Create(book);
            Console.WriteLine("New book has been created in the database!");
            Console.WriteLine("Press any key to go back to the menu");
        }
        public static void ListOption()
        {
            BookRepository Repo = new BookRepository();
            var list = Repo.List();
            Console.WriteLine("The list:");
            foreach (Book book in list)
            {
                Console.WriteLine(book.Id.ToString(), book.Name, book.ReleaseDate.ToString(), book.Author, book.NumberOfPages.ToString());
            }
            Console.WriteLine("Press any key to go back to the menu");

        }

    }
}

