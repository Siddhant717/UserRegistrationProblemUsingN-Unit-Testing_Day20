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
        
        public bool CheckEmailSample(string password)
        {

            string EmailPattern = @"^([a-z]{3}([\.\+\-0-9]*)@[a-z0-9]{1,}.[a-z]{3,}[.a-z]*)";  

            Regex Emailregex = new Regex(EmailPattern);

            return Emailregex.IsMatch(password);
        }
    }
}
