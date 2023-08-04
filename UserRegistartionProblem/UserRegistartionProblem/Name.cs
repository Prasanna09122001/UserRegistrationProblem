using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UserRegistartionProblem
{
    public class Name
    {
        public bool Firstname(string name)
        {
            string name_Regex = "^[A-Z]{1}[a-z]{2,}";
            {
                bool result = Regex.IsMatch(name, name_Regex);
                if (result)
                {
                    Console.WriteLine("The Given Name " + name + " is in Correct Format");
                    return true;
                }
                else
                {
                    Console.WriteLine("The Given Name " + name + " is Not in Correct Format");
                    return false;
                }
            }
        }
        public bool LastName(string Lname)
        {
            string name_Regex = "^[A-Z]{1}[a-z]{2,}";
            {
                bool result = Regex.IsMatch(Lname, name_Regex);
                if (result)
                {
                    Console.WriteLine("The Given Name " + Lname + " is in Correct Format");
                    return true;
                }
                else
                {
                    Console.WriteLine("The Given Name " + Lname + " is Not in Correct Format");
                    return false;
                }

            }
        }
    }
}
