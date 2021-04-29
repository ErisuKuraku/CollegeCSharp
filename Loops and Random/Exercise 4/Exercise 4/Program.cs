using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Random random = new System.Random();
            var secret = random.Next(1, 11);
            bool correct = false;

            Console.WriteLine("Debug: The secret number is: " + secret);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter the secret number: ");
                var entered = Convert.ToInt32(Console.ReadLine());
                if (entered == secret)
                {
                    correct = true;
                    break;

                } else

                {
                    Console.WriteLine("Wrong! Please try again.");
                }
            }

            if (correct == true)
            {
                Console.WriteLine("Well done, the number was " + secret);
            }
            else
            {
                Console.WriteLine("Game over! Too many wrong tries. The actual number was " + secret);
            }

        }
    }
}
