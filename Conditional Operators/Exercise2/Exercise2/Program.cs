using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the 1st number: ");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Now enter the 2nd number: ");
            var num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.Write("The 1st number " + num1 + " is bigger");
            } else if (num1 < num2)
            {
                Console.Write("The 2nd number " + num2 + " is the biggest one.");
            }
            else
            {
                Console.Write("Something has gone wrong");
            }
        }
    }
}
