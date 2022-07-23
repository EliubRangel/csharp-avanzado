namespace csharp_avanzado.PuntoVenta
{
    public class Venta
    {
        public decimal Total { get; set; }
        public DateTime Fecha { get; set; }
        public List<DetalleVenta> DetallesVenta { get; set; }
        public Venta()
        {
            this.DetallesVenta = new List<DetalleVenta>();
        }

        public void ProcesarVenta(){
            for(int i=0; i<DetallesVenta.Count;i++)
            {
                Total=Total+DetallesVenta[i].Importe;
            }
            Fecha= DateTime.Now;
        }

        public override string ToString()
        {
            string vtaStr = "";

            foreach(DetalleVenta detVta in DetallesVenta)
            {
                vtaStr = $"{vtaStr}{detVta}\n";
            }
            vtaStr = $"{vtaStr} Total: {Total}";
            return vtaStr;
        }
    }

    public class DetalleVenta
    {
        public string CodigoBarras { get; set; }
        public int Cantidad { get; set; }
        public decimal Importe { get; set; }

        public DetalleVenta(string codigoBarras, int cantidad,decimal importe)
        {
            this.CodigoBarras = codigoBarras;
            this.Cantidad = cantidad;
            this.Importe = importe;
        }
        public override string ToString()
        {
            return $"{CodigoBarras.PadRight(10)}|{Cantidad.ToString().PadRight(10)}|{Importe.ToString().PadRight(10)}";
        }
    }

}