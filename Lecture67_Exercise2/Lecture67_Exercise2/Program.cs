using System;

namespace Lecture67_Exercise2
{
    class Program
    {
        static void Main()
        {
            var duplicates = false;

            Console.Write("Please enter a series of numbers separated with a hyphen e.g. 1-2-3...: ");
            var input = Console.ReadLine() ?? "";
            if (input == "")
                return;

            var inputArray = input.Split('-');

            foreach (var n in inputArray)
            {
                var count = 0;

                for (int i = 0; i < inputArray.Length - 1; i++)
                {
                    if (n == inputArray[i])
                    {
                        count ++;
                        if (count > 1) duplicates = true;
                    }
                }
            }

            Console.WriteLine($"List contains duplicates: {(duplicates ? "Yes": "No")}");
        }
    }
}
