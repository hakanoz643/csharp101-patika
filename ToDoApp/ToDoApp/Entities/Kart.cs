using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Entities;

namespace ToDoApp.Entities
{
    public class Kart
    {
        
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public int AtananId{ get; set; }
        public int Buyukluk { get; set; }
        public int hat { get; set; }
    }
}
