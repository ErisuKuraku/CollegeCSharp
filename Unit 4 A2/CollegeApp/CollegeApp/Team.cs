using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApp
{
    class Team
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
            members.Add(p);
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
