using System;
using System.Dynamic;

namespace RegexPinCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Email Validation Process");
            CheckEmailList user = new CheckEmailList();
            user.CheckEmail();
            Console.WriteLine(user.email);
        }
    }
}
