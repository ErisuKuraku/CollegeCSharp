using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApp
{
    class tournament : AssignmentObject
    {
        string tournamentname;
        List<Events> events =new List<Events>();
        string eventname;
        

        public void addEvent(Events e)
        {
            if (events.Count >= 5)     // Checks how many events are currently assigned
            {
                Console.WriteLine("Too many events");
            }
            else
            {
                events.Add(e);
            }
        }

        public void setName(string o)
        {
            this.tournamentname = o;
        }
        public string getEvent()
        {
            return eventname;
        }

        public void printEvent()
        {
            Console.WriteLine("A team called " + events);
        }

        public string getName()
        {
            return tournamentname;
        }

        public void printTournament()
        {
            Console.WriteLine("The Tournament is called " + tournamentname + " and the events are: "); // Displays name and contents of tournament
            for (int i = 0; i < events.Count; i++)
            {
               events[i].printEvent();
            }
        }
    }

}
