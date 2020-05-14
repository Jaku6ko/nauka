using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace NaukaNauka4
{
    public class Book
    {
        public int id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Author { get; set; }
        public int NumberOfPages { get; set; }
    }
}
