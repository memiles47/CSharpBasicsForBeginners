using System;

namespace Lecture42_Exersise4
{
    class Program
    {
        static void Main()
        {
            const int perKphDemerits = 5;

            Console.Write($"Enter the Speed Limit: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Enter the Speed of the vehicle: ");
            var vehicleSpeed = Convert.ToInt32(Console.ReadLine());

            var demerits = (vehicleSpeed - speedLimit) / perKphDemerits;

            if (vehicleSpeed <= speedLimit)
                Console.WriteLine($"Ok");
            else
            {
                Console.WriteLine(demerits <= 12 ? $"Demerits = {demerits}" : $"License Suspended");
            }
        }
    }
}
