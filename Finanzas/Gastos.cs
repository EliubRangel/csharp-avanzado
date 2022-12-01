using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace csharp_avanzado.Finanzas
{
    public class Gastos
    {
        public int Id{get;set;}
        public DateTime Fecha{get;set;}
        public decimal Importe{get;set;}
        public string Descripcion{get;set;}

       
    
        
        public Gastos (DateTime fecha,decimal Importe,string descripcion)
        {
            this.Id=Id;
            this.Descripcion=descripcion;
            this.Fecha=fecha;
            this.Importe=Importe;

        }
         public override string ToString()
         {
            return $"{Id.ToString().PadRight(10)}{Fecha.ToLongTimeString().PadRight(20)}|{Importe.ToString().PadRight(20)}|{Descripcion.PadRight(20)}";
         }
        
    }
}