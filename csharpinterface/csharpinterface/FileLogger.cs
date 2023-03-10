using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpinterface
{
    internal class FileLogger : ILogger
    {
        public string Name => "ILogger";

        public void WriteLog()
        {
            Console.WriteLine("Dosyaya Yazma İşlemi Tamamlandı.");
        }
    }
}
