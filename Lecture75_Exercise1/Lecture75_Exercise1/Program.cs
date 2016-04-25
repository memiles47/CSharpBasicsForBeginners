using System;
using System.IO;

namespace Lecture75_Exercise1
{
    class Program
    {
        static void Main()
        {
            var path = @"C:/Users/Michael/Data/TextDocument.txt";

            Console.WriteLine($"The number of words in the text file is: {NumberOfWords(path)}");
        }

        static int NumberOfWords(string path)
        {
            var wordString = File.ReadAllText(path);
            var words = wordString.Split(' ');
            return words.Length;
        }
    }
}