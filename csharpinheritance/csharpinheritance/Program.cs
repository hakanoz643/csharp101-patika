using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpinheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var instance = new Erkek();
            instance.ad = "hakan";
            instance.tc_id = 1;

            Console.WriteLine(instance.ad);
            Console.WriteLine(instance.tc_id);

            Console.ReadLine();
        }
    }

    public class Erkek:Insan
    {
        public string sakal{ get; set; }
        public string biyik { get; set; }

    }
    public class Kadın:Insan
    {
        public string makyaj { get; set; }
    }

    public class Insan
    {
        public string ad{ get; set; }
        public string yas { get; set; }

        public string meslek { get; set; }
        public int  tc_id { get; set; }


    }
}
