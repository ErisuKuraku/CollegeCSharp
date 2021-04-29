using System;
using System.Linq;
using System.Threading.Tasks.Dataflow;
using System.Xml;

namespace Exercise_2
{
    static class Stringer
    {
        public static string ReverseString(string MyStr)
        {

            char[] myName = MyStr.ToCharArray();
            Array.Reverse(myName);
            return new string(myName);

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine(Stringer.ReverseString(name));
            
        }
    }
}
