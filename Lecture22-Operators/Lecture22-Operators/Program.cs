using System;

namespace Lecture22_Operators
{
    class Program
    {
        static void Main()
        {
            var a = 10;
            var b = 3;

            //ReSharper removed the first case of float from 'a' as not needed
            //and the result compiled and was the same as casting both a and b
            Console.WriteLine(a / (float)b);
        }
    }
}
