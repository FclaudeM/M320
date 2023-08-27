using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_ggT
{
    class MyMath
    {

        public static double Gross(double[] array)
        {
            double gross = array[0];
            
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > gross)
                {
                    gross = array[i];
                }

            }
            return gross;
        }

        public static double Klein(double[] array)
        {
            double klein = array[0];
            
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < klein)
                {
                    klein = array[i];
                }

            }
            return klein;
        }

        public static double Mitte(double[] array)
        {
            double summe = 0;
            foreach (double zahl in array)
        {
            summe += zahl;
        }

        return summe / array.Length;
        }

        public static int Calc_ggT_r(int a, int b)
                {
                if (b == 0)
        {
                return a;
        }
                else
        {
                    return MyMath.Calc_ggT(b, a%b);
        }
                }


        public static string ShowResult(int a, int b, int kgV, int ggT)
        {
        Console.WriteLine($"ggT von {a} und {b} ist {ggT}");
        Console.WriteLine($"kgV von {a} und {b} ist {kgV}");

        return "";
        }

        public static int Readint()
        {
            int zahl;

                do
	    {
                zahl = Convert.ToInt32(Console.ReadLine());

                    if (zahl < 0)
	    {
                        Console.WriteLine("Ungültige Zahl");
	    }

	    } while (zahl < 0);


            return zahl;
        }
        
        public static int Calc_kgV(int a, int b)
        {
            return a * b / Calc_ggT(a, b);
        }

        public static int Calc_ggT(int a, int b)
        {
            while (b != 0)
            {
                int z = a % b;
                a = b;
                b = z;
            }
            return a;
        }
    }
}

