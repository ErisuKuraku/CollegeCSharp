using System;
using System.IO;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\ellis\Google Drive\Pictures\Annotation.png";
            File.Copy(@path, @"e:\\", true);
            File.Delete(path);
            if (File.Exists(path))
            {
                //Do Something
            }

            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                // Do Something
            }
        }
    }
}
