using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UrgentTest.Models
{
    public interface IErrorRepository
    {
        void LogError(Exception ex);
    }
}
