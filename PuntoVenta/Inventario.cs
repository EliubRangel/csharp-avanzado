namespace csharp_avanzado.PuntoVenta
{
    public class Inventario
    {
        public List<DetalleInventario> DetalleInventario { get; set; }

        public Inventario()
        {
            this.DetalleInventario = new List<DetalleInventario>()
            {
                new DetalleInventario(new Producto("123","Computador Dell",5000),10),
                new DetalleInventario(new Producto("345","teclado de computadora", 500),5),
                new DetalleInventario(new Producto("567","mouse",250),3),
                new DetalleInventario(new Producto("678","monitor",1500),6)
            };
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
        
        public bool AumentarInventario(string codigoBarras, int cnt)
        {
            DetalleInventario detInv = BuscarPorCodigoBarras(codigoBarras);
            if(detInv == null)
                return false;
            detInv.Cantidad += cnt;
            return true;
        }

        public void ReducirInventario(List<DetalleVenta> detalleVentas){
            for(int i = 0; i < detalleVentas.Count; i++){
                DetalleVenta detalleVenta = detalleVentas[i];
                for(int j=0; j<DetalleInventario.Count; j++){
                    if(DetalleInventario[j].ProductoInventario.CodigoBarras == detalleVenta.CodigoBarras){
                        DetalleInventario[j].Cantidad -= detalleVenta.Cantidad;
                    }
                }
            }
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
            return $"{ProductoInventario.CodigoBarras.PadRight(13)}|{ProductoInventario.Descripcion.PadRight(30)}|{ProductoInventario.Precio.ToString().PadRight(5)}|{Cantidad.ToString().PadRight(3)}";
        }
    }
}