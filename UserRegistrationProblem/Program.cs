using System;

namespace UserRegistrationProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            UserRegistration userregistration = new UserRegistration();
            bool Checkemailsample = userregistration.CheckEmailSample("abc.100@abc.com.au");
            Console.WriteLine(Checkemailsample);

        }
    }
}
