using System;
using System.Web;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Server;

namespace UrgentTest.Models
{
    public class ErrorRepository : IErrorRepository
    {
        public void LogError(Exception ex)
        {
            DateTime n = DateTime.Now;

            System.IO.File.AppendAllText("ErrorLog.txt", DateTime.Now.ToString() + " " + ex.Message + "\n");
        }
    }
}
