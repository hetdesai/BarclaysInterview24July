using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData.ErrorHandler
{
    public static class ErrorHandler
    {
        public static void LogError(string methodName, Exception ex)
        {
            try
            {
                Console.WriteLine("Something went wrong. Please contact system administrator");
                System.IO.File.AppendAllText("error.txt", DateTime.Now.ToString("dd/MM/yyyy") + " Method: "  + methodName +  "-" + ex.ToString());
            }
            catch(Exception exception)
            {
                Console.WriteLine("Something went wrong. Please contact system administrator");
                System.IO.File.AppendAllText("error.txt", DateTime.Now.ToString("dd/MM/yyyy") + " Method: LogError -" + exception.ToString());
            }
            
        }

    }
}
