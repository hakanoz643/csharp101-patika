using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneDirectory.Services;
using PhoneDirectory.Models;
using System.Linq.Expressions;

namespace PhoneDirectory
{
    public class Program
    {
        public static List<PhoneModel> datalist=new List<PhoneModel>();
        public static void Main(string[] args)
        {
            var datas = new Fakedata();
            datalist = datas.SelectData();
            AnaMenu();
        }
        public static void AnaMenu()
        {
            Console.WriteLine("Yapmak İstediğiniz İşlemi Seçin.\n");
            Console.WriteLine("********************************\n\n");

            Console.WriteLine("(1) Yeni Numara Kaydetmek.\n");
            Console.WriteLine("(2) Varolan Numarayı Silmek.\n");
            Console.WriteLine("(3) Varolan Numarayı Güncellemek.\n");
            Console.WriteLine("(4) Rehberi Listelemek.\n");
            Console.WriteLine("(5) Rehberde Arama Yapmak.\n");
            Console.WriteLine("(0) Konsolu Temizlemek.\n");

            int islemturu = int.Parse(Console.ReadLine());

            switch (islemturu)
            {
                case 1:
                    PhoneAdd phoneAdd = new PhoneAdd();
                    phoneAdd.AddOperation(datalist);
                    break;
                case 2:
                    PhoneDelete phoneDelete = new PhoneDelete();
                    phoneDelete.DeleteOperation(datalist);
                    break;
                case 3:
                    PhoneUpdate phoneUpdate = new PhoneUpdate();
                    phoneUpdate.UpdateOperation(datalist);
                    break;
                case 4:
                    var phoneList = new PhoneDictionarList();
                    phoneList.ListOperation(datalist);
                    break;
                case 5:
                    var phoneSearch = new PhoneDictionarySearch();
                    phoneSearch.SearchOperation(datalist);
                    break;
                case 0:
                    Console.Clear();
                    AnaMenu();
                    break;
            }

            Console.WriteLine("*****************************\n");
            Console.WriteLine("(1) Ana Menü");
            var a = Console.ReadLine();
            if (a=="1")
            {
                AnaMenu();
            }
        }
    }
}
