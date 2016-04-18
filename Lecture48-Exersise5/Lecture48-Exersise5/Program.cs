using System;

namespace Lecture48_Exersise5
{
    class Program
    {
        static void Main()
        {
            //This is how I envisioned creating this string.
            Console.Write($"Enter a series of numbers separated by a comma: ");
            var userInput = Console.ReadLine() ?? "";

            //This is what I was thinking about in bed and did not know how to accomplish this
            var numbers = userInput.Split(',');

            //Between this and the foreach construct is how I planned to do this (brute force)
            //or use the .Max command if I had converted the entire array into integers
            var max = Convert.ToInt32(numbers[0]);

            foreach (var item in numbers)
            {
                if (Convert.ToInt32(item) > max)
                    max = Convert.ToInt32(item);
            }
            Console.WriteLine($"The Maximum Value is: {max}");
        }
    }
}
