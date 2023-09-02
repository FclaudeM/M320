using System;

namespace _02Instanzvariablen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Width = 14;
            Console.WriteLine($"{rectangle.Width}");

        }
    }
}