using System;
using System.Collections.Generic;
using System.Linq;

namespace Lecture55_Exercise5
{
    class Program
    {
        static void Main()
        {
            List<int> numbersList; //Check out this declaration

            while (true)
            {
                Console.WriteLine($"Please enter a list of comma separated values (e.g. 1, 2, 3, ...)");
                var input = Console.ReadLine() ?? "";
                var cleanInput = input.Replace(" ", "");

                if (!string.IsNullOrWhiteSpace(cleanInput)) //Remember string.IsNullOrWhiteSpace
                {
                    var numbers = cleanInput.Split(',');
                    if (numbers.Length > 4)
                    {
                        numbersList = numbers.Select(n => Convert.ToInt32(n)).ToList(); //Remember this...
                        break;
                    }
                }

                Console.WriteLine($"Invalid entry retry");
                Console.Write($"Press <ENTER> to continue... ");
                Console.ReadLine();
                Console.Clear();
            }

            numbersList.Sort();
            Console.WriteLine($"The three smallest numbers are: ");
            for (var i = 0; i < 3; i++)
                Console.WriteLine($"Number {i + 1}: {numbersList[i]}");
        }
    }
}
