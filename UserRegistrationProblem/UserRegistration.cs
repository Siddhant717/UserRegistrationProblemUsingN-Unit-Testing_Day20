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
        public bool CheckFirstName(string firstName)
        {
            //First name starts with capital and should have min 3 characters
            string FirstNamePattern = @"^[A-Z]{1}[a-zA-Z]{2,}$";

            Regex firstnameregex = new Regex(FirstNamePattern);

           return firstnameregex.IsMatch(firstName);
        }
    }
}
