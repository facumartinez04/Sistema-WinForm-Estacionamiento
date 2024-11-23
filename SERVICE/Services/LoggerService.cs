using SERVICE.DAL;
using SERVICE.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE.Services
{
    public static class LoggerService
    {

        public static void WriteLog(Log log, Exception ex = null)
        {
            LoggerDao.WriteLog(log, ex);

        }
    }

}
