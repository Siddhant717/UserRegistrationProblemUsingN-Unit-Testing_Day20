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
        public bool CheckLasttName(string lastName)
        {
            
            string LasttNamePattern = @"^[A-Z]{1}[a-z]{2,}$";

            Regex lasttnameregex = new Regex(LasttNamePattern);

           return lasttnameregex.IsMatch(lastName);
        }
    }
}
