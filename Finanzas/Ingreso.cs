namespace csharp_avanzado.Finanzas
{
    public class Ingreso
    {
        public DateTime Fecha{get;set;}
        public decimal Importe{get;set;}
        public string Descripcion{get;set;}
        
        public Ingreso(DateTime Fecha, decimal Importe, string Descripcion)
        {
            this.Fecha=Fecha;
            this.Importe=Importe;
            this.Descripcion=Descripcion;
        }
        public override string ToString()
        {
            return $"{Fecha.ToLongTimeString().PadRight(20)}{Importe.ToString().PadRight(20)}{Descripcion.PadRight(20)}";
        }

    }
}