using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Library
    {
         private string name;
            private List<Book> booksList = new List<Book>();

            public Library(string name)
            {
                this.name = name;
            }

            public void AddBook(string name, string author, string press, int year, string isbn)
            {
                booksList.Add(new Book(name, author, press, year, isbn));
            }

            public void SearchBookByAuthor(string author)
            {
                for (int i = 0; i < booksList.Count; i++)
                {
                    if (author.Equals(booksList[i].Author))
                    {
                        Console.WriteLine($"{BooksList[i].Name}, " +
                                       $"{BooksList[i].Author}, " +
                                       $"{BooksList[i].Press}, " +
                                       $"{BooksList[i].Year}, " +
                                       $"{BooksList[i].ISBN}");
                    }

                }
            }

            private int GetBookIndex(string name, List<Book> bookList)
            {
                int bookIndex = -1;
                for (int i = 0; i < bookList.Count; i++)
                {
                    if (bookList[i].Name == name)
                    {
                        bookIndex = i;
                    }
                }

                return bookIndex;
            }

            public void PrintBookInfo(string bookName)
            {
                int bookIndex = GetBookIndex(bookName, booksList);

                try
                {
                    Console.WriteLine($"Info about: {booksList[bookIndex].Name} by {booksList[bookIndex].Author}");
                    Console.WriteLine
                        (
                            $"Title: {booksList[bookIndex].Name}\n" +
                            $"Author: {booksList[bookIndex].Author}\n" +
                            $"Press: {booksList[bookIndex].Press}\n" +
                            $"Year: {booksList[bookIndex].Year}\n" +
                            $"ISBN: {booksList[bookIndex].ISBN}"
                        );
                }

                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("No such book.");
                }
            }

            public void PrintAllBooksInfo()
            {
                Console.WriteLine("This is the whole library: ");
                Console.WriteLine();
                for (int i = 0; i < booksList.Count; i++)
                {
                    Console.WriteLine($"Info about: {booksList[i].Name} by {booksList[i].Author}");
                    Console.WriteLine
                        (
                            $"Title: {booksList[i].Name}\n" +
                            $"Author: {booksList[i].Author}\n" +
                            $"Press: {booksList[i].Press}\n" +
                            $"Year: {booksList[i].Year}\n" +
                            $"ISBN: {booksList[i].ISBN}"
                        );

                    Console.WriteLine();
                }

            }

            public void DeleteBook(string name)
            {
                int bookIndex = GetBookIndex(name, booksList);

                try
                {
                    booksList.Remove(booksList[bookIndex]);
                }

                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("No book was deleted.");
                }
            }

            public void DeleteBook(string name, string author)
            {
                int i;

                for (i = 0; i < booksList.Count; i++)
                {
                    if (i > booksList.Count)
                    {
                        break;
                    }

                    if (booksList[i].Name == name || booksList[i].Author == author)
                    {
                        booksList.Remove(booksList[i]);
                        i--;
                    }
                }
            }

            public void PrintBooksList()
            {
                for (int i = 0; i < booksList.Count; i++)
                {
                    Console.WriteLine
                        (
                            $"Title: {booksList[i].Name}\n" +
                            $"Author: {booksList[i].Author}\n" +
                            $"Press: {booksList[i].Press}\n" +
                            $"Year: {booksList[i].Year}\n" +
                            $"ISBN: {booksList[i].ISBN}"
                        );

                    Console.WriteLine();
                }
            }

            public void ClearBooksList()
            {
                for (int i = 0; i < booksList.Count; i++)
                {
                    booksList.Remove(booksList[i]);
                    i--;
                }
            }

            public string Name
            {
                get { return this.name; }
                set { this.name = value; }
            }

            public List<Book> BooksList
            {
                get { return this.booksList; }
                set { this.booksList = value; }
            }
        }
}
