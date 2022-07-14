namespace csharp_avanzado.PuntoVenta
{
    public class Venta
    {
        public decimal Total { get; set; }
        public DateTime Fecha { get; set; }
        public List<DetalleVenta> DetallesVenta { get; set; }


    }

    public class DetalleVenta
    {
        public string CodigoBarras { get; set; }
        public int Cantidad { get; set; }
        public decimal Importe { get; set; }
    }

}