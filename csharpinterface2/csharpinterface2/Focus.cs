using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpinterface2
{
    internal class Focus : IOtomobil
    {
        public BagajTipi HangiKasaTipinde()
        {
            return BagajTipi.Hatchback;
        }

        public Marka HangiMarkaninAraci()
        {
            return Marka.Focus;
        }

        public int Model()
        {
            return 2015;
        }
    }
}
