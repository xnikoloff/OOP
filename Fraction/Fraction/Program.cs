using System;

namespace Fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction = new Fraction(10, 15);
           
            Console.WriteLine($"Property result: {fraction.Result}");

            decimal expressionResult = Fraction.Parse("1/2");
            Console.WriteLine($"Result of parsing: {expressionResult}");

            fraction.ReduceFraction();
        }
    }
}
