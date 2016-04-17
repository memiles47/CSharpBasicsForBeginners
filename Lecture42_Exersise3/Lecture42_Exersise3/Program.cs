﻿using System;

namespace Lecture42_Exersise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter the document width: ");
            var stringWidth = Console.ReadLine();

            Console.Write($"Enter the document length: ");
            var stringLength = Console.ReadLine();

            var width = Convert.ToDouble(stringWidth);
            var length = Convert.ToDouble(stringLength);

            Console.WriteLine(width <= length
                ? $"\nThe document is displayed in portrait format"
                : $"\nThe document is displayed in landscape format");
        }
    }
}