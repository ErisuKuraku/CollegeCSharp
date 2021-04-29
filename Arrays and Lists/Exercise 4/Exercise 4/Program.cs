using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            var numbers = new List<int>();

            Console.WriteLine("Enter numbers or type Quit:");
            while (quit == false)
            {
                var entered = Console.ReadLine();

                if (entered == "Quit")
                {
                    quit = true;
                }
                else
                {
                    numbers.Add(Convert.ToInt32(entered));
                }

            }
            Console.WriteLine("Your Numbers are...");
            List<int> distinct = numbers.Distinct().ToList();
            foreach (int res in distinct) {
                Console.WriteLine("{0}", res);
            }
        }
    }
}
