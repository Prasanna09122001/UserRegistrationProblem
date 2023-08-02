using System;
using UserRegistartionProblem;

namespace UserRegistationProblem
{
    class program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the User Registation Problem");
            Console.WriteLine("Enter Your Name with First Letter Capital");
            string name = Console.ReadLine();
            Name name1 = new Name();
            name1.name(name);

        }
    }
}

