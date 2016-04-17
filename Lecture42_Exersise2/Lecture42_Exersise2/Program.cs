using System;

namespace Lecture42_Exersise2
{
    class Program
    {
        static void Main()
        {
            Console.Write($"Enter the first value: ");
            var string1 = Console.ReadLine();

            Console.Write($"Enter the second value: ");
            var string2 = Console.ReadLine();

            var number1 = Convert.ToInt32(string1);
            var number2 = Convert.ToInt32(string2);

            Console.WriteLine($"\nThe largest of the two values is {Math.Max(number1, number2)}");
            Console.WriteLine(number1 > number2? $"\n{number1} is larger": $"\n{number2} is larger");
        }
    }
}
