using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApp
{
    class Participant : AssignmentObject
    {
  

        public void printParticipant()
        {
            System.Console.WriteLine("A participant called " + this.getName());
        }
    }
}
