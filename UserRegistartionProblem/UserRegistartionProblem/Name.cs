using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistartionProblem
{
    internal class Name
    {
        string name_Regex = "^[A-Z]{1}[a-z]{2,}";
        public void name(string name)
        {
            bool result = Regex.IsMatch(name, name_Regex);
            if (result)
                Console.WriteLine("The Given Name " + name + " is in Correct Format");
            else
                Console.WriteLine("The Given Name " + name + " is Not in Correct Format");
        }
    }
}
