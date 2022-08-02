namespace csharp_avanzado.Finanzas
{
    public class Gastos
    {
        public DateTime Fecha{get;set;}
        public decimal Importe{get;set;}
        public string Descripcion{get;set;}

       
    
        
        public Gastos (DateTime fecha,decimal Importe,string descripcion)
        {
            this.Descripcion=descripcion;
            this.Fecha=fecha;
            this.Importe=Importe;

        }
         public override string ToString()
         {
            return $"{Fecha.ToLongTimeString().PadRight(20)}|{Importe.ToString().PadRight(20)}|{Descripcion.PadRight(20)}";
         }
        
    }
}