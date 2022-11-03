using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PrimerDb
{
    public class VeterinariaDbContext:DbContext
    {
        public DbSet<Cliente> Clientes {get;set;}
        public DbSet<Mascota> Mascotas {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=Veterinaria;uid=root;pwd=pwd123;port=3306;");
        }
        
    }
}