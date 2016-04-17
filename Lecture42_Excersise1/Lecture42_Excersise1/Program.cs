using System;

namespace Lecture42_Excersise1
{
    class Program
    {
        static void Main()
        {
            Console.Write($"Please input a number then press <ENTER>");
            string inputNumber = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(inputNumber) >= 1 && Convert.ToInt32(inputNumber) <= 10
                ? $"Input Number is Valid"
                : $"Input Number is Not Valid");
        }
    }
}