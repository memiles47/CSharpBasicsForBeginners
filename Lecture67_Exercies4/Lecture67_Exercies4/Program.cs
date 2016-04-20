using System;
using System.Text;

namespace Lecture67_Exercies4
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please enter a few words: ");
            var input = Console.ReadLine()?.ToLower() ?? "";

            var variable = input.Split(' ');

            var variableName = new StringBuilder();

            foreach (var word in variable)
            {
                variableName.Append(word[0].ToString().Substring(0, 1).ToUpper())
                            .Append(word.Substring(1));
            }

            Console.WriteLine($"\nVariable Name: {variableName}\n");
        }
    }
}
