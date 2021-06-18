using System;

namespace CollegeApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Participant p = new Participant();
            p.setName("James");

            Team t = new Team();
            t.setName("James' Team");
            t.addParticipant(p);
            t.printTeam();

            p.setName("John");
            p.printParticipant();

            Events e = new Events();
            e.setName("Skillz");
            e.setType("academic");

            e.printEvent();
        }
    }
}
