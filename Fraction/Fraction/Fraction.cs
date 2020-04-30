using System;
using System.Collections.Generic;
using System.Text;

namespace Fraction
{
    class Fraction
    {
        private decimal numerator;
        private decimal denominator;
        private decimal result;

        public Fraction(decimal numerator, decimal denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
            this.result = this.numerator / this.denominator;
        }

        //extract the numbers from the string fraction and convert them to decimals
        private static decimal[] GetFractionNumbers(string expression)
        {
            string[] operandsString = new string[expression.Length - 1];
            decimal[] operandsDecimal = new decimal[operandsString.Length];

            try
            {
                //store the numbers in a string array as spliting the numbers by '/'
                operandsString = expression.Split('/'); 

                //convert the string numbers to decimal numbers
                operandsDecimal[0] = Convert.ToDecimal(operandsString[0]);
                operandsDecimal[1] = Convert.ToDecimal(operandsString[1]);
            }

            catch (ArgumentException)
            {
                Console.WriteLine("Convertion was not successful.");
            }

            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index was out of bounds of the array.");
            }

            return operandsDecimal;
        } 

        //parse string fraction to decimal fraction
        public static decimal Parse(string expression)
        {
            decimal[] numbers = GetFractionNumbers(expression);

            decimal result = numbers[0] / numbers[1];

            return result;
        }

        public void ReduceFraction()
        {
            //print the fraction before the reduction
            Console.WriteLine($"Fraction before reducing: {this.numerator}/{this.denominator}");
            int divisor = 2;
            while (true)
            {
                //check if both numerator and denominator are divisable by the divisor
                //and if true, do the math and exit the loop
                if((this.numerator % divisor) == 0 && (this.denominator % divisor) == 0)
                {
                    this.numerator /= divisor;
                    this.denominator /= divisor;
                    break;
                }

                //if not increment the diviosr by 1
                else
                {
                    divisor++;
                }

                
            }
            //print the fraction after the reduction
            Console.WriteLine($"Fraction after reducing: {this.numerator}/{this.denominator}");
        }

        
        public decimal Numerator
        {
            get { return this.numerator; }
            set { this.numerator = value; }
        }

        public decimal Deniminator
        {
            get { return this.denominator; }
            set { this.denominator = value; }
        }

        public decimal Result
        {
            get { return this.result; }
        }
    }
}
