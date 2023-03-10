using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpabstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var oto1 = new Audi();
            Console.WriteLine(oto1.KacTekerlektenOlusur());
            Console.WriteLine(oto1.HangiMarkaninAraci());
            Console.WriteLine(oto1.StandartRengiNe());

            var oto2 = new Bmw();
            Console.WriteLine(oto2.KacTekerlektenOlusur());
            Console.WriteLine(oto2.HangiMarkaninAraci());
            Console.WriteLine(oto2.StandartRengiNe());
            Console.ReadKey();
        }
    }
}
