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
        public void Test1()
        {
            string firstName = "Siddhant";
            UserRegistration userregist = new UserRegistration();
            var result = userregist.CheckFirstName(firstName);

            //Assert
            Assert.IsTrue(result);

        }
    }
}