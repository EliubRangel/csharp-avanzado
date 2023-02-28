using System.Globalization;
using Calendarios;
using Microsoft.EntityFrameworkCore;
int Opcion = 0;
var context = new CalendarioDbContext();



do
{
    Console.WriteLine("==============================");
    Console.WriteLine("Que deseas hacer?");
    Console.WriteLine("Opcion 0 Salir");
    Console.WriteLine("Opcion 1 Crear un calendario");
    Console.WriteLine("Opcion 2 Consultar calendario");
    Console.WriteLine("Opcion 3 Crear evento de calendario");
    Console.WriteLine("Opcion 4 Eliminar evento");
    Console.WriteLine("Opcion 5 Actualizar evento");
    Console.WriteLine("==============================");
    Opcion = int.Parse(Console.ReadLine());

    if (Opcion == 1)
    {

        Console.WriteLine("Crear un calendario");
        Console.WriteLine("Ingrese datos del calendario");
        Console.WriteLine("Nombre del calendario");
        string NombreCalendario = Console.ReadLine();
        Console.WriteLine("Ingrese descripcion");
        string Descripcion = Console.ReadLine();
        Calendario calendario = new Calendario(NombreCalendario, Descripcion);
        context.Calendarios.Add(calendario);
        context.SaveChanges();
        Console.WriteLine($"Su calendario se guardo con el Id {calendario.Id}");

    }

    if (Opcion == 2)
    {
        Console.WriteLine("Consultar calendario");
        Console.WriteLine("Ingrese el Id del calendario a buscar");
        int IdCalendario = int.Parse(Console.ReadLine());
        Calendario calendario = context.Calendarios.FirstOrDefault(x => x.Id == IdCalendario);
        Evento evento = context.Eventos.FirstOrDefault();

        if (calendario != null)
            Console.WriteLine(calendario);

        else
            Console.WriteLine($"No se encontro el calendario con el Id {IdCalendario}");
    }

    if (Opcion == 3)
    {
        Console.WriteLine("Creacion de evento");
        Console.WriteLine("Ingrese los datos del evento");
        Console.WriteLine("Ingrese el Id del calendario a buscar");
        int IdCalendario = int.Parse(Console.ReadLine());
        Calendario calendario = context.Calendarios.FirstOrDefault(x => x.Id == IdCalendario);
        if (calendario != null)
        {
            Console.WriteLine("Ingrese el titulo del evento");
            string Titulo = Console.ReadLine();
            Console.WriteLine("Ingrese la descripcion del evento");
            string DescripcionEvento = Console.ReadLine();
            Console.WriteLine("Ingrese fecha del evento en el formato DD-MM-AAAA");
            DateTime Fecha = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("Ingrese hora de inicio del evento");
            int HoraInicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese hora de finalizacion del evento");
            int HoraFin = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese 1 si desea notificaciones y cualquier otro numero si no desea notificaciones");
            int NotificacionActiva = int.Parse(Console.ReadLine());
            bool NotificacionBool = NotificacionActiva == 1;

            Evento Evento = new Evento(Titulo, DescripcionEvento, Fecha, HoraInicio, HoraFin, NotificacionBool);
            calendario.ListaEventos.Add(Evento);
            context.Calendarios.Update(calendario);
            context.SaveChanges();
            Console.WriteLine($"El evento se guardo en el calendario con el Id {Evento.Id}");
        }
        else
        {
            Console.WriteLine($"No se encontro el calendario con este Id {IdCalendario}");
        }


    }

    if (Opcion == 4)
    {
        Console.WriteLine("Ingrese el Id del evento a eliminar");
        int Id = int.Parse(Console.ReadLine());
        Evento evento = context.Eventos.FirstOrDefault(x => x.Id == Id);
        if (evento != null)
        {
            context.Eventos.Remove(evento);
            context.SaveChanges();
            Console.WriteLine("Se elimino el evento con el Id " + evento);
        }
        else
        {
            Console.WriteLine($"No se encontro el evento con este Id{Id}");
        }

    }

    if (Opcion == 5)
    {
        Console.WriteLine("Actualizar evento");
        Console.WriteLine("Ingrese el Id del evento a buscar");
        int Id = int.Parse(Console.ReadLine());
        Evento evento = context.Eventos.FirstOrDefault(x => x.Id == Id);
        if (evento != null)
        {

            Console.WriteLine("Ingrese los datos del evento");
            Console.WriteLine("Ingrese el titulo del evento");
            evento.Titulo = Console.ReadLine();
            Console.WriteLine("Ingrese la descripcion del evento");
            evento.DescripcionEvento = Console.ReadLine();
            Console.WriteLine("Ingrese fecha del evento en el formato DD-MM-AAAA");
            evento.Fecha = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("Ingrese hora de inicio del evento");
            evento.HoraInicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese hora de finalizacion del evento");
            evento.HoraFin = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese 1 si desea notificaciones y cualquier otro numero si no desea notificaciones");
            int NotificacionActiva = int.Parse(Console.ReadLine());
            bool NotificacionBool = NotificacionActiva == 1;
            context.Eventos.Update(evento);
            context.SaveChanges();
            Console.WriteLine($"El evento con el Id {Id} se actualizo con exito");

        }
        else
        {
            Console.WriteLine("No se encontro el Id" + Id + "del evento.");
        }


    }
}
while (Opcion != 0);