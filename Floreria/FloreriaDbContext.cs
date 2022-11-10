using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Floreria
{
    public class FloreriaDbContext:DbContext
    {
        public DbSet<Pedido> Pedidos {get;set;}
        public DbSet<Flor> Flores {get;set;}

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=Floreria;uid=root;pwd=pwd123;port=3306;");
        }
        
    }
}