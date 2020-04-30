using System;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> gl = new GenericList<int>(2);


            gl.AddElement(5);
            gl.AddElement(2);
            gl.AddElement(1);

            gl.InsertElement(4, 1);

            gl.PrintList();

            Console.WriteLine("Remove");
            gl.RemoveElement(2);

            gl.PrintList();

            Console.WriteLine("Get element: ");
            gl.GetElement(2);

            Console.WriteLine("Search: ");
            gl.Search(1);

            Console.WriteLine("Print array");
            gl.PrintArray();
        }
    }
}
