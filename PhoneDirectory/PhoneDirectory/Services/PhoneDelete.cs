using PhoneDirectory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDirectory.Services
{
    public class PhoneDelete
    {
        public void DeleteOperation(List<PhoneModel> model)
        {
            Console.WriteLine("\n\n Numaraya Göre Kayit Silme \n\n");
            Console.WriteLine("********************************\n\n");

            Console.WriteLine("\n\n Lütfen Silmek İstedğiniz Kaydın Numarasını Giriniz. \n\n");
            var siliniceknumara = Console.ReadLine();
            var item = model.Where(x=>x.numara== siliniceknumara).ToList();
            if (item.Count>0)
            {
                Console.WriteLine($"{item.First().ad} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                var control=Console.ReadLine();
                if (control=="y")
                {
                    model.Remove(item.First());
                }
            }
            else
            {
                Console.WriteLine("Böylee Bir Kayit Bulunmamaktadır.\n");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)\n");
                Console.WriteLine("* Yeniden denemek için      : (2)\n");
                var control=Console.ReadLine();

                if (control=="2")
                {
                    DeleteOperation(model);
                }
            }
        }
        
    }
}
