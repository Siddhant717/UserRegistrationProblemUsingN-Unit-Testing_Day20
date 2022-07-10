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
        public void CheckLastName()
        {
            string lasttName = "Shrivastava";
            UserRegistration userregist = new UserRegistration();
            var result = userregist.CheckLastName(lasttName);

            //Assert
            Assert.IsTrue(result);

        }
    }
}