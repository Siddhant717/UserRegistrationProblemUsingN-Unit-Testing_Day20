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
        public void CheckEmail()
        {
            string email = "Siddhant.shrivastava@gmail.co.in";
            UserRegistration userregist = new UserRegistration();
            var result = userregist.CheckEmail(email);
           

            Assert.IsTrue(result);

        }
    }
}