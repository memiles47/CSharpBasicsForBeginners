using System;

namespace Lecture48_Exersise4
{
    class Program
    {
        static void Main()
        {
            var random = new Random();
            var newNumber = random.Next(1, 10);

            Console.WriteLine($"You have four guesses to enter the correct number (1-10)");

            for (var i = 1; i <= 4; i++)
            {
                Console.Write($"Enter guess #{i}: ");
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == newNumber)
                {
                    Console.WriteLine($"You won, {guess} is correct!");
                    break;
                }
                else if (i == 4 && guess != newNumber)
                    Console.WriteLine("You Lost");
            }
        }
    }
}
