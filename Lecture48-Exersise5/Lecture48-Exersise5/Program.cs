using System;

namespace Lecture48_Exersise5
{
    class Program
    {
        static void Main()
        {
            Console.Write($"Enter a series of numbers separated by a comma: ");
            var userInput = Console.ReadLine();

            var numbers = userInput.Split(',');

            var max = Convert.ToInt32(numbers[0]);

            Console.WriteLine($"{numbers.Length}");
        }
    }
}
