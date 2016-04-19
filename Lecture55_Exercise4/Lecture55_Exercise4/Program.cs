using System;
using System.Collections.Generic;

namespace Lecture55_Exercise4
{
    class Program
    {
        static void Main()
        {
            var numbers = new List<int>();
            var unique = new List<int>();

            while (true)
            {
                Console.Write($"Enter a number or quit to exit: ");
                var input = Console.ReadLine();

                if (input?.ToLower() == "quit") break;

                numbers.Add(Convert.ToInt32(input));
                if(!unique.Contains(Convert.ToInt32(input)))
                    unique.Add(Convert.ToInt32(input));
            }
            foreach(var n in unique)
                Console.WriteLine(n);
        }
    }
}
