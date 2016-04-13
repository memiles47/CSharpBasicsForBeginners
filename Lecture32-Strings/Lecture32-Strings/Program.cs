using System;

namespace Lecture32_Strings
{
    class Program
    {
        static void Main()
        {
            const string firstName = "Michael";
            const string lastName = "Miles";

            string fullName = $"My name is {firstName} {lastName}";

            var names = new string[3] {"John", "Jack", "Mary"};
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            const string text = "Hi John\nLook into the following paths\n\nc:\\folder1\\folder2\nc:\\folder1\\folder2\\folder3\\folder4";
            Console.WriteLine(text);

            const string text2 = @"Hi John
Look into the following paths

c:\folder1\folder2
c:\folder1\folder2\folder3\folder4";
            Console.WriteLine(text2);
        }
    }
}
