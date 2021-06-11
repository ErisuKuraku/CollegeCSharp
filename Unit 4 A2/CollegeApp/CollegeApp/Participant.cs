using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApp
{
    class Participant
    {
        string personname;

        public void setName(string s)
        {
            this.personname = s;
        }

        public string getName()
        {
            return personname;
        }

        public void printParticipant()
        {
            Console.WriteLine("A participant called " + personname);
        }
    }
}
