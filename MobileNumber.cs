using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class MobileNumber
    {
        public class PatternMobileNum
        {
            public static string Regex_Pattern = "^[+][9][1][' ']*[7-9][0-9]{9}$";
            public bool ValidateNumber(string number)
            {
                return Regex.IsMatch(number, Regex_Pattern);
            }
        }
    }
}
