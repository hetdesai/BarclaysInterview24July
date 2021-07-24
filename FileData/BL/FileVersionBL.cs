using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;
namespace FileData.BL
{
    public class FileVersionBL
    {
        public void GetFileVersion(string fileName)
        {
            try
            {
                FileDetails fileDetails = new FileDetails();
                Console.WriteLine("Version of file " + fileName + " is " + fileDetails.Version(fileName));
            }
            catch (Exception ex)
            {
                ErrorHandler.ErrorHandler.LogError("GetFileVersion", ex);
            }
        }
    }
}
