using UserRegistartionProblem;

namespace UserRegistationProblem
{
    class program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the User Registation Problem");
            Name name1 = new Name();
            Email email1 = new Email();
            PhoneNumber phoneNumber1 = new PhoneNumber();
            Password password1 = new Password();
             Console.WriteLine("Enter Your Name with First Letter Capital");
             string fname = Console.ReadLine();
             name1.Firstname(fname);
             Console.WriteLine("Enter Your Name with Last Letter Capital");
             string Lname = Console.ReadLine();
             name1.LastName(Lname);
             Console.WriteLine("Enter Your Correct Email.Id");
             string email = Console.ReadLine();
             email1.emailVerify(email);
             Console.WriteLine("Enter Your phone Number");
             string phonenumber = Console.ReadLine();
             phoneNumber1.phoneno(phonenumber);
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();
            password1.pass(password);


        }
    }
}

