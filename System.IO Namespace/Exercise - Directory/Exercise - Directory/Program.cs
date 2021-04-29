using System;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace Exercise___Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:\temp");

            var files = Directory.GetFiles(@"C:\Users\ellis\Documents\GitHub\CollegeCSharp\System.IO Namespace\Exercise - Directory", "*.sln*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine();
            }

            var directories =
                Directory.GetDirectories(@"C:\Users\ellis\Documents\GitHub\CollegeCSharp\System.IO Namespace\Exercise - Directory", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }

            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }
    }
}
