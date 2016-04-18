using System;
using System.Collections.Generic;
using System.IO;

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

                friends.Add(fbFriend);

                switch (friends.Count)
                {
                    case 1:
                        Console.WriteLine($"Friend One: {friends[0]}");
                        break;

                    case 2:
                        Console.WriteLine($"A Second Friend: {friends[1]}");
                        break;

                    default:
                        Console.WriteLine($"A New Friend: {friends[friends.Count - 1]}");
                        break;
                }
                foreach(var name in friends)
                    Console.WriteLine(name);
            }
        }
    }
}
