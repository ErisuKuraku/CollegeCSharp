using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CollegeApp
{
    class UI
    {
        List<Participant> allParticipants = new List<Participant>();
        List<Team> allTeams = new List<Team>();
        List<Events> allEvents = new List<Events>();
        private List<tournament> allTournaments = new List<tournament>();

        public int selectTeam()
        {
            for (int i = 0; i < allTeams.Count; i++)
            {
                Console.WriteLine(i + ": " + allTeams[i].getName());
            }

            Console.WriteLine("Select team: ");
            string input = Console.ReadLine();
            int result = Int32.Parse(input);
            return result;
        }

        public int selectParticipant()
        {
            for (int i = 0; i < allParticipants.Count; i++)
            {
                Console.WriteLine(i + ": " + allParticipants[i].getName());
            }

            Console.WriteLine("Select Participant: ");
            string input = Console.ReadLine();
            int result = Int32.Parse(input);
            return result;
        }

        public int selectEvent()
        {
            for (int i = 0; i < allEvents.Count; i++)
            {
                Console.WriteLine(i + ": " + allEvents[i].getName());
            }

            Console.WriteLine("Select event: ");
            string input = Console.ReadLine();
            int result = Int32.Parse(input);
            return result;
        }

        public int selectTournament()
        {
            for (int i = 0; i < allTournaments.Count; i++)
            {
                Console.WriteLine(i + ": " + allTournaments[i].getName());
            }

            Console.WriteLine("Select tournament: ");
            string input = Console.ReadLine();
            int result = Int32.Parse(input);
            return result;
        }

        public void mainMenu()
        {
            string choice = "start";
            while (!choice.Equals("quit"))
            {
                Console.WriteLine("");
                Console.WriteLine("1 - Enter new participant");
                Console.WriteLine("2 - Enter a new Team");
                Console.WriteLine("3 - Enter a New Event");
                Console.WriteLine("4 - Enter a new Tournament");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("5 - Add participant to team");
                Console.WriteLine("6 - Add team to event");
                Console.WriteLine("7 - Add event to Tournament");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("8 - Assign Rankings");
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
                        allParticipants.Add(p);
                        break;

                    case "2":
                        Console.WriteLine("Enter Team Name: ");
                        string teamName = Console.ReadLine();
                        Team t = new Team();
                        t.setName(teamName);
                        t.printTeam();
                        allTeams.Add(t);
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

                    case "5":
                        Team teamSelected = allTeams[selectTeam()];
                        Participant partSelected = allParticipants[selectParticipant()];
                        teamSelected.addParticipant(partSelected);
                        teamSelected.printTeam();
                        partSelected.printParticipant();
                        break;

                    case "6":
                        teamSelected = allTeams[selectTeam()];
                        Events eventSelected = allEvents[selectEvent()];
                        eventSelected.addTeam(allTeams[selectTeam()]);
                        eventSelected.printEvent();
                        teamSelected.printTeam();
                        break;

                    case "7":
                        eventSelected = allEvents[selectEvent()];
                        tournament tournamentSelected = allTournaments[selectTournament()];
                        tournamentSelected.addEvent(allEvents[selectEvent()]);
                        tournamentSelected.printTournament();
                        eventSelected.printEvent();
                        break;

                    case "8":
                        tournamentSelected = allTournaments[selectTournament()];
                        eventSelected = allEvents[selectEvent()];
                        Console.WriteLine("Which team came first?: ");
                        teamSelected = allTeams[selectTeam()];
                        
                        eventSelected.allocatePlace(teamSelected, 1);
                        eventSelected.getPoints(teamSelected);
                        for (int i= 2; i < allTeams.Count; i++)
                        {
                            Console.WriteLine("Which team came in position "+ i + "?");
                            teamSelected = allTeams[selectTeam()];
                            eventSelected.allocatePlace(teamSelected, 1);
                            eventSelected.getPoints(teamSelected);
                            // Place add to whole tournament

                        }
                        break;
                }
            }
        }
    }
}
