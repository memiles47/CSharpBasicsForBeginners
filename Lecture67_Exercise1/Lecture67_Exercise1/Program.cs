using System;
using System.Collections.Generic;

namespace Lecture67_Exercise1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a few numbers separated by a hyphen e.g. 1-2-3...: ");
            var input = Console.ReadLine() ?? "";

            var cleanInput = input.Replace(" ", "");
            var numbers = new List<int>();

            foreach (var number in cleanInput.Split('-'))
            {
                numbers.Add(Convert.ToInt32(number));
            }

            if (IsNumeric(numbers))
            {
                Console.WriteLine("The list is in numeric order.");
            }
            else if(IsReverseNumeric(numbers))
            {
                Console.WriteLine("The List is in reverse numeric order.");
            }
            else
            {
                Console.WriteLine("The list is not in numeric order.");
            }
        }

        static bool IsNumeric(List<int> list)
        {

            for (int i = 0; i < list.Count - 2; i++)
            {
                if (list[i] + 1 != list[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsReverseNumeric(List<int> list)
        {
            list.Reverse();
            for (int i = 0; i < list.Count - 2; i++)
            {
                if (list[i] + 1 != list[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
