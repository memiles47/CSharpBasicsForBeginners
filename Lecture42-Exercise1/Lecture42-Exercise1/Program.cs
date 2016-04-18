using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Lecture42_Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;

            Console.Write($"Please input a number and press <ENTER>:");
            var value = int.TryParse(Console.ReadLine(), out "Valid" ? "Invalid");
        }
    }
}
