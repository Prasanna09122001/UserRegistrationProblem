using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UserRegistationProblem;

namespace UserRegistartionProblem
{
    public class Tester 
    {

        Name name1 = new Name();
        Email email1 = new Email();
        PhoneNumber phoneNumber1 = new PhoneNumber();
        Password password1 = new Password();
        int count = 0;

        public string UserDetails(string name,string lname, string email, string phone,string pass)
        {
            if (name1.Firstname(name) && (name1.LastName(lname)) && (email1.emailVerify(email)) && (phoneNumber1.phoneno(phone)) && (password1.pass(pass)))
            {
                return "Correct";
            }
            else
            {
                return "Incorrect";
            }
        }
        public string EmailVerify(string email)
        {
            if (email1.emailVerify(email))
                return "Correct";
            else
                return "Incorrcet";
        }
    }
}
