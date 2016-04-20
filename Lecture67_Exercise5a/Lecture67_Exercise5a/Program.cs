using System;
using System.Linq;

namespace Lecture67_Exercise5a
{
    class Program
    {
        static void Main()
        {
            const string vowels = "aeiou";

            Console.Write("Please enter a word: ");
            var input = Console.ReadLine()?.ToLower() ?? "";

            var count = input.Count(c => vowels.Contains(Convert.ToString(c)));

            Console.WriteLine($"\nThere are {count} vowels in your word.");
        }
    }
}
