using System;

namespace UserRegistrationProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            UserRegistration userregistration = new UserRegistration();
           bool checklastname= userregistration.CheckLasttName("Shrivastava");
            Console.WriteLine(checklastname);

        }
    }
}
