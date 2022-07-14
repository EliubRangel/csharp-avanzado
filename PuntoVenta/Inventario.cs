namespace csharp_avanzado.PuntoVenta
{
    public class Inventario
    {
        public List<DetalleInventario> DetalleInventario { get; set; }

        public Inventario()
        {
            this.DetalleInventario = new List<DetalleInventario>();
        }

        public bool AgregarProducto(string codigoBarras, string descripcion, decimal precio, int cantidad)
        {
            // Paso 1. Validar que no exista el codigo de barras
            bool existeCodigoBarras = false;

            for(int i=0; i<DetalleInventario.Count(); i++){
                if(DetalleInventario[i].ProductoInventario.CodigoBarras == codigoBarras){
                    existeCodigoBarras = true;
                }
            }

            if(existeCodigoBarras)
                return false;

            // Paso 2. Agregar el producto al inventario
            Producto producto = new Producto(codigoBarras,descripcion, precio);
            DetalleInventario detalle = new DetalleInventario(producto,cantidad);
            this.DetalleInventario.Add(detalle);
            return true;
        }

        public DetalleInventario BuscarPorCodigoBarras(string codigoBarras){
            DetalleInventario detalleBusqueda = null;
            for(int i = 0; i< this.DetalleInventario.Count; i++){
                DetalleInventario det = this.DetalleInventario[i];

                if(det.ProductoInventario.CodigoBarras == codigoBarras){
                    detalleBusqueda = det;
                }
                
            }

            return detalleBusqueda;
        }
    }

    public class DetalleInventario
    {
        public Producto ProductoInventario { get; set; }
        public int Cantidad { get; set; }
        public DetalleInventario(Producto producto, int cantidad)
        {
            this.ProductoInventario = producto;
            this.Cantidad = cantidad;
        }

        public override string ToString()
        {
            return $"{ProductoInventario.CodigoBarras} {ProductoInventario.Descripcion} {ProductoInventario.Precio} {Cantidad}";
        }
    }
}