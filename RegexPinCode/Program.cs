using System;
using System.Dynamic;

namespace RegexPinCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattern patterns = new Pattern();
            bool result = patterns.validatePinCode("1234567");
            Console.WriteLine(result);
        }
    }
}
