using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorF
{
    internal class Calc
    {

        static public int Selection()
        {
            Console.WriteLine("1 für Addition\n2 für Subtraktion\n3 für Multiplikation\n4 für Division\n5 für alle");
            int sel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geben sie eine Zahl ein:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geben sie eine Zahl ein:");
            int b = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            switch (sel)
            {
                case 1:
                    result = Calc.Add(a, b);
                    Console.WriteLine($"Resultat Addition: {result}");
                    break;
                case 2:
                    result = Calc.Sub(a, b);
                    Console.WriteLine($"Resultat Subtraktion: {result}");
                    break;
                case 3:
                    result = Calc.Mult(a, b);
                    Console.WriteLine($"Resultat Multiplikation: {result}");
                    break;
                case 4:
                    result = Calc.Div(a, b);
                    Console.WriteLine($"Resultat Division: {result}");
                    break;
                case 5:
                    result = Calc.Add(a, b);
                    Console.WriteLine($"Resultat Addition: {result}");
                    result = Calc.Sub(a, b);
                    Console.WriteLine($"Resultat Subtraktion: {result}");
                    result = Calc.Mult(a, b);
                    Console.WriteLine($"Resultat Multiplikation: {result}");
                    result = Calc.Div(a, b);
                    Console.WriteLine($"Resultat Division: {result}");
                    break;
                default:
                    break;
            }
            return result;
        }

        static public int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }

        static public int Sub(int a, int b)
        {
            int result = a - b;
            return result;
        }

        static public int Mult(int a, int b)
        {
            int result = a * b;
            return result;
        }

        static public int Div(int a, int b)
        {
            int result = a / b;
            return result;
        }
    }
}
