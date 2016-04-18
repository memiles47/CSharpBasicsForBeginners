using System;

namespace Lecture55_Exercise2
{
    class Program
    {
        /*
         * Many list and array functions to remember in this one.
         */
        
        static void Main()
        {
            Console.Write($"Please enter your name: ");
            var name = Console.ReadLine() ?? "";

            var array = new char[name.Length];

            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            var reversed = new string(array);
            Console.Clear();
            Console.WriteLine($"Name reversed: {reversed}");
        }
    }
}
