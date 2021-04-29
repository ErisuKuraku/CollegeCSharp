using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------ Exercise 5 ------------");
            Console.WriteLine("Enter your numbers separated by a comma (NO SPACES)");
            var entered = Console.ReadLine();
            var enteredArray = entered.Split(",");
            enteredArray = enteredArray.ConvertAll()
        }
    }
}
