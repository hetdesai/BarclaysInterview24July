using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;
using FileData.BL;
namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            ValidateArgument  validateArgument = new ValidateArgument();
            validateArgument.CheckArgument(args);
            Console.ReadLine();
        }


    }
}
