using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneDirectory.Models;
namespace PhoneDirectory
{
    public class Fakedata
    {
        public List<PhoneModel> SelectData()
        {
            List<PhoneModel> datas = new List<Models.PhoneModel>();
            var data1 = new PhoneModel() {ad="Hakan",soyad="Öz",numara="44444444" };
            var data2 = new PhoneModel() {ad="Funda",soyad="Koşucu",numara="55555555"};


            datas.Add(data2);
            datas.Add(data1);
            return datas;
        }

    }
}
