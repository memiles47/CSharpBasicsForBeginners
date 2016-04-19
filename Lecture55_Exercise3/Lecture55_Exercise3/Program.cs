using System;
using System.Collections.Generic;

namespace Lecture55_Exercise3
{
    class Program
    {
        static void Main()
        {
            var numbers = new List<int>();

            while (numbers.Count < 5)
            {
                Console.Write($"Number {numbers.Count + 1}: ");
                var newNumber = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(newNumber))
                {
                    Console.WriteLine($"Number {newNumber} already exists");
                    continue;
                }
                numbers.Add(newNumber);
            }

            numbers.Sort();
            foreach (var n in numbers)
                Console.WriteLine($"Number {n}");
        }
    }
}
