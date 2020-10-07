using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace RegexPinCode
{
    class Pattern
    {
        //aaaaa, sdfg45// pincode -> 6digi, 
        string Regex_PinCode = ("^[1-9]{5}$");
        public bool validatePinCode(string pincode)
            {
            return Regex.IsMatch(pincode, Regex_PinCode);
        }
    }
}

