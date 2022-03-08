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
    /// Validating Name
    /// </summary>
        public static string Pattern = "^[A-Z][a-z]{2}";
        public bool ValidName(string Name)
        {
            return Regex.IsMatch(Name, Pattern);
        }
        
    }

}
