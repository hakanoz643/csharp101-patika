using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpinterface
{
    internal class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Veritabanına log kaydı atılmıştır.");
        }
    }
}
