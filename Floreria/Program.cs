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
            Console.WriteLine("No se encontro la flor con el Id indicado");
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
    }
    
}
while(Opcion !=0);
