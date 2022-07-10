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
        //Testing the Password that should have min 8 characters with atleast 1 UpperCase,1 NumericNumber & 1 SpecialCharcter
        public void ChecKUserPassword()
        {
            string password = "SidDhanT@23";
            UserRegistration userregist = new UserRegistration();
            var result = userregist.CheckUserPassword(password);
           

            Assert.IsTrue(result);

        }
    }
}