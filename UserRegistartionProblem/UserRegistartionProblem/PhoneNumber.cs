using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UserRegistartionProblem
{
    public class PhoneNumber
    {
        string phone_Regex = "^[0-9]{10}$";
        public bool phoneno(string phonenumber)
        {
            bool result = Regex.IsMatch(phonenumber, phone_Regex);
            if (result)
            {
                Console.WriteLine("Your Phone Number is valid");
                return result;
            }
            else
                Console.WriteLine("Your Phone Number is Not Valid"); 
                return result;
        }
    }
}
