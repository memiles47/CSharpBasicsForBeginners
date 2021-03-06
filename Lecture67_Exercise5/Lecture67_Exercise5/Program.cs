﻿using System;

namespace Lecture67_Exercise5
{
    class Program
    {
        static void Main()
        {
            const string vowels = "aeiou";
            var count = 0;

            Console.Write("Please enter a word: ");
            var input = Console.ReadLine()?.ToLower() ?? "";

            foreach (var c in input)
            {
                if (vowels.Contains(Convert.ToString(c)))
                {
                    count++;
                }
            }

            Console.WriteLine($"\nThere are {count} vowels in your word.");
        }
    }
}
