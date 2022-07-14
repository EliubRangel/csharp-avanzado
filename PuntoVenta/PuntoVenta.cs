namespace csharp_avanzado.PuntoVenta
{
    public class PuntoVenta
    {
        private Inventario Inventario;

        private List<Venta> VentasDia;

        public PuntoVenta()
        {
            this.Inventario = new Inventario();
            this.VentasDia = new List<Venta>();
        }

        // Metodo que se encarga de desplegar el menu del punto de venta
        // y va a ejecutar las acciones dependiendo de la opcion que se elija
        // 1. Hacer venta
        // 2. Ver inventario
        // 3. Registrar producto
        // 4. Ingresar inventario
        public void IniciarPuntoVenta()
        {
            int opcion = 0;
            Console.WriteLine("Bienvenido al punto de venta");
            do
            {
                Console.WriteLine("==============================");
                Console.WriteLine("Que deseas hacer?");
                Console.WriteLine("Opcion 0 Salir");
                Console.WriteLine("Opcion 1 Hacer Venta");
                Console.WriteLine("Opcion 2 Ver inventario");
                Console.WriteLine("Opcion 3 Registrar producto");
                Console.WriteLine("Opcion 4 Ingresar inventario");
                Console.WriteLine("==============================");
                opcion = Convert.ToInt32(Console.ReadLine());
                if (opcion == 1)
                {
                    string terminar = "";
                    List<DetalleInventario> detalleInventarios = new List<DetalleInventario>();

                    do
                    {
                        // Pedir el codigo de barras del producto
                        Console.WriteLine("Inserte el codigo de barras");
                        string codigoBarras = Console.ReadLine();

                        DetalleInventario detalle = this.Inventario.BuscarPorCodigoBarras(codigoBarras);
                        if (detalle == null)
                        {
                            Console.WriteLine($"No se encontro el producto {codigoBarras}");
                            continue;
                        }

                        Console.WriteLine("Inserte la cantidad:");
                        int cantidadVenta = int.Parse(Console.ReadLine());

                        if(detalle.Cantidad < cantidadVenta){
                            Console.WriteLine("No hay stock suficiente");
                            continue;
                        }
                        
                        detalleInventarios.Add(detalle);

                    }
                    while (terminar != "cerrar");



                    // Pedir la cantidad 
                }
                else if (opcion == 2)
                {
                    Console.WriteLine($"Codigo Barras  |  Descripcion  |  Precio  |  Cantidad");
                    for (int i = 0; i < this.Inventario.DetalleInventario.Count(); i++)
                    {
                        Console.WriteLine(this.Inventario.DetalleInventario[i]);
                    }
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("Informacion producto");
                    Console.WriteLine("Codigo de barras:");
                    string codigoBarras = Console.ReadLine();
                    Console.WriteLine("Descripcion del producto:");
                    string descripcion = Console.ReadLine();
                    Console.WriteLine("Precio:");
                    decimal precio = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Cantidad en inventario:");
                    int cantidad = Convert.ToInt32(Console.ReadLine());
                    bool productoAgregado = this.Inventario.AgregarProducto(codigoBarras, descripcion, precio, cantidad);
                    if (productoAgregado)
                        Console.WriteLine("Se agrego el producto correctamente");
                    else
                        Console.WriteLine($"El codigo de barras {codigoBarras} ya existe en el inventario");
                }
            }
            while (opcion > 0);
        }
    }
}