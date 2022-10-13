using System.Globalization;
using Viajes;

List<Viaje>ListaViajes= new List<Viaje>();
int Opcion= 0;


do
{
    
   Console.WriteLine("==============================");
    Console.WriteLine("Que deseas hacer?");
    Console.WriteLine("Opcion 0 Salir");
    Console.WriteLine("Opcion 1 Regitrar Viaje");
    Console.WriteLine("Opcion 2 Mostrar total");
    Console.WriteLine("Opcion 3 Imprimir datos");
    Console.WriteLine("==============================");
    Opcion = int.Parse(Console.ReadLine());

    if (Opcion==1)
    {
        
        Console.WriteLine("Ingresar datos");
        Console.WriteLine("Ingresa el Id del viaje");
        int Id= int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese distancia");
        int Distancia= int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese tarifa");
        int Tarifa= int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese fecha dd-MM-yyyy");
        DateTime Fecha= DateTime.ParseExact(Console.ReadLine(),"dd-MM-yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine("Ingrese pasajero");
        string Pasajero= Console.ReadLine();
        Viaje vj = new Viaje(Id,Distancia,Tarifa,Fecha,Pasajero);
        ListaViajes.Add(vj);
    }
    if (Opcion==2)
    {
        Console.WriteLine("Ingrese el Id del viaje a buscar");
        int Id= int.Parse(Console.ReadLine());

        Viaje vj = ListaViajes.FirstOrDefault(x => x.Id == Id);
        if(vj != null)
            Console.WriteLine(vj);
        else
            Console.WriteLine("No se encontro el viaje");

        for(int i=0; i<ListaViajes.Count();i++)
        {
            if(Id == ListaViajes[i].Id)
            {
                Console.WriteLine(ListaViajes[i]);
            }
        }
    }
    if (Opcion==3)
    { 
        foreach (Viaje vj in ListaViajes)
        {
            Console.WriteLine(vj);  
        }
     
    }
}
while (Opcion!=0);
