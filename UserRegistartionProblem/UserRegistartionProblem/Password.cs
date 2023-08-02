using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistartionProblem
{
    internal class Password
    {
        string password_Regex= "^[0-9a-zA-Z!@#%&*~$]{8,}$";
        public void pass(string password)
        {
            bool result = Regex.IsMatch(password, password_Regex);
            if (result)
                Console.WriteLine("Your password is valid");
            else
                Console.WriteLine("Your password is Not Valid");
        }
    }
}
