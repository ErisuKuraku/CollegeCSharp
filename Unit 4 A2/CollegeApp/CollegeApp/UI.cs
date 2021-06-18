using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApp
{
    class UI
    {
        public void mainMenu()
        {
            string choice = "start";
            while (!choice.Equals("quit"))
            {
                Console.WriteLine("1 - Enter new participant");
                Console.WriteLine("or type quit");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();
                        Participant p = new Participant();
                        p.setName(name);
                        p.printParticipant();
                        break;

                    case "2":
                        break;
                }
            }
        }
    }
}
