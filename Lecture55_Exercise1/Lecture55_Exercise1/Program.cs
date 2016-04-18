using System;
using System.Collections.Generic;

namespace Lecture55_Exercise1
{
    class Program
    {
        static void Main()
        {
            var friends = new List<string>();

            while (true)
            {
                Console.Write($"Friends name: ");
                var fbFriend = Console.ReadLine();

                if (fbFriend == "")
                    break;

                Console.Clear();
                friends.Add(fbFriend);

                switch (friends.Count)
                {
                    case 1:
                        Console.WriteLine($"{friends[0]} likes your post.");
                        break;
                    case 2:
                        Console.WriteLine($"{friends[0]} and {friends[1]} like your post.");
                        break;
                    case 3:
                        Console.WriteLine($"{friends[0]}, {friends[1]} and 1 other person likes your post.");
                        break;
                    default:
                        Console.WriteLine(
                            $"{friends[0]}, {friends[1]} and {friends.Count - 2} other people like your post.");
                        break;
                }
            }
        }
    }
}
