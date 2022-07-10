using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class UserRegistration
    {
        public bool CheckEmail(string email)
        {

            string EmailPattern = @"^([A-Za-z]{3,}([.a-z]*)@[a-z]{2,}[.][a-z]{2,3}([.a-z]*))$";

            Regex Emailregex = new Regex(EmailPattern);

            return Emailregex.IsMatch(email);
        }
    }
}
