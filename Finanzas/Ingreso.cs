using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace csharp_avanzado.Finanzas
{
    public class Ingreso
    {
        public int Id{get;set;}
        public DateTime Fecha{get;set;}
        public decimal Importe{get;set;}
        public string Descripcion{get;set;}
        
        public Ingreso(DateTime Fecha, decimal Importe, string Descripcion)
        {
            this.Fecha=Fecha;
            this.Importe=Importe;
            this.Descripcion=Descripcion;
            this.Id= Id;
        }
        public override string ToString()
        {
            return $"{Id.ToString().PadRight(10)}{Fecha.ToLongTimeString().PadRight(20)}{Importe.ToString().PadRight(20)}{Descripcion.PadRight(20)}";
        }

    }
}