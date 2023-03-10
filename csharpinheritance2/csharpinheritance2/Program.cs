using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpinheritance2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c = new c();
            Console.WriteLine(c.data);
            Console.WriteLine(c.data2);
            Console.ReadLine();
        }
    }

    public class a
    {
        public int data { get; set; }
         public a(int x)
        {
            data = x;
        }
    }
    public  class b:a
    {
        public int data2 { get; set; }
        public b(bool x):base(3)
        {
            data2 = 2;
        }
    }
    public class c:b
    {
        public c() : base(true){

        }
    }
}
