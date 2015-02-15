using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace TestAutomation.NLog
{
    public static class Log
    {
        public static Logger Logger = new LogFactory().GetCurrentClassLogger();
    }
}
