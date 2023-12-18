using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace PalindromeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result;

            Stack<char> stack = new Stack<char>();
            stack.Push('r');
            stack.Push('a');
            stack.Push('c');
            stack.Push('e');
            stack.Push('c');
            stack.Push('a');
            stack.Push('r');

            

            foreach (char item in stack)
            {
                result += stack.Pop();
                Console.WriteLine($"{item}");
            }

        }
    }
}