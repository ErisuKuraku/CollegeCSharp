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
                Console.WriteLine("2 - Enter a new Team");
                Console.WriteLine("3 - Enter a New Event");
                Console.WriteLine("4 - Enter a new Tournament");
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
                        Console.WriteLine("Enter Team Name: ");
                        string teamName = Console.ReadLine();
                        Team t = new Team();
                        t.setName(teamName);
                        t.printTeam();
                        break;

                    case "3":
                        Console.Write("Event Name: ");
                        string eventName = Console.ReadLine();
                        Console.WriteLine("Enter Type: ");
                        string eventType = Console.ReadLine();
                        Events e = new Events();
                        e.setName(eventName);
                        e.setType(eventType);
                        e.printEvent();
                        break;

                    case "4":
                        Console.WriteLine("Enter Tournament Name: ");
                        string tournamentName = Console.ReadLine();
                        tournament o = new tournament();
                        o.setName(tournamentName);
                        o.printTournament();
                        break;
                }
            }
        }
    }
}
