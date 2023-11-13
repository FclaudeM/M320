using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browser_Simulator
{
    internal class StringStack
    {
        string[] values;
        int index;

        public StringStack()
        {
            values = new string[10];
        }

        public void Push(string value)
        {
            if (values == null || values.Length == 0)
            {
                Console.WriteLine("ARRAY LEER");
            }
            Console.WriteLine($"{value}");
            this.values[index++] = value;
            
        }

        public string Pop()
        {
            if (values == null || values.Length == 0)
            {
                Console.WriteLine("ARRAY LEER");
            }
            index--;
            return this.values[index];
        }
    }
}
