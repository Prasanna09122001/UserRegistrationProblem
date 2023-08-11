using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace UserRegistartionProblem
{
    public class Email
    {
        string EmailRegex = "^[a-z]+[._+-]{0,1}[a-z0-9]+[@]{1}[a-z0-9]+[.]{1}[a-z]{2,3}([.]{1}[a-z]{2,3}){0,1}$";
        public bool emailVerify(string input)
        {
            bool result = Regex.IsMatch(input, EmailRegex);
            if (result)
            {
                Console.WriteLine("Your Email is valid");
                return true;
            }
            else
            {
                Console.WriteLine("Your Email is Not Valid");
                return false;
            }
        }
        public bool emailverify1(string input) => Regex.IsMatch(input, EmailRegex) ? true : false;
    }
}
