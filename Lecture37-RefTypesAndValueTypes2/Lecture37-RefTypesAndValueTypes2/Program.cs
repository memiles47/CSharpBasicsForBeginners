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
