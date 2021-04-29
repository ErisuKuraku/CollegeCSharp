using System;
using System.Globalization;
using System.Threading;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter speed limit: ");
            var limit = Convert.ToInt32(Console.ReadLine());

            Console.Write("Thanks, Now enter car speed: ");
            var speed = Convert.ToInt32(Console.ReadLine());

            Console.Write("Calculating...    ");

            if (limit > speed || limit == speed)
            {
                Console.Write(" Speed OK!");

            } else
            {
                var diff = (speed - limit);
               var sub = (diff / 5);
               if (sub < 12)
               {
                   Console.Write(sub + " Demerit points.");
               } else if (sub == 0)
               {
                    Console.Write("Over speed limit but not enough to sanction.");
               }
               else

               {
                    Console.Write("=== License Suspended ===");
               }
            }
        }
    }
}
