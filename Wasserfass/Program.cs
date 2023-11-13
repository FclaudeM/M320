using System.Security.Cryptography.X509Certificates;

namespace Wasserfass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wasserfass wasserfass1 = new Wasserfass(0, 15, 15, 3);
            wasserfass1.befüllen(5);
            Console.WriteLine(wasserfass1.füllstand);
        }
    }
}