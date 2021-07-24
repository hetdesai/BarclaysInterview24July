using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileData.ErrorHandler;
using ThirdPartyTools;

namespace FileData.BL
{
    public class FileSizeBL
    {

        public void GetFileSize(string fileName)
        {
            try
            {
                FileDetails fileDetails = new FileDetails();
                Console.WriteLine("Size of file " + fileName + " is " + fileDetails.Size(fileName));
            }
            catch (Exception ex)
            {
                ErrorHandler.ErrorHandler.LogError("PassSizeArgument", ex);
            }
        }
    }
}
