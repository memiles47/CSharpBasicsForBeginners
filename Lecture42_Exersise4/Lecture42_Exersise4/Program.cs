using System;

namespace Lecture42_Exersise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter the Speed Limit: ");
            var stringSpeedLimit = Console.ReadLine();

            Console.Write($"Enter the Speed of the vehicle: ");
            var stringVehicleSpeed = Console.ReadLine();

            var speedLimit = int.Parse(stringSpeedLimit);
            var vehicleSpeed = int.Parse(stringVehicleSpeed);

            var demerits = (vehicleSpeed - speedLimit) / 5;

            if (vehicleSpeed <= speedLimit)
            {
                Console.WriteLine($"Ok");
            }
            else if (demerits <= 12)
            {
                Console.WriteLine($"\nDemerits = {demerits}");
            }
            else
            {
                Console.WriteLine($"\nLicense suspended");
            }
        }
    }
}
