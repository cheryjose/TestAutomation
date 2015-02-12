using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Automtion.Test.UI.Common
{
    public class NlogConfiguration
    {
        private static Logger log;

        public NlogConfiguration()
        {
            log = LogManager.GetCurrentClassLogger();
        }


    }
}
