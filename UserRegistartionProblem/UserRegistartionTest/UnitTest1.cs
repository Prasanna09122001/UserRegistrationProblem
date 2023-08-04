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
    }
}