using System;

namespace Lecture36_RefTypesAndValueTypes
{
    internal class Program
    {
        private static void Main()
        {
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine($"a: {a}, b: {b}");

            var array1 = new[] {1, 2, 3};
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine($"array1[0]: {array1[0]}, array2[0]: {array2[0]}");

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }
}
