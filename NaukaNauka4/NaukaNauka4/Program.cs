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
            Book book = new Book();
            BookRepository repository = new BookRepository();

            Console.WriteLine("Press 1 if you want to create a new book or press 2 to search a book by it's id");                                 //Menu
            string YesOrNo = Console.ReadLine();
            switch (YesOrNo)
            {
                case "1":
                    CreateOption();
                    break;
                case "2":
                    GetOption();
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
        }

    }
}

