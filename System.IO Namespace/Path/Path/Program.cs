using System;
using System.IO;

namespace Path
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\ellis\Documents\GitHub\CollegeCSharp\System.IO Namespace\Path\Path.sln";

            Console.WriteLine("Extenstion: " + System.IO.Path.GetExtension(path));
            Console.WriteLine("File Name: " + System.IO.Path.GetFileName(path));
            Console.WriteLine("File Name without Extension: " + System.IO.Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: " + System.IO.Path.GetDirectoryName(path));
        }
    }
}
