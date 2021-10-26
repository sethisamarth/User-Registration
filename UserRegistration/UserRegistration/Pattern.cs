using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
   public class Pattern
    {
        public static string Regex_FirstName = "^[A-D][a-zA-Z]{2,}$";
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, Regex_FirstName);
        }
    }
}
