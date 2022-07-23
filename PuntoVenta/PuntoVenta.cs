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
                Console.WriteLine("Opcion 5 Total del dia");
                Console.WriteLine("==============================");
                opcion = Convert.ToInt32(Console.ReadLine());
                if (opcion == 1)
                {
                    string terminar = "";
                    List<DetalleInventario> detalleInventarios = new List<DetalleInventario>();
                    Venta vta = new Venta();

                    do
                    {
                        // Pedir el codigo de barras del producto
                        Console.WriteLine("Inserte el codigo de barras");
                        string codigoBarras = Console.ReadLine();

                        DetalleInventario detalleInv = this.Inventario.BuscarPorCodigoBarras(codigoBarras);
                        if (detalleInv == null)
                        {
                            Console.WriteLine($"No se encontro el producto {codigoBarras}");
                            continue;
                        }

                        Console.WriteLine("Inserte la cantidad:");
                        int cantidadVenta = int.Parse(Console.ReadLine());

                        if(detalleInv.Cantidad < cantidadVenta){
                            Console.WriteLine("No hay stock suficiente");
                            continue;
                        }
                        
                        detalleInventarios.Add(detalleInv);
                        DetalleVenta detalleVenta = new DetalleVenta(detalleInv.ProductoInventario.CodigoBarras,cantidadVenta,detalleInv.ProductoInventario.Precio*cantidadVenta);
                        vta.DetallesVenta.Add(detalleVenta);

                        Console.WriteLine("Escriba terminar para procesar la venta o Enter para continuar");
                        terminar = Console.ReadLine();
                    }
                    while (terminar != "terminar");
                    //procesar venta
                    vta.ProcesarVenta();

                    //reducir inventario
                    Inventario.ReducirInventario(vta.DetallesVenta);
                    VentasDia.Add(vta);
                    Console.WriteLine(vta);
                }
                else if (opcion == 2)
                {
                    Console.WriteLine($"{"Codigo Barras".PadRight(10)}|{"Descripcion".PadRight(30)}|{"Precio".PadRight(5)}|{"Cantidad".PadRight(3)}");
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
                else if(opcion == 4)
                {
                    Console.WriteLine("Informacion producto");
                    Console.WriteLine("Codigo de barras:");
                    string codigoBarras = Console.ReadLine();
                    Console.WriteLine("Cantidad a ingresar:");
                    int cantidad = Convert.ToInt32(Console.ReadLine());
                    if(Inventario.AumentarInventario(codigoBarras,cantidad))
                    {
                        Console.WriteLine($"Se agregaron {cantidad} unidades al producto {codigoBarras}");
                    }
                    else
                    {
                        Console.WriteLine($"No existe el producto con codigo de barras {codigoBarras}");
                    }
                }
                else if(opcion == 5)
                {
                    decimal total = 0;
                    foreach(Venta vta in VentasDia)
                    {
                        total += vta.Total;
                    }
                    Console.WriteLine($"El total de ventas del dia es {total}");
                }
            }
            while (opcion > 0);
        }
    }
}