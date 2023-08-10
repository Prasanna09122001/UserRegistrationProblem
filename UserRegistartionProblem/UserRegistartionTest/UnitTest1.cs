using System.Runtime.InteropServices;
using UserRegistartionProblem;

namespace UserRegistartionTest
{
    public class Tests
    {   [Test]
        public void TestFakeRegistation()
        {
            Tester tester = new Tester();
            string test = tester.UserDetails("Prasanna","Venkatesh","pras@gmail.com","6369988552","Prasanna@123");
            Assert.AreEqual("Correct",test);
        }

        [Test]
        public void MultipleEmail()
        {
            Tester tester = new Tester();
            string[] email = {"abc@gmail.com","abc-100@yahoo.com","abc.100@yahoo.com","abc111@abc.com","abc-100@abc.net",
                              "abc.100@abc.com.au","abc@1.com","abc@gmail.com.com","abc+100@gmail.com"};
            foreach(var data in email)
            {
                string test = tester.EmailVerify(data);
                Assert.AreEqual("Correct", test);
            }
        }

    }
}