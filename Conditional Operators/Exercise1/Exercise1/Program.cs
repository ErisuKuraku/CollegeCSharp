using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number:");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            if (number < 11 && number > 0)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Number isn't valid");
            }
        }
    }
}
