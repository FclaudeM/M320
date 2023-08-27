using System;
using Microsoft.VisualBasic;

namespace GCDCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers to calculate their Greatest Common Divisor (GCD):");

            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int gcd = MyMath.CalculateGCD(num1, num2);

            Console.WriteLine($"The GCD of {num1} and {num2} is {gcd}");
        }
    }
}
