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
        private List <AssignmentObject> listToSearch;

        public int selectWhatever(string whatever)
        {
            listToSearch = new List<AssignmentObject>();
            switch (whatever)
            {
                case "team":
                    listToSearch.AddRange(allTeams);
                    break;
                case "participant":
                    listToSearch.AddRange(allParticipants);
                    break;
                case "events":
                    listToSearch.AddRange(allEvents);
                    break;
                case "tournament":
                    listToSearch.AddRange(allTournaments);
                    break;
            }
            for (int i = 0; i < listToSearch.Count; i++)
            {
                Console.WriteLine(i + ": " + listToSearch[i].getName());
            }
            Console.WriteLine("Select team: ");
            string input = Console.ReadLine();
            int result = Int32.Parse(input);
            return result;
        }


        public void mainMenu()
        {
            string choice = "start";
            while (!choice.Equals("quit"))
            {
                Console.Clear();     // Clears the terminal window before running another option
                Console.WriteLine("-----College Tournament App-----");
                Console.WriteLine("");
                Console.WriteLine("Main Menu:");
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
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("1 - Enter new participant");
                        Console.WriteLine("");

                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();
                        Participant p = new Participant();
                        p.setName(name);
                        p.printParticipant();
                        allParticipants.Add(p);  // Adds "p" to the all participants list
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("2 - Enter a new Team");
                        Console.WriteLine("");

                        Console.WriteLine("Enter Team Name: ");
                        string teamName = Console.ReadLine();
                        Team t = new Team();   // Creates a new team under t
                        t.setName(teamName);    // t has the name set as teamName
                        t.printTeam();     
                        allTeams.Add(t);
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("3 - Enter a New Event");
                        Console.WriteLine("");

                        Console.Write("Event Name: ");
                        string eventName = Console.ReadLine();
                        Console.WriteLine("Enter Type: ");
                        string eventType = Console.ReadLine();
                        Events e = new Events();
                        e.setName(eventName);    // Sets name to the event listing
                        e.setType(eventType);    // sets its type
                        e.printEvent();          // Then prints it out
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("4 - Enter a new Tournament");
                        Console.WriteLine("");

                        Console.WriteLine("Enter Tournament Name: ");
                        string tournamentName = Console.ReadLine();
                        tournament o = new tournament();    
                        o.setName(tournamentName);
                        o.printTournament();  // Displays the tournament
                        break;

                    case "5":
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("5 - Add participant to team");
                        Console.WriteLine("");

                        Team teamSelected = allTeams[selectWhatever("team")];
                        Participant partSelected = allParticipants[selectWhatever("participant")];
                        teamSelected.addParticipant(partSelected);
                        teamSelected.printTeam();
                        partSelected.printParticipant();
                        break;

                    case "6":
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("6 - Add team to event");
                        Console.WriteLine("");

                        teamSelected = allTeams[selectWhatever("team")];
                        Events eventSelected = allEvents[selectWhatever("event")];
                        eventSelected.addTeam(allTeams[selectWhatever("team")]);   // Displays selection menu to pick from list of teams
                        eventSelected.printEvent();
                        teamSelected.printTeam();
                        break;

                    case "7":
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("7 - Add event to Tournament");
                        Console.WriteLine("");

                        //eventSelected = allEvents[selectEvent()];
                        tournament tournamentSelected = allTournaments[selectWhatever("tournament")];
                        tournamentSelected.addEvent(allEvents[selectWhatever("event")]);  // Adds events and saves it under selected tournament
                        tournamentSelected.printTournament();
                        //eventSelected.printEvent();
                        break;

                    case "8":
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("8 - Assign Rankings");
                        Console.WriteLine("");

                        tournamentSelected = allTournaments[selectWhatever("tournament")];
                        eventSelected = allEvents[selectWhatever("event")];
                        Console.WriteLine("Which team came first?: ");
                        teamSelected = allTeams[selectWhatever("team")];
                        
                        eventSelected.allocatePlace(teamSelected, 1);  // Sends the team and placing to the relevant class
                        eventSelected.getPoints(teamSelected);  // 
                        eventSelected.pointsTally(teamSelected, 1);

                        for (int i= 2; i < allTeams.Count; i++)
                        {
                            Console.WriteLine("Which team came in position "+ i + "?");
                            teamSelected = allTeams[selectWhatever("team")];
                            eventSelected.allocatePlace(teamSelected, i);
                            eventSelected.getPoints(teamSelected);
                            eventSelected.pointsTally(teamSelected, i);
                            

                        }
                        break;
                }
            }
        }
    }
}
