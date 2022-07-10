using System;

namespace UserRegistrationProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            UserRegistration userregistration = new UserRegistration();
            bool checklastname = userregistration.CheckLastName("Shrivastava");
            Console.WriteLine(checklastname);

        }
    }
}
