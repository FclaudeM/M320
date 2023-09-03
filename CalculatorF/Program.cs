using System.Security.Cryptography.X509Certificates;

namespace CalculatorF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("---Rechner---");
                int result = Calc.Selection();
                Calc.Continue(result);
            }

        }
    }
}