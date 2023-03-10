using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpinterface2
{
    internal class Jetta : IOtomobil
    {
        public BagajTipi HangiKasaTipinde()
        {
            return BagajTipi.Sedan;
        }

        public Marka HangiMarkaninAraci()
        {
            return Marka.Jetta;
        }

        public int Model()
        {
            return 2022;
        }
    }
}
