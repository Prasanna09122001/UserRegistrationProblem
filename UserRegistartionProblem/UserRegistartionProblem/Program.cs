using System;
using UserRegistartionProblem;

namespace UserRegistationProblem
{
    class program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the User Registation Problem");
            Name name1 = new Name();
            Console.WriteLine("Enter Your Name with First Letter Capital");
            string fname = Console.ReadLine();
            name1.name(fname);
            Console.WriteLine("Enter Your Name with Last Letter Capital");
            string Lname = Console.ReadLine();
            name1.name(Lname);
            Console.WriteLine("Enter Your Correct Email.Id");
            string email = Console.ReadLine();
            Email email1 = new Email();
            email1.emailVerify(email);


        }
    }
}

