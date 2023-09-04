using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Rectangle
    {
        int width;
        int height;
        Color color;
        bool transparent;


        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
            Console.WriteLine($"{width}, {height}");
        }

        public Rectangle(int width, int height, bool transparent)
        {
            this.width = width;
            this.height = height;
            this.transparent = transparent;
            Console.WriteLine($"{width}, {height}, {transparent}");
        }

        public Rectangle(int width, int height, Color color, bool transparent) : this(width, height, color)
        {
            this.transparent = transparent;
            Console.WriteLine($"{width}, {height}, {transparent}, {color}");
        }

        public Rectangle(int width, int height, Color color) : this(width, height)
        {
            this.color = color;
            Console.WriteLine($"{width}, {height}, {color}");
        }

    }
}