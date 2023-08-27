using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calc_ggT
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie zwei Zahlen ein:");
            int a = MyMath.Readint();
            int b = MyMath.Readint();

            int ggT = MyMath.Calc_ggT(a, b);
            int kgV = MyMath.Calc_kgV(a, b);

            MyMath.ShowResult(a, b, ggT, kgV);

            int t = MyMath.Calc_ggT_r(a, b);
            Console.WriteLine($"Mit rekursiven Algorithmus: {t}");

            double[] zahlen = { 5.0, 10.0, 15.0, 20.0, 25.0 };


            double g = MyMath.Mitte(zahlen);
            Console.WriteLine($"{g}");

            double h = MyMath.Klein(zahlen);
            Console.WriteLine($"{h}");

            double j = MyMath.Gross(zahlen);
            Console.WriteLine($"{j}");

            Console.ReadLine();
        }
    }
}