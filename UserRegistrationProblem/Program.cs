using System;

namespace UserRegistrationProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            UserRegistration userregistration = new UserRegistration();
            bool checklastname = userregistration.CheckEmail("Siddhant.shrivastava@gmail.co.in");
            Console.WriteLine(checklastname);

        }
    }
}
