using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpabstract
{
    abstract class Otomobil
    {
        public int KacTekerlektenOlusur() {
            return 4;
        } 

        public virtual string StandartRengiNe()
        {
            return "Beyaz";
        }

        public abstract string HangiMarkaninAraci();
        
    }
}
