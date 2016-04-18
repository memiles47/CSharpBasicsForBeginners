using System;
using System.Collections.Generic;

namespace Lecture54_ListFunctions
{
    class Program
    {
        static void Main()
        {
            var numbers = new List<int> {1, 2, 3, 4, 1};
            numbers.AddRange(new[] {5,6,7});

            foreach(var n in numbers)
                Console.WriteLine($"{n}");

            //IndexOf()
            Console.WriteLine();
            Console.WriteLine($"Index of 1: {numbers.IndexOf(1)}");

            //LastIndexOf()
            Console.WriteLine($"Last Index of 1: {numbers.LastIndexOf(1)}");

            //Count()
            Console.WriteLine($"Number if items in list: {numbers.Count}");

            //Remove()
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }
            foreach(var n in numbers)
                Console.WriteLine($"{n}");
        }
    }
}
