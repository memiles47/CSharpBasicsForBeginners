using System;

namespace Lecture42_Excersise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Please input a number then press <ENTER>");
            string inputNumber = Console.ReadLine();

            if (int.Parse(inputNumber) >= 1 && int.Parse(inputNumber) <= 10)
            {
                Console.WriteLine($"Input Nubmer is Valid");
            }
            else
            {
                Console.WriteLine($"Input Number is not valid");
            }
        }
    }
}