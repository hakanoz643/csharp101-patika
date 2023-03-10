using PhoneDirectory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDirectory.Services
{
    public class PhoneAdd
    {
        public void AddOperation(List<PhoneModel> model) {

            var data = new PhoneModel();
            Console.WriteLine("\n\n Yeni Kayıt Eklemek \n\n");
            Console.WriteLine("********************************\n\n");
            
            Console.WriteLine("\n İsminizi Giriniz.");
            data.ad=Console.ReadLine();

            Console.WriteLine("\n  Soyadınızı Giriniz.");
            data.soyad = Console.ReadLine();

            Console.WriteLine("\n  Numaranızı Giriniz.");
            data.numara = Console.ReadLine();

            model.Add(data);

        }
    }
}
