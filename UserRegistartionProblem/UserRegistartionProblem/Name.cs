using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UserRegistartionProblem
{
    internal class Name
    {
        string name_Regex = "^[A-Z]{1}[a-z]{2,}";
        public void Firstname(string name)
        {
            bool result = Regex.IsMatch(name, name_Regex);
            if (result)
            {
                Console.WriteLine("The Given Name " + name + " is in Correct Format");
                 Console.WriteLine("\nEnter Your Last Name with First Letter  Capital");
                 string Lastname = Console.ReadLine();
                 LastName(Lastname);
            }
            else
            {
                Console.WriteLine("The Given Name " + name + " is Not in Correct Format\n Enter the Name Again");
                name = Console.ReadLine();
                Firstname(name);
            }
        }
        public void LastName(string Lname)
        {
            bool result = Regex.IsMatch(Lname, name_Regex);
            if (result)
            {
                Console.WriteLine("The Given Name " + Lname + " is in Correct Format");
                Console.WriteLine("\nEnter Your Correct Email.Id");
                string email = Console.ReadLine();
                Email email1 = new Email();
                email1.emailVerify(email);
            }
            else
            {
                Console.WriteLine("The Given Name " + Lname + " is Not in Correct Format\n Enter the Last Name Again");
                Lname = Console.ReadLine();
                LastName(Lname);
                
            }
        }
    }
}
