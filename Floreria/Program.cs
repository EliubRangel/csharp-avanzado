using Floreria;
int Opcion= 0;
List<Flor> ListaFlores = new List<Flor>();
List<Pedidos> ListaPedidos = new List<Pedidos>();
do 
{
  Console.WriteLine("==============================");
    Console.WriteLine("Que deseas hacer?");
    Console.WriteLine("Opcion 0 Salir");
    Console.WriteLine("Opcion 1 Regitrar flor");
    Console.WriteLine("Opcion 2 Consultar flor");
    Console.WriteLine("Opcion 3 registrar pedido");
    Console.WriteLine("Opcion 4 Consultar pedido");
    Console.WriteLine("==============================");
    Opcion = int.Parse(Console.ReadLine());
    

    if(Opcion==1)
    {
        Console.WriteLine("Ingrese los datos de la flor");
        Console.WriteLine("Ingrese Id de la flor");
        int Id= int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrse nombre de la flor");
        string NombreFlor= Console.ReadLine();
        Console.WriteLine("Ingrese descripcion de la flor");
        string Descripcion= Console.ReadLine();
        Console.WriteLine("Ingrese precio de la flor");
        int Precio= int.Parse(Console.ReadLine());
        Flor flor = new Flor(Id,NombreFlor,Descripcion,Precio);
        ListaFlores.Add(flor);
    }
    if(Opcion==2)
    {
        Console.WriteLine("Ingrese el Id de la flor a buscar");
        int IdFlor = int.Parse(Console.ReadLine());
        // Flor flor = ListaFlores.FirstOrDefault((Flor x)=> x.Id == IdFlor);
        Flor flor = ListaFlores.FirstOrDefault(x => x.Id == IdFlor);
        if(flor != null)
            Console.WriteLine(flor);
        else
            Console.WriteLine($"No se encontro la flor con el Id {IdFlor}");
    }
    if(Opcion==3)
    {
        Console.WriteLine("Ingrese los datos del pedido");
        Console.WriteLine("Ingrese Id del pedido ");
        int Id = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese nombre del destinatario");
        string Destinatario = Console.ReadLine();
        Console.WriteLine("Direccion del pedido");
        string Direccion =Console.ReadLine();
        Console.WriteLine("Ingrese el telefono del contacto");
        string TelefonoContacto = Console.ReadLine();
        Pedidos Pedidos = new Pedidos (Id,Destinatario,Direccion,TelefonoContacto);
        int IdFlor = 0;
        do{
            Console.WriteLine("Ingrese el id de la flor - Ingrese 0 para terminar");
            IdFlor = int.Parse(Console.ReadLine());
            if(IdFlor != 0){
                Flor flor = ListaFlores.FirstOrDefault(x => x.Id == IdFlor);
                if(flor != null)
                    Pedidos.Flores.Add(flor);
                else
                    Console.WriteLine($"La flor con el id {IdFlor} no existe");
            }
        }while(IdFlor!=0);

        ListaPedidos.Add(Pedidos);
    }
    if (Opcion==4)
    {
        
        Console.WriteLine("Ingrese el Id del pedido a buscar");
        int IdPedidos = int.Parse(Console.ReadLine());
        Pedidos pedidos = ListaPedidos.FirstOrDefault(x => x.Id == IdPedidos);
        if (pedidos != null)
            Console.WriteLine(pedidos);
        else 
            Console.WriteLine ($"No se encontro el pedido con el Id{IdPedidos}");

    }
    
}
while(Opcion !=0);
