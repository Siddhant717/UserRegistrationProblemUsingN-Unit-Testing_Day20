using NUnit.Framework;
using UserRegistrationProblem;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
   
        }

        [Test]
        public void CheckMobileNumber()
        {
            string password = "SidDhanT23";
            UserRegistration userregist = new UserRegistration();
            var result = userregist.CheckUserPassword(password);
           

            Assert.IsTrue(result);

        }
    }
}