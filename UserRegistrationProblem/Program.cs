using System;

namespace UserRegistrationProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            UserRegistration userregistration = new UserRegistration();
           bool checkfirstname= userregistration.CheckFirstName("Siddhant");
            Console.WriteLine(checkfirstname);

        }
    }
}
