using System;
using System.Text;

namespace Lecture67_Exercies4
{
    class Program
    {
        static void Main()
        {
            //var words = "my nEw vaRiaBle";
            //var varible = words.Split(' ');
            var testWord = "miCHaEl";


            var bldrVariableName = new StringBuilder();

            bldrVariableName.Append((testWord[0].ToString().ToUpper()))
                .Append(testWord.Substring(1).ToLower());

            Console.WriteLine($"New word: {bldrVariableName}");


        }
    }
}
