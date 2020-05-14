using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace NaukaNauka4
{
    public class BookRepository
    {
        public Book Get(int id)//Method that searches given book in the database
        {

            id = int.Parse(Console.ReadLine());
            string commandLine = string.Format("SELECT * FROM books WHERE id ={0})", id);
            var connection = getConnection();
            connection.Open();
            var command = new SqlCommand(commandLine, connection);
            var result = command.ExecuteReader();
            result.Read();
            var book = FillBook(result);
            connection.Close();
            return book;
        }
        //  public List<Book> List(int Limit = 5)//idk yet
        //     {

        //     }
        public void Create(Book book)//Method that creates a new book in the database
        {
            string commandLine = string.Format("INSERT INTO products VALUES('{0}', '{1}', '{2}', '{3}')", book.Name, book.ReleaseDate.ToString("dd-MM-yyyy"), book.Author, book.NumberOfPages);
            var connection = getConnection();
            var command = new SqlCommand(commandLine, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        private SqlConnection getConnection()//Method that establishes connection to the database
        {
            return new SqlConnection(@"Data Source=JAKUB\SQLEXPRESS
                Initial Catalog=book_database;
                Integrated Security=True;
                Connect Timeout=30;
                Encrypt=False;
                TrustServerCertificate=False;
                ApplicationIntent=ReadWrite;
                MultiSubnetFailover=False"
                );
        }
        public Book FillBook(SqlDataReader result)//Method that fills the book variable with database info
        {
            var Book = new Book();
            Book.id = (int)result.GetValue(0);
            Book.Name = (string)result.GetValue(1);
            Book.ReleaseDate = (DateTime)result.GetValue(2);
            Book.Author = (string)result.GetValue(3);
            Book.NumberOfPages = (int)result.GetValue(4);
            return Book;

        }
    }
}
