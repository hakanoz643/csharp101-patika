using PhoneDirectory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDirectory.Services
{
    public class PhoneDictionarySearch
    {
        public void SearchOperation(List<PhoneModel> models)
        {
            Console.WriteLine("\n\n Numaraya Göre Kayit Arama");
            Console.WriteLine("********************************\n\n");

            Console.WriteLine("Aramak İstediğiniz Kayıtın Numarasını Giriniz.\n");
            var searchinfo = Console.ReadLine();

            var searchlist = models.Where(x => x.numara == searchinfo).ToList();
            if (searchlist.Count>0)
            {
                foreach (var item in searchlist)
                {
                    Console.WriteLine("********************************\n\n");
                    Console.WriteLine($"Ad:{item.ad}n\n");
                    Console.WriteLine($"Soyad:{item.soyad}n\n");
                    Console.WriteLine($"Numara:{item.numara}n\n");

                }
            }
            else
            {
                Console.WriteLine("Böyle Bir Kayıt Bulunamadı");
                Console.WriteLine(" * Aramayı sonlandırmak için    : (1)\r\n");
                Console.WriteLine(" * Aramayı yeniden denemek için    : (2)\r\n");

                var exitcontrol = Console.ReadLine();
                if (exitcontrol == "2")
                {
                    SearchOperation(models);
                }
            }
        }
    }
}
