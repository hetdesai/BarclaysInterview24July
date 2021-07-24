using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;
namespace FileData.BL
{
    public class VersionPrototypeBL
    {
        public void CheckVersionPrototype(string[] args)
        {
            try
            {
                if(args.Length != 2)
                {
                    Console.WriteLine("This program takes 2 command line arguments only. You have provided " + args.Length + "arguments");
                }
                else
                {
                    if(args[0].ToLower() == "-v")
                    {
                        ThirdPartyTools.FileDetails fileDetails = new FileDetails();
                       Console.WriteLine("Version of file " + args[1] + " is " + fileDetails.Version(args[1]));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong. Please contact system administrator");
                System.IO.File.AppendAllText("error.txt", DateTime.Now.ToString("dd/MM/yyyy") + " Method: CheckVersionPrototype()  -" + ex.ToString() + "\n");
            }
        }
    }
}
