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
        public static string Regex_Email = @"^[a-zA-Z]{3}[a-zA-Z\.]*[@][a-z]{2}[\.][a-z]{2}[\.a-z]*$";
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, Regex_Email);
        }
        public static string Regex_MobileNumber= @"^[0-9]{2}\s[0-9]{10}$";
        public bool ValidateMobileNumber(string mobileNumber)
        {
            return Regex.IsMatch(mobileNumber, Regex_MobileNumber);
        }
    }
}
