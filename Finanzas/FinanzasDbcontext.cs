using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using csharp_avanzado.Finanzas;
using Microsoft.EntityFrameworkCore;


namespace Finanzas
{
    public class FinanzasDbcontext:DbContext
    {
        public DbSet<Gastos> Gastos{get;set;}
        public DbSet<Ingreso> Ingresos{get;set;}
        public DbSet<Presupuesto> presupuestos{get;set;}

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=Finanzas;uid=root;pwd=pwd123;port=3306;");
        }
    }
}