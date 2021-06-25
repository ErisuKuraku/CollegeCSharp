using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApp
{
    class Events
    { 
        string eventname;
        List<Team> teams =new List<Team>();
        List<string> types = new List<string>();
        string type;
        private Dictionary<Team, int> placing = new Dictionary<Team, int>();

        public void allLocatePlace(Team t, int i)
        {
            placing.Add(t, i);
        }

        public int getPoints(Team t)
        {
            int position = placing[t];
            int points = 0;
            switch (position)
            {
                case 1:
                    points = 15;
                    break;
                case 2:
                    points = 10;
                    break;
                case 3:
                    points = 5;
                    break;
                case 4:
                    points = 1;
                    break;

            }

            return points;

        }

        public Events()
        {
            types.Add("academic");
            types.Add("sporting");
        }
        public void setName(string s)
        {
            this.eventname = s;
        }

        public string getName()
        {
            return eventname;
        }

        public void setType(string s)
        {
            if (types.Contains(s))
            {
                type = s;
            }
            else
            {
                Console.WriteLine("This is not a valid type");
            }
        }

        public void printEvent()
        {
            Console.WriteLine("A " + type + " event called " + eventname);
        }

        public void addTeam(Team t)
        {
            if (teams.Count >= 4)
            {
                Console.WriteLine("Too many teams");
            }
            else
            {
                teams.Add(t);
            }
        }
    }
}
