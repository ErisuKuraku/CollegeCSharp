using System;
using System.Text.RegularExpressions;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;

            bool done = false;


            while (done == false)
            {
                Console.WriteLine("Please enter a number or ok to end: ");
                var result = Console.ReadLine();
                if (result == "ok")
                {
                    Console.WriteLine("The sum was " + sum);
                    done = true;
                }
                else
                {
                    int num = Convert.ToInt32(result);
                    sum = sum + num;
                }
            }
             
        }
    }
}
