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
        string password_Regex= "^[A-Z]{1,}[a-z]{5,}[!@#%&*~$]{1}[0-9]{1,}$";
        public void pass(string password)
        {
            bool result = Regex.IsMatch(password, password_Regex);
            if (result)
                Console.WriteLine("Your password is valid");
            else
            {
                Console.WriteLine("Your password is Not Valid\n Enter the Password Again");
                password = Console.ReadLine();
                pass(password);
            }   
        }
    }
}
