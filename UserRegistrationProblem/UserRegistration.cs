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
        public bool CheckLastName(string lasttName)
        {
     
            string LasttNamePattern = @"^[A-Z]{1}[a-zA-Z]{2,}$";

            Regex lastnameregex = new Regex(LasttNamePattern);

            return lastnameregex.IsMatch(lasttName);
        }
    }
}
