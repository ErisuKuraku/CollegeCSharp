using System;

namespace Exorsice3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the width: ");
            var width = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("... and now the height: ");
            var height = Convert.ToInt32(Console.ReadLine());
           
            if (width > height)
            {
                Console.Write("This image is Landscape");
            } else if (width < height)
            {
                Console.Write("This image is Portrait");
            } else if (width == height)
            {
                Console.Write("This image is Square");
            }
            else
            {
                Console.Write("Something went wrong! Error: 1");
            }
        }
    }
}
