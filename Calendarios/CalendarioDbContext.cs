using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Calendarios
{
    public class CalendarioDbContext: DbContext 
    {
        public DbSet<Calendario> Calendarios {get;set;}
        public DbSet<Evento> Eventos {get;set;}
        

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var constr= "server=localhost;database=Calendarios;uid=root;pwd=pwd123;port=3306;";
            optionsBuilder.UseMySql(constr,ServerVersion.AutoDetect(constr));
        }
    }
}