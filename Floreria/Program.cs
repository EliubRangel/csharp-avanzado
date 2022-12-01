using Floreria;
using Microsoft.EntityFrameworkCore;
int Opcion= 0;
var context = new FloreriaDbContext();
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
        context.Flores.Add(flor);
        context.SaveChanges();
    }
    if(Opcion==2)
    {
        Console.WriteLine("Ingrese el Id de la flor a buscar");
        int IdFlor = int.Parse(Console.ReadLine());
        // Flor flor = ListaFlores.FirstOrDefault((Flor x)=> x.Id == IdFlor);
        Flor flor = context.Flores.FirstOrDefault(x => x.Id == IdFlor);
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
        Pedido Pedidos = new Pedido (Id,Destinatario,Direccion,TelefonoContacto);
        int IdFlor = 0;
        do{
            Console.WriteLine("Ingrese el id de la flor - Ingrese 0 para terminar");
            IdFlor = int.Parse(Console.ReadLine());
            if(IdFlor != 0){
                Flor flor = context.Flores.FirstOrDefault(x => x.Id == IdFlor);
                if(flor != null)
                    Pedidos.Flores.Add(flor);
                else
                    Console.WriteLine($"La flor con el id {IdFlor} no existe");
            }
        }while(IdFlor!=0);

        context.Pedidos.Add(Pedidos);
        context.SaveChanges();
    }
    if (Opcion==4)
    {
        
        Console.WriteLine("Ingrese el Id del pedido a buscar");
        int IdPedidos = int.Parse(Console.ReadLine());
        Pedido pedidos = context.Pedidos
            .Include(x => x.Flores)
            .FirstOrDefault(x => x.Id == IdPedidos);
        if (pedidos != null)
            Console.WriteLine(pedidos);
        else 
            Console.WriteLine ($"No se encontro el pedido con el Id{IdPedidos}");

    }
    
}
while(Opcion !=0);
