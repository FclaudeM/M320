using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ggT
{
    public int rggT;
    public class MyMath
    {
        public static int Calc_ggT(int ersteZahl, int zweiteZahl)
        {  
            while (zweiteZahl != 0)
            {
                rggT = ersteZahl % zweiteZahl;
                ersteZahl = zweiteZahl;
                zweiteZahl = rggT;
            }
            return rggT;
        }
    }
}
