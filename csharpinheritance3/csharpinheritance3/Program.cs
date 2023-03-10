using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpinheritance3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ikincielaraba= new ikincielaraba();

            
            Console.WriteLine(ikincielaraba.fiyati());
            Console.ReadLine();
        }
    }

    class araba
    {
        public int fiyat = 500;
        
        public virtual int fiyati()
        {
            return fiyat - 100;
        }
    }

    class ikincielaraba:araba
    {
        public override int fiyati()
        {
            return fiyat-200;
        }
    }
}
