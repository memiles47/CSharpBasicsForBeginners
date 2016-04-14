using System;

namespace Lecture37_RefTypesAndValueTypes2
{
    class Program
    {
        public class Person
        {
            public int age;
        }

        static void Main(string[] args)
        {
            var number = 1;
            Increment(number);
            Console.WriteLine($"number: {number}");

            Person person = new Person {age = 20};
            MakeOld(person);
            Console.WriteLine($"person.age: {person.age}");
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.age += 10;
        }
    }
}
