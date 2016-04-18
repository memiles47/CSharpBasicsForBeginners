using System;

namespace Lecture48_Exersise3
{
    class Program
    {
        static void Main()
        {
            var factoral = 1;

            Console.Write($"Input a number and press <ENTER> ");
            var myInput = Convert.ToInt32(Console.ReadLine());

            for (var i = myInput; i > 1; i--)
            {
                factoral *= i;
            }
            Console.WriteLine($"{myInput}! = {factoral}");
        }
    }
}
