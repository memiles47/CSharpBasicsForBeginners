using System;

namespace Lecture67_Exercise3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please enter a time in 12hr format e.g. 19:50");
            var timeInput = Console.ReadLine() ?? "" ;

            var timeArray = timeInput.Split(':');
            var dateTime = new DateTime();
        }
    }
}
