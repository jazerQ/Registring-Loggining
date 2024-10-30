using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WpfApp1
{
    static class Validator
    {
        public static bool IsValidEmail(string email) {
            Regex regex = new Regex(@"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                return true;
            }
            return false;
        }
        public static bool IsValidPassword(string pass)
        {
            Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\w\s]).{1,16}$");
            Match match = regex.Match(pass);
            if (match.Success)
            {
                return true;
            }
            return false;
        }
    }
}
