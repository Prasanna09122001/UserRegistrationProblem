﻿using System;
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




        public string UserDetails(string name,string lname, string email, string phone,string pass)
        {
            try
            {
                if (name1.FirstName1(name) && (name1.LastName1(lname)) && (email1.emailverify1(email)) && (phoneNumber1.phoneno1(phone)) && (password1.pass1(pass)))
                {
                    return "Correct";
                }
                else
                {
                    return "Incorrect";
                }
            }catch(Exception)
            {
                return "Do it Correctly";
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
