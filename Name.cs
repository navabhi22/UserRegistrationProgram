using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Name
    {/// <summary>
    /// Validating FirstName
    /// </summary>
        public static string Pattern = "^[A-Z][a-z]{2}";
        public bool FirstName(string FirstName)
        {
            return Regex.IsMatch(FirstName, Pattern);
        }
    }
}
