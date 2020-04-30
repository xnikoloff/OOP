using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Library libraryPlovdiv = new Library("People's Library of Plovdiv \"Ivan Vazov\"");

            libraryPlovdiv.AddBook("Pod Igoto", "Ivan Vazov", "Koala Press", 1893, "3782123456803");
            libraryPlovdiv.AddBook("Indzhe", "Yordan Yovkov", "Koala Press", 1927, "3785183426813");
            libraryPlovdiv.AddBook("Rich Man, Poor Man", "Irwin Shaw", "Koala Press", 1969, "3785183426813");
            libraryPlovdiv.AddBook("Po Zhitsata", "Elin Pelin", "Koala Press", 1904, "37841834126813");
            libraryPlovdiv.AddBook("The Shining", "Stephen King", "Koala Press", 1977, "3785183426813");
            libraryPlovdiv.AddBook("The Stand", "Stephen King", "Koala Press", 1978, "3782183416813");
            libraryPlovdiv.AddBook("Misery", "Stephen King", "Koala Press", 1987, "3785883422813");

            Console.WriteLine("Print the whole library: ");
            Console.WriteLine("--------------------------");
            libraryPlovdiv.PrintAllBooksInfo();

            Console.WriteLine("------------------------");
            Console.WriteLine("pt. 2");
            Console.WriteLine("Print all books by Stephen King");
            Console.WriteLine();

            libraryPlovdiv.SearchBookByAuthor("Stephen King");

            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine("Delete books by Stephen King");
            Console.WriteLine();

            libraryPlovdiv.DeleteBook("Stephen King");

            Console.WriteLine();
            Console.WriteLine("-----------------------");
            Console.WriteLine("Delete books by Stephen King: ");
            Console.WriteLine();

            libraryPlovdiv.DeleteBook("", "Stephen King");
            libraryPlovdiv.PrintBooksList();
            Console.WriteLine();

            Console.WriteLine("-----------------------");
            Console.WriteLine("pt. 3 Clear books list");
            Console.WriteLine("------------------------");
            Console.WriteLine();

            libraryPlovdiv.ClearBooksList();
            libraryPlovdiv.PrintBooksList();
        }
    }
}
