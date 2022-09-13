using System;
using System.Globalization;
using MisEventos;
List<Evento> ListaEventos = new List<Evento>();
List<Invitado> ListaINvitado = new List<Invitado>();


int Opcion = 0;
do
{
    Console.WriteLine("=========================");
    Console.WriteLine("Que deseas hacer?");
    Console.WriteLine("Opcion 0 salir");
    Console.WriteLine("Opcion 1 Crear evento");
    Console.WriteLine("Opcion 2 Regitrar invitado");
    Console.WriteLine("Opcion 3 Ver lista de invitados");
    Console.WriteLine("=========================");
    Opcion = Convert.ToInt32(Console.ReadLine());

    if (Opcion == 1)
    {
        Console.WriteLine("Evento Proximo");
        
        Console.WriteLine("Ingresa el ID del evento");
        int ID = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingresa el nombre del evento");
        string Nombre= Console.ReadLine();
        Console.WriteLine("Ingresa descripcion del evento");
        string Descripcion= Console.ReadLine();
        Console.WriteLine("Ingresa la fecha del evento dd-MM-yyyy");
        DateTime FechaEvento= DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy",CultureInfo.InvariantCulture); 
        Evento evt = new Evento(ID, Nombre, Descripcion, FechaEvento);
        ListaEventos.Add(evt);
    }
    else if (Opcion == 2)
    {
        Console.WriteLine("Ingresa el ID del evento");
        int IDEvento= int.Parse(Console.ReadLine());
        Evento evt = null;
        for(int i=0;i <ListaEventos.Count();i++)
        {
            Console.WriteLine(ListaEventos[i]);
            if(ListaEventos[i].ID==IDEvento )
            {
                evt = ListaEventos[i];
            }
        }
        Console.WriteLine("Ingrese nombre del invitado");
        string NombreInvitado= Console.ReadLine();
        Console.WriteLine("Ingrese Direccion del invitado");
        string DireccionInvitado= Console.ReadLine();
        Console.WriteLine("Ingrese el telefono del invitado");
        string Telefono (Console.ReadLine());
        evt.AgregarInvitado(NombreInvitado,DireccionInvitado,TelefonoInvitado);

    }
    else if (Opcion==3)
    {
        Console.WriteLine(ListaINvitado);
    }

}
while (Opcion != 0);