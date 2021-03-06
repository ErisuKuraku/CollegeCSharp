using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApp
{
    class Team : AssignmentObject
    {
        string teamname;
        List<Participant> members =new List<Participant>();

        public void setName(String s)
        {
            this.teamname = s;
        }

        public string getName()
        {
            return teamname;
        }

        public void addParticipant(Participant p)
        {
            if (members.Count >= 5)
            {
                Console.WriteLine("Team is already full");
            }
            else
            {
                members.Add(p);
            }
        }

        public void printTeam()
        {
            Console.WriteLine("A team called " + teamname);
            Console.WriteLine("It has the following members:");
            for (int i = 0; i < members.Count; i++)
            {
                members[i].printParticipant();
            }
        }
    }
}

// (c) Ellis Clarke 2021
// You are allowed to copy and modify according to the MIT License agreement
// https://github.com/ErisuKuraku/CollegeCSharp/blob/main/LICENSE
