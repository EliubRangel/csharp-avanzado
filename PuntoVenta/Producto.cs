namespace csharp_avanzado.PuntoVenta
{
    public class Producto
    {
        public string CodigoBarras { get; set; }
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }

        public Producto(string codigoBarras, string descripcion, decimal precio)
        {
            this.CodigoBarras = codigoBarras;
            this.Descripcion = descripcion;
            this.Precio = precio;
        }
    }
}