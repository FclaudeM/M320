using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browser_Simulator
{
    internal class Simulator
    {
        public void Run(StringStack stringStack)
        {
            while (true)
            {
                Console.Write("Geben sie eine url ein:");
                string url = Console.ReadLine();
                if (url == "e")
                {
                    break;
                }

                stringStack.Push(url);
                Run(stringStack);

                BrowseURL(url);
            }
        }

        public void BrowseURL(string url)
        {
            Console.WriteLine($"Lade {url}");
        }

    }
}
