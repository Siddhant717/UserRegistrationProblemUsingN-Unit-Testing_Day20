using System;

namespace UserRegistrationProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            UserRegistration userregistration = new UserRegistration();
            bool checkpassword = userregistration.CheckUserPassword("SiDdhanT@17");
            Console.WriteLine(checkpassword);

        }
    }
}
