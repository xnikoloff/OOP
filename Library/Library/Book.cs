using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Book
    {
        private string name;
        private string author;
        private string press;
        private int year;
        private string isbn;

        public Book(string name, string author, string press, int year, string isbn)
        {
            this.name = name;
            this.author = author;
            this.press = press;
            this.year = year;
            this.isbn = isbn;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Author
        {
            get { return this.author; }
            set { this.author = value; }
        }

        public string Press
        {
            get { return this.press; }
            set { this.press = value; }
        }

        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        public string ISBN
        {
            get { return this.isbn; }
            set { this.isbn = value; }
        }
    }
}
