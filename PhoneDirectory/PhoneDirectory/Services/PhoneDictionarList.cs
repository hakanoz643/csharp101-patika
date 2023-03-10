using PhoneDirectory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDirectory.Services
{
    public class PhoneDictionarList
    {
        public void ListOperation( List<PhoneModel> model)
        {
            Console.WriteLine("\n\n Kayıt Listeleme \n\n");

            foreach (var item in model)
            {
                Console.WriteLine("********************************\n\n");
                Console.WriteLine($"Ad:{item.ad}n\n");
                Console.WriteLine($"Soyad:{item.soyad}n\n");
                Console.WriteLine($"Numara:{item.numara}n\n");

            }
        }
    }
}
