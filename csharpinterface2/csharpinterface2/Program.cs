using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpinterface2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var focus = new Focus();
            Console.WriteLine("   "+focus.HangiMarkaninAraci());
            Console.WriteLine(" Marka:" + focus.Model().ToString() + " Kasa Tipi:"+focus.HangiKasaTipinde()+"\n");


            var jetta = new Jetta();
            Console.WriteLine("   " + jetta.HangiMarkaninAraci());
            Console.WriteLine(" Marka:" + jetta.Model().ToString()+" Kasa Tipi:"+jetta.HangiKasaTipinde());

            Console.ReadLine();
        }
    }
}
