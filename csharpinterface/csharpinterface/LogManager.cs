using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpinterface
{
    public class LogManager:ILogger
    {
        public ILogger logger;
        public LogManager(ILogger _logger)
        {
            logger = _logger;
        }

        public void WriteLog()
        {
            logger.WriteLog();
        }
    }
}
