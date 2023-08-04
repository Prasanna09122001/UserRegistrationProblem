using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistartionProblem
{
    public class Password
    {
        string password_Regex= "^[A-Z]{1,}[a-z]{5,}[!@#%&*~$]{1}[0-9]{1,}$";
        public bool pass(string password)
        {
            bool result = Regex.IsMatch(password, password_Regex);
            if (result)
            {
                Console.WriteLine("Your password is valid");
                return true;
            }
            else
            {

                Console.WriteLine("Your password is Not Valid");
                return false;

            }   
        }
    }
}
