using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Person
    {

        private string Name;
        private int WutMeter;

        public int Provozieren()
        {
            WutMeter++;
            return WutMeter;
        }

        public int HerunterFahren()
        {
            WutMeter--;
            return WutMeter;
        }
        public int KopfAnschlagen()
        {
            WutMeter++;
            return WutMeter;
        }

        public int BierTrinken()
        {
            WutMeter--;
            return WutMeter;
        }
    }
}
