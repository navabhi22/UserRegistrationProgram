using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class eMail
    {
        public static string Regex_Pattern = "^[a-zA-Z]+[a-zA-Z0-9]*[- . + _]?[a-zA-Z0-9]+[@]{1}[a-z0-9]+[.]{1}[a-z]+[.]?[a-z]+$";
        public bool ValidateEmail(string eMail)
        {
            return Regex.IsMatch(eMail, Regex_Pattern); 
        }
    }
}
