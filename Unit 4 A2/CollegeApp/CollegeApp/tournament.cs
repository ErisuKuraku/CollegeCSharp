﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApp
{
    class tournament
    {
        string tournamentname;
        List<Events> events =new List<Events>();
        string eventname;

        public void addEvent(Events e)
        {
            if (events.Count >= 5)
            {
                Console.WriteLine("Too many teams");
            }
            else
            {
                events.Add(e);
            }
        }

        public void setName(string s)
        {
            this.eventname = s;
        }

        public string getEvent()
        {
            return eventname;
        }

        public void printEvent()
        {
            Console.WriteLine("A team called " + events);
        }

        public void printTournament()
        {
            for (int i = 0; i < events.Count; i++)
            {
               // events[i].printEvent();
            }
        }
    }

}