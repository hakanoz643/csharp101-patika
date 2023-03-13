using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Context;
using ToDoApp.Entities;

namespace ToDoApp.Services
{
    public  class İslemler
    {
        public string BuyuklukGetir(int deger)
        {
            //Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :

            switch (deger)
            {
                case 1:
                    return "XS";
                case 2:
                    return "S";
                case 3:
                    return "M";

                case 4:
                    return "L";

                case 5:
                    return "XL";

                default:
                    return "bos";
            }
        }
        public void Listeleme()
        {
            using (var context = new TodoAppContext())
            {
                var pano = (from t1 in context.karts join t2 in context.kisis 
                            on t1.AtananId equals t2.Id  
                            select new {t1.Icerik,t1.Buyukluk,t1.hat,t1.Baslik,t2.TamAd} );

                var firstlist= pano.Where(x=>x.hat==1).ToList();

                Console.WriteLine("\nTODO Line\n************************\r\n");
                foreach (var item in firstlist)
                {
                    Console.WriteLine($"Başlık     :"+item.Baslik);
                    Console.WriteLine($"İçerik     :"+ item.Icerik);
                    Console.WriteLine($"Atanan Kişi:"+ item.TamAd);
                    Console.WriteLine($"Büyüklük   :"+ BuyuklukGetir(item.Buyukluk));

                }

                Console.WriteLine("\nIN PROGRESS Line\n************************\r\n");
                var secondlist = pano.Where(x => x.hat == 2).ToList();
                foreach (var item in secondlist)
                {
                    Console.WriteLine($"Başlık     :"+ item.Baslik);
                    Console.WriteLine($"İçerik     :"+ item.Icerik);
                    Console.WriteLine($"Atanan Kişi:"+ item.TamAd);
                    Console.WriteLine($"Büyüklük   :"+ BuyuklukGetir(item.Buyukluk));

                }

                Console.WriteLine("\nDONE Line\n************************\r\n");

                var rdList = pano.Where(x => x.hat == 3).ToList();
                foreach (var item in rdList)
                {
                    Console.WriteLine($"Başlık     :"+ item.Baslik);
                    Console.WriteLine($"İçerik     :"+ item.Icerik);
                    Console.WriteLine($"Atanan Kişi:"+ item.TamAd);
                    Console.WriteLine($"Büyüklük   :"+ BuyuklukGetir(item.Buyukluk));

                }
            }
        }
        public void Ekleme()
        {
            using (var context = new TodoAppContext())
            {

                Console.WriteLine("Kart Ekleme \n**********\n");
                Console.WriteLine("Kisiler \n**********\n");

                var kisiler = (from k in context.kisis select k);
                foreach (Kisi item in kisiler)
                {
                    Console.WriteLine("-----" + "KisiId:"+item.Id+"Ad:"+item.TamAd+"-----");
                }
                Console.WriteLine("\nBaşlık Giriniz                              :");
                var baslik = Console.ReadLine();

                Console.WriteLine("İçerik Giriniz                                :");
                var icerik = Console.ReadLine();

                Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5):");
                var buyukluk = Console.ReadLine();

                Console.WriteLine(" Kişi Id Giriniz                              :");
                var kisi = Console.ReadLine();

                context.karts.Add(new Kart { Baslik = baslik, Icerik = icerik, Buyukluk = int.Parse(buyukluk), AtananId = int.Parse(kisi), hat=1 });
                context.SaveChanges();
            }
        }
        public void Silme()
        {
            Console.WriteLine("Kart Silme   \n.*****************\n");
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.\n");
            Console.WriteLine(" Lütfen kart başlığını yazınız:  \r\n");
            var cardtitle = Console.ReadLine();
            using (var context = new TodoAppContext())
            {
                var data = context.karts.Where(x=>x.Baslik==cardtitle).ToList();
                if (data.Count!=0)
                {
                    context.karts.Remove(data.First());
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.Lütfen kart başlığını yazınız:  \r\n");
                    Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için Herhangi Bir tuşa basınız.");
                    var control  = Console.ReadLine();
                    if (control!="1")
                    {
                        Silme();
                    }
                }
            }
        }
        public void Tasi()
        {
            Console.WriteLine("Kart Taşıma   \n.*****************\n");
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.\n");
            Console.WriteLine(" Lütfen kart başlığını yazınız:  \r\n");
            var cardtitle = Console.ReadLine();
            using (var context = new TodoAppContext())
            {
                var datas = context.karts.Where(x => x.Baslik == cardtitle).ToList();
                if (datas.Count != 0)
                {
                    var data= datas.First();
                    data.hat = data.hat == 1 ? 2 : data.hat == 2 ? 3 : data.hat == 3 ? 3 :1; 
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.Lütfen kart başlığını yazınız:  \r\n");
                    Console.WriteLine("* Taşımayı sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için Herhangi Bir tuşa basınız.");
                    var control = Console.ReadLine();
                    if (control != "1")
                    {
                        Tasi();
                    }
                }
            }
        }


    }
}
