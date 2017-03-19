﻿using System;
using Lecture26_DeclaringClasses.Math;

namespace Lecture26_DeclaringClasses
{
    //This next six months is going to drive me insane.
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
