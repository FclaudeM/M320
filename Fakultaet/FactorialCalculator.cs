using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fakultaet
{
    public class FactorialCalculator
    {
        public  int Calculate(int number)
        {
            if (number < 2)
            {
                return 1;
            }

            int o = number;
            int p = number;

            for (int i = 1; i < o; i++)
            {
                p = p - 1;
                number = number * p;
            }
            Console.WriteLine($"{number}");
            return 0;
        }
    }
}
