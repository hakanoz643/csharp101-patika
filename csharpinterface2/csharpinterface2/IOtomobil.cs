using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpinterface2
{
    internal interface IOtomobil
    {
        Marka HangiMarkaninAraci();
        int Model();
        BagajTipi HangiKasaTipinde();
    }
}
