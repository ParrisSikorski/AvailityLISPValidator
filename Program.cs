using System;
using System.Collections.Generic;

namespace AvailityLISPValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                var validator = new Validator();
                var isValid = validator.IsValid(args[0]);
            }
        }
    }    
}
