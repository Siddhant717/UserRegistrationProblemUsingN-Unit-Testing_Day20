using System;

namespace UserRegistrationProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            UserRegistration userregistration = new UserRegistration();
            bool checkmobnum = userregistration.CheckMobileNumber("91 9933222454");
            Console.WriteLine(checkmobnum);

        }
    }
}
