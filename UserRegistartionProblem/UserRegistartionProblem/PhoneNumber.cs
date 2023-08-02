using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistartionProblem
{
    internal class PhoneNumber
    {
        string phone_Regex = "^[0-9]{10}$";
        public void phoneno(string phonenumber)
        {
            bool result = Regex.IsMatch(phonenumber, phone_Regex);
            if (result)
            {
                Console.WriteLine("Your Phone Number is valid");
                Console.WriteLine("\nEnter your password");
                string password = Console.ReadLine();
                Password password1 = new Password();
                password1.pass(password);
            }
            else
            {
                Console.WriteLine("Your Phone Number is Not Valid\nEnter the Phone Number Correctly");
                phonenumber = Console.ReadLine();
                phoneno(phonenumber);
            }

        }
    }
}
