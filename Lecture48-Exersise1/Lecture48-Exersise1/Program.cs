using System;

namespace Lecture48_Exersise1
{
    class Program
    {
        static void Main()
        {
            var count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"There are {count} numbers between 1 and 100 divisible by 3 with no remainder\n");
        }
    }
}
