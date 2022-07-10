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
            string LastName = "Shrivastava";
            UserRegistration userregist = new UserRegistration();
            var result = userregist.CheckLasttName(LastName);

            //Assert
            Assert.IsTrue(result);
            

        }
    }
}