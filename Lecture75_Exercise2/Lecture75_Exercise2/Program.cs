using System;
using System.IO;

namespace Lecture75_Exercise2
{
    class Program
    {
        static void Main()
        {
            var path = @"C:/Users/Michael/Data/TextDocument.txt";
            Console.WriteLine($"The maximum word length in the text file is: {MaxWordLength(path)}");
        }

        static int MaxWordLength(string path)
        {
            var wordString = File.ReadAllText(path);
            var cleanString = wordString.Replace(".", "");
            var max = 1;

            foreach (var word in cleanString.Split(' '))
            {
                if (word.Length > max) max = word.Length;
            }
            return max;
        }

    }
}
