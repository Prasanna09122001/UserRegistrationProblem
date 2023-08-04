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
                    Console.WriteLine("Phone Number is Valid");
                    return true;
                }
                else
                {
                    Console.WriteLine("The phone number is invalid");
                    return false;
                }
            

        }
    }
}
