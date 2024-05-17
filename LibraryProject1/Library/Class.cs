using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Type { get; set; }
        public string Year { get; set; }
        public string Publisher { get; set; }
        public string Count { get; set; }
        public string ISBN { get; set; }
        public string Summary { get; set; }
        public string[] ItemArray => new[]
        {
            Title, Author, Genre, Type, Count,
            Year, Publisher, ISBN, Summary
        };

    }
}
