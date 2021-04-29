using System;
using System.Collections.Generic;
using System.Linq;

namespace Excersise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 Numbers: ");
            int i = 0;
            var numbers = new List<int>();
            while (numbers.Count < 5)
            {
                int entered = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(entered))
                {
                    Console.WriteLine("Number Entered Twice please try again!");
                } else { numbers.Add(entered);}

            }
            numbers.Sort();
            foreach (object o in numbers)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("End of Program.");
        }
    }
}
