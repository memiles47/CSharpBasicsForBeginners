using System;

namespace Lecture42_Exersise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter the first value: ");
            var string1 = Console.ReadLine();

            Console.Write($"Enter the second value: ");
            var string2 = Console.ReadLine();

            var number1 = int.Parse(string1);
            var number2 = int.Parse(string2);

            Console.WriteLine($"\nThe largest of the two values is {Math.Max(number1, number2)}");
        }
    }
}
