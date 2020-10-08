using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace RegexPinCode
{
    class CheckEmailList
    {

        public string Email;
        public CheckEmailList()
        {
            this.Email = "Email";
        }
        public string email { get; set; }
        private bool checkemail(string Email)
        {
            Regex regobj = new Regex("^[a-z0-9A-Z]+([._+-][a-z0-9A-Z]+)*[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2})?$");
            return (regobj.IsMatch(Email));
        }
        public void CheckEmail()
        {

            Console.Write("Enter the Valid Email Address-");
            string Email = Console.ReadLine();

            if (checkemail(Email))
            {
                Email = email;
            }
            else
            {
                Console.WriteLine("Invalid Mail");
                CheckEmail();
            }
        }
    }
}
