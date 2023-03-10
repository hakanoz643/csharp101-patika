using PhoneDirectory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDirectory.Services
{
    class PhoneUpdate
    {
        public void UpdateOperation(List<PhoneModel> model)
        {
            Console.WriteLine("\n\n Kayıt Güncelleme \n\n");
            Console.WriteLine("********************************\n\n");

            Console.WriteLine(" Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:\r\n");
            var userinfo = Console.ReadLine();

            if (!(model.Where(x=>x.ad==userinfo || x.soyad==userinfo).ToList().Count>0))
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\r\n");
                Console.WriteLine(" * Güncellemeyi sonlandırmak için    : (1)\r\n");
                Console.WriteLine(" * Güncellemeyi yeniden denemek için    : (2)\r\n");

                var exitcontrol = Console.ReadLine();
                if (exitcontrol=="2")
                {
                    UpdateOperation(model);
                }
            }
            else
            {
                var data = new PhoneModel();
                Console.WriteLine("\n\n Yeni Kayıt Eklemek \n\n");
                Console.WriteLine("********************************\n\n");

                Console.WriteLine("\n İsminizi Giriniz.");
                data.ad = Console.ReadLine();

                Console.WriteLine("\n  Soyadınızı Giriniz.");
                data.soyad = Console.ReadLine();

                Console.WriteLine("\n  Numaranızı Giriniz.");
                data.numara = Console.ReadLine();

                for (int i = 0; i < model.Count; i++)
                {
                    if (model[i].ad == userinfo || model[i].soyad == userinfo)
                    {
                        model[i] = data;
                    }
                }
            }
        }
    }
}
