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
        Console.WriteLine("Ingrese tarifa");
        int Tarifa= int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese fecha");
        DateTime Fecha= DateTime.ParseExact(Console.ReadLine(),"dd-MM-yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine("Ingrese pasajero");
        string Pasajero= Console.ReadLine();
    }
    if (Opcion==2)
    {
        Console.WriteLine("Ingrese el Id del viaje a buscar");
        for(int i=0; i<ListaViajes.Count();i++)
        {
            Console.WriteLine(ListaViajes[i]);
            
        }
    }
    if (Opcion==3)
    {
        
    }
}
while (Opcion!=0);
