using System;

namespace Lecture37_RefTypesAndValueTypes2
{
    internal class Program
    {
        public class Person
        {
            public int Age;
        }

        private static void Main()
        {
            const int number = 1;
            Increment(number);
            Console.WriteLine($"number: {number}");

            var person = new Person {Age = 20};
            MakeOld(person);
            Console.WriteLine($"person.age: {person.Age}");
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
