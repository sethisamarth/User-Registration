using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Pattern
    {
        public static string Regex_FirstName = "^[A-D][a-zA-Z]{2,}$";
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, Regex_LastName);
        }
        public static string Regex_LastName = "^[A-D][a-zA-Z]{2,}$";
        public bool ValidateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, Regex_LastName);
        }
    }
}
