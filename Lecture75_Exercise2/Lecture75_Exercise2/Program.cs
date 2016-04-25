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
            var words = cleanString.Split(' ');
            var max = words[0].Length;

            foreach (var word in words)
            {
                if (word.Length > max) max = word.Length;
            }
            return max;
        }

    }
}
