using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace FileData.BL
{
    public class ValidateArgument
    {
        public void CheckArgument(string[] args)
        {
            try

            {
                List<string> versionArgumentList = new List<string> { "-v", "--v", "/v", "--version" };
                List<string> sizeArgumentList = new List<string> { "-s", "--s", "/s", "--size" };
                string argument = args[0];
                argument = argument.Trim().ToLower();
                if (args.Length == 2)
                {
                    if (versionArgumentList.Contains(argument))
                    {
                        FileVersionBL fileVersionBL = new FileVersionBL();
                        fileVersionBL.GetFileVersion(args[1]);


                    }
                    else if (sizeArgumentList.Contains(argument))
                    {
                        FileSizeBL fileSizeBL = new FileSizeBL();
                        fileSizeBL.GetFileSize(args[1]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid first argument. Please find below list of available options");
                        Console.WriteLine("To check version of file use either of below");
                        foreach (string s in versionArgumentList)
                        {
                            Console.WriteLine(s + "\n");
                        }
                        Console.WriteLine("To check size of file use either of below");
                        foreach (string s in sizeArgumentList)
                        {
                            Console.WriteLine(s + "\n");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid number of commandline arguments.This console application accepts 2 command line arguments only");
                }
                
            }
            catch (Exception ex)
            {
                ErrorHandler.ErrorHandler.LogError("CheckSizeArgument", ex);

            }
        }
    }
}
