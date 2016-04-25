using System;

namespace Lecture67_Exercise3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please enter a time in 12hr format e.g. 19:50> ");
            var timeInput = Console.ReadLine() ?? "" ;

            var timeArray = timeInput.Split(':');

            Console.WriteLine($"The entered time: {timeInput} is {TimeCheck(timeArray)}.");
        }

        static string TimeCheck(string[] inputTime)
        {
            if (inputTime[0] == "")
            {
                return "Invalid";
            }
            if (Convert.ToInt32(inputTime[0]) < 0 || Convert.ToInt32(inputTime[0]) > 23)
            {
                return "Invalid";
            }

            if (Convert.ToInt32(inputTime[1]) < 0 || Convert.ToInt32(inputTime[1]) > 59)
            {
                return "Invalid";
            }

            return "Valid";
        }
    }
}
