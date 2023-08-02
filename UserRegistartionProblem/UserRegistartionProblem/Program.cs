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

        }
    }
}

