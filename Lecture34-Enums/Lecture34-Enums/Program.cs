using System;

namespace Lecture34_Enums
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    class Program
    {
        static void Main()
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodID = 3;
            Console.WriteLine((ShippingMethod)methodID);

            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var  shippinpMethod = (ShippingMethod)Enum.Parse(typeof (ShippingMethod), methodName);
            Console.WriteLine(shippinpMethod);

        }
    }
}
