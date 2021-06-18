using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApp
{
    class Events
    { 
        string eventname;
        List<string> types = new List<string>();
        string type;
        public Events()
        {
            types.Add("academic");
            types.Add("sporting");
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
            Console.WriteLine("A event called " + eventname);
        }
    }
}
