﻿using Restaurant;
int Opcion = 0;
List<Alimento>ListaAlimento = new List<Alimento>();
List<Orden>ListaOrden = new List<Orden>();


do
{
    Console.WriteLine("=========================");
    Console.WriteLine("Que deseas hacer?");
    Console.WriteLine("Opcion 1 Registrar alimento");
    Console.WriteLine("Opcion 2 consultar alimento");
    Console.WriteLine("Opcion 3 Registrar orden");
    Console.WriteLine("Opcion 4 consultar orden");
    Console.WriteLine("=========================");
    Opcion= int.Parse(Console.ReadLine());

    if(Opcion==1)
    {
        Console.WriteLine("Ingrese los datos del alimento");
        Console.WriteLine("Ingrese el Id del alimento");
        int Id = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese nombre del alimento");
        string Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese la descripcion del alimento");
        string Descripcion = Console.ReadLine();
        Console.WriteLine("Ingrese el precio del alimento");
        int precio = int.Parse(Console.ReadLine());
         Alimento alimento = new Alimento
         {
            Id = Id, 
            Nombre = Nombre,
            Descripcion = Descripcion,
            Precio = precio
         };
         ListaAlimento.Add(alimento);
    }
    if(Opcion==2)
         {
            Console.WriteLine("Ingrese el Id del alimento a buscar");
            int IdAlimento = int.Parse(Console.ReadLine());
            Alimento alimento = ListaAlimento.FirstOrDefault( x => x.Id ==IdAlimento);
            if (alimento != null)
                 Console.WriteLine(alimento);
             else 
             Console.WriteLine($"No se encontro el alimento con el id {IdAlimento}");
         }
         if(Opcion==3)
         {
            Console.WriteLine("Ingrese los datos de la orden");
            Console.WriteLine("Ingrese el Id de la orden");
            int Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de mesa");
            int NumeroMesa = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese nombre del comensal");
            string Nombrecomensal = Console.ReadLine();
            Orden orden = new Orden
            {
                Id= Id,
                NumeroMesa = NumeroMesa,
                Nombrecomensal = Nombrecomensal
            };
            int IdOrden = 0;    
            do
            {
                Console.WriteLine("Ingrese el Id de la orden - Presione 0 para terminar");
                IdOrden = int.Parse(Console.ReadLine());
                Orden orden = alim
            }
            while(Opcion == 0);

         }

}
while(Opcion !=0);

