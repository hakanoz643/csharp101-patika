using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Entities;

namespace ToDoApp.Context
{
    public  class TodoAppContext:DbContext
    {
        public DbSet<Kart> karts { get; set; }

        public DbSet<Kisi> kisis { get; set; }
    }
}
