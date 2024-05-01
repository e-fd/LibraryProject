using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    internal class Book
    {
        private int listIndex;          // индекс объекта в списке listBox1 (Form1)
        private static int bookCounter; // статический счетчик книг
        public int BookId { get; set; }          // свойства объектов класса Book
        public string? Title { get; set; }       //
        public string? Author { get; set; }      //
        public string? Genre { get; set; }       //
        public string? Description { get; set; } //
        public string? Type { get; set; }       //
        public string? Publisher { get; set; }   //
        public int? Year { get; set; }           //
        public Book(string? title)               // (1) конструкторы для объектов класса Book
        {
            Title = title;
            BookId = bookCounter++; // присваивание ID книге при создании объекта
        }
        public Book(string? title, string? author) : this(title) // (1)
        {                                        // вызов предыдущего
            Author = author;                     // конструктора
        }
        public Book(string? title, string? author, string? genre) :
            this(title, author) // (1)
        {
            Genre = genre;
        }
        public Book(string? title, string? author, string? genre, string? description) :
            this(title, author, genre) // (1)
        {
            Description = description;
        }
        public Book(string? title, string? author, string? genre, string? description, string? type) :
            this(title, author, genre, description) // (1)
        {
            Type = type;
        }
        public Book(string? title, string? author, string? genre, string? description,
            string? type, string? publisher) :
            this(title, author, genre, description, type) // (1)
        {
            Publisher = publisher;
        }
        public Book(string? title, string? author, string? genre, string? description,
            string? type, string? publisher, int? year) :
            this(title, author, genre, description, type, publisher) // (1)
        {
            Year = year;
        }
        public int GetListIndex() // возврат значения переменной listIndex
        {
            return listIndex;
        }
        public void SetListIndex(int value) // установка значения переменной listIndex
        {
            listIndex = value;
        }
        public int GetBookCounter() // возврат значения переменной bookCounter
        {
            return bookCounter;
        }
        public void SetBookCounter(int value) // установка значения переменной bookCounter
        {
            bookCounter = value;
        }
    }
}
