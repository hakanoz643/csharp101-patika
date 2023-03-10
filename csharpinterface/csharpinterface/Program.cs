using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpinterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var instance = new LogManager(new SmsLogger());
            instance.WriteLog();
            Console.ReadLine();
        }
    }
}
