using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace csharp_avanzado.Finanzas
{
    public class Presupuesto
    {
        public int Id {get;set;}
        public List<Ingreso> ListaIngresos{get;set;}
        
        public decimal TotalIngresos{get;set;}
        public decimal Restante{get;set;}
        public Presupuesto()
        {
            this.ListaIngresos= new List<Ingreso>();
        }
        
         
        public void AgregarIngreso(decimal Importe,string Descripcion)
        {
            Ingreso ingreso= new Ingreso(DateTime.Now,Importe,Descripcion);
            this.ListaIngresos.Add(ingreso);
            TotalIngresos=TotalIngresos+Importe;
            Restante=Restante+Importe;
            Id=Id;
            
            
        } 
        public void AplicarGasto(decimal gasto)
        {
            Restante=Restante-gasto;

        }
        public override string ToString()
        {
            string vtaStr= " ";
            foreach(Ingreso x in ListaIngresos)
            {
                vtaStr= $"{vtaStr}{x}\n";
            }
            return vtaStr;
        }




        
    }
}