using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 0;
            List<string> likes = new List<string>();

            while (i == 0)
            {
                Console.WriteLine("Please Enter Usernames:");
                var entered = Console.ReadLine();
                if (entered == "")
                {
                    break;
                }
                else
                {
                    likes.Add(entered);
                    
                }
            }

            switch (likes.Count)
            {
                case 0:
                    Console.WriteLine("");
                    break;

                case 1:
                    Console.WriteLine(likes[0] + " likes your post.");
                    break;

                case 2:
                    Console.WriteLine(likes[0] + " and " + likes[1] + " likes your post.");
                    break;

                default:
                    Console.WriteLine(likes[0] + " , " + likes[1] + " and " + (likes.Count - 2) + " others like your post.");
                    break;
            }

            
        }
    }
}
