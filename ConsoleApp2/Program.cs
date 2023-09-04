using System.Drawing;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle(7, 8);
            Rectangle rectangle2 = new Rectangle(7, 8, true);
            Rectangle rectangle3 = new Rectangle(7, 8, System.Drawing.Color.Blue, false);
            Rectangle rectangle4 = new Rectangle(7, 8, System.Drawing.Color.Green);
            Console.ReadLine();
        }
    }
}