using System;

namespace Lecture48_Exersise2
{
    class Program
    {
        static void Main()
        {
            var sum = 0;

            while (true)
            {
                Console.Write($"Enter a number or \"ok\" to quit: ");
                var myInput = Console.ReadLine();
                if (myInput == "ok")
                    break;
                sum += Convert.ToInt32(myInput);
            }
            Console.WriteLine($"The total of the numbers entered is {sum}");
        }
    }
}
