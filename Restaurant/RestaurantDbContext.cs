using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Restaurant
{
    public class RestaurantDbContext:DbContext
    {
        public DbSet<Orden> Orden{get;set;}
        public DbSet<Alimento> Alimento{get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var constr= "server=localhost;database=Restaurant2;uid=root;pwd=pwd123;port=3306;";
            optionsBuilder.UseMySql(constr,ServerVersion.AutoDetect(constr));
            // optionsBuilder.UseMySQL("server=localhost;database=Restaurant;uid=root;pwd=pwd123;port=3306;");
        }
        
    }
}