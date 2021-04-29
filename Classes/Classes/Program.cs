using System;
using System.Security.Cryptography.X509Certificates;
using Classes;

namespace Classes
{


    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();
        }
    }
}

