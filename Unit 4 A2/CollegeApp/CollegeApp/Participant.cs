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

// (c) Ellis Clarke 2021
// You are allowed to copy and modify according to the MIT License agreement
// https://github.com/ErisuKuraku/CollegeCSharp/blob/main/LICENSE