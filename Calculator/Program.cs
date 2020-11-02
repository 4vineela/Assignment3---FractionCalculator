using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //pass two fractions
            Fraction a = new Fraction(9,3);
            Console.WriteLine("First Fraction:"+ a);

            Fraction b = new Fraction(12,6);
            Console.WriteLine("second Fraction:" + b);

            //Addition
            Fraction c = a.Addition(b);
            Console.WriteLine("Addition: " + c);

            //Subtraction
            c = a.Subtraction(b);
            Console.WriteLine("Subtraction: " + c);

            //Multiplication
            c = a.Multiplication(b);
            Console.WriteLine("Multiplication: " + c);

            //Division
            c = a.Division(b);
            Console.WriteLine("Division: " + c);

            Console.ReadLine();
        }
    }
}
