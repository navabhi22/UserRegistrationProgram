using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Password
    {
        String passRegex = "^(?=.*[A-Z])(?=.*[0-9])([a-zA-Z0-9]*).{8,}$";
        public bool Rule3(string password)
        {
            return Regex.IsMatch(password, passRegex);
        }
    }
}
