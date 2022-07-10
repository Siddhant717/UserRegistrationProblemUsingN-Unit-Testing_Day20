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
        
        public void ChecKEmailSample()
        {
            string EmailSample = "abc.100@abc.com.au";
            UserRegistration userregist = new UserRegistration();
            var result = userregist.CheckEmailSample(EmailSample);
           

            Assert.IsTrue(result);

        }
    }
}