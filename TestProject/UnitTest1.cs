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
            string mobnumber = "91 9923443332";
            UserRegistration userregist = new UserRegistration();
            var result = userregist.CheckMobileNumber(mobnumber);
           

            Assert.IsTrue(result);

        }
    }
}