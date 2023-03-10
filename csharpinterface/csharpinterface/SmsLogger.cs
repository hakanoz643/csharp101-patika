using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpinterface
{
    public class SmsLogger:ILogger
    {
        void ILogger.WriteLog()
        {
            Console.WriteLine("Sms ile log atıldı.");
        }

    }
}
