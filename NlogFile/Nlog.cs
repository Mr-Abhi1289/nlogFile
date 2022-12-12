using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NlogFile
{
    internal class Nlog
    {
        public static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public void logdebug(string mesessge)
        {
            logger.Debug(mesessge);
        }
        public void LogError(string message)
        {
            logger.Debug( message);
        }

        public void LogInfo(string message)
        {
            logger.Debug(message);
        }    

    }
}
