using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Livro
{
    public class Book
    {
        public string Title;
        public string Author { get; set; }
        public string ISBN;
        public int PublicationYear { get; set; }
        public string Style { get; set; }
        public int NumPages { get; set; }
        public string CountryPublication { get; set; }

        public Book(string isbn, string title)
        {
            this.Title = title;
            this.ISBN = isbn;
        }
    }
}
