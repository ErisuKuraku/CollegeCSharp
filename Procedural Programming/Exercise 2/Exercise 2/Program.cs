using System;
using System.Collections.Generic;
using System.Threading;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            while (true)
            {
                Console.Write("Enter a number (or Quit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }

                numbers.Add(Convert.ToInt32(input));

            }

            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                {
                    uniques.Add(number);
                }
            }

            Console.WriteLine("Unique numbers:");
                foreach (var number in numbers)
                {
                    Console.WriteLine(number);
                }
            
        }
    }
}
