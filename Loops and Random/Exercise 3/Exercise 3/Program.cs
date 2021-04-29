using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int num, n;

            Console.WriteLine(".....................[Exorcise 3].....................\n\n");
            Console.WriteLine("Please enter a number to get its factorial: ");
           int entered = Convert.ToInt32(Console.ReadLine());
            num = 1;
            n = entered;

            while (num > 0)
            {
                for (int i = n - 1; i > 0; i--)
                {
                    n *= i;
                    
                }
                Console.WriteLine(entered + "! = " + n);
                num--;
               
            }
        }
    }
}
