using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Context;
using ToDoApp.Entities;

namespace ToDoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new TodoAppContext())
            {
                var kisiler = (from t in context.kisis select t).ToList();
                if (kisiler.Count==0)
                {
                    var kisi1 = new Kisi() { TamAd="Bilge Kunt",Id=1};
                    var kisi2 = new Kisi() { TamAd = "Barkın Akşit", Id = 2 };
                    var kisi3 = new Kisi() { TamAd = "Gümüş Pektemek", Id = 3 };

                    context.kisis.Add(kisi1);
                    context.kisis.Add(kisi2);
                    context.kisis.Add(kisi3);
                    context.SaveChanges();
                }
            }
            Menuler();
        }

        public static void Menuler()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) \n");
            Console.WriteLine("*******************************************\n");


            Console.WriteLine("(1) Board Listelemek\r\n");
            Console.WriteLine("(2) Board'a Kart Eklemek\r\n");
            Console.WriteLine("(3) Board'dan Kart Silmek\r\n");
            Console.WriteLine("(4) Kart Taşımak\r\n");
            Console.WriteLine("(5) Paneli Temizleme\r\n");

            var islem = Console.ReadLine();
            var islemler = new Services.İslemler();
            switch (islem)
            {
                case "1":
                    islemler.Listeleme();
                    break;
                case "2":
                    islemler.Ekleme();
                    break;
                case "3":
                    islemler.Silme();
                    break;
                case "4":
                    islemler.Tasi();
                    break;
                case "5":
                    Console.Clear();
                    break;
            }

            Menuler();
        }
    }
}
