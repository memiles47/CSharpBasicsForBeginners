using System;
using Lecture26_DeclaringClasses.Math;

namespace Lecture26_DeclaringClasses
{
    //Checking my memory of this small program
    internal class Program
    {
        private static void Main()
        {
            var michael = new Person
            {
                FirstName = "Michael",
                LastName = "Miles"
            };
            michael.Introduce();

            var calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine($"a + b = {result}");
        }
    }
}
