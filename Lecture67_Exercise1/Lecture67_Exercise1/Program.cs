using System;

namespace Lecture67_Exercise1
{
    class Program
    {
        static void Main()
        {
            const string inputString1 = "1-2-3-4-5";
            const string inputString2 = "5-4-3-2-1";
            const string inputString3 = "1-3-2-6-7";

            var chkString1 = inputString1.Split('-');
            var chkString2 = inputString2.Split('-');
            var chkString3 = inputString3.Split('-');

            for (var i = 0; i < chkString3.Length - 1; i++)
            {
                if (
                    !((Convert.ToInt32(chkString3[i]) + 1 == Convert.ToInt32(chkString3[i + 1])) ||
                      (Convert.ToInt32(chkString3[i]) - 1 == Convert.ToInt32(chkString3[i + 1]))))
                {
                    Console.WriteLine("Not Consecutive");
                    break;
                }
            }
        }
    }
}
