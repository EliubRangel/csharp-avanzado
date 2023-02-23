using System.Globalization;
using Biblioteca;
int Opcion = 0;
var Context = new BibliotecaDbContex();

do
{
    Console.WriteLine("=========================");
    Console.WriteLine("Que deseas hacer?");
    Console.WriteLine("Opcion 1 Registrar libro");
    Console.WriteLine("Opcion 2 consultar libro");
    Console.WriteLine("Opcion 3 Registrar prestamo");
    Console.WriteLine("Opcion 4 Regresar prestamo");
    Console.WriteLine("=========================");
    Opcion = int.Parse(Console.ReadLine());

    if (Opcion == 1)
    {
        Console.WriteLine("Ingrese los datos del alimento");
        Console.WriteLine("Ingrese el Id del libro");
        int Id = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese nombre del libro");
        string Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese el autor del libro");
        string Autor = Console.ReadLine();
        Console.WriteLine("Ingrese fecha de impresion dd-mm-yyyy");
        DateTime Fecha= DateTime.ParseExact(Console.ReadLine(),"dd-mm-yyyy", CultureInfo.InvariantCulture);
        Context.Libros.Add(new Libro
        {
            Id = Id,
            Nombre = Nombre,
            Autor = Autor,
            FechaImpresion = Fecha
        });
        Context.SaveChanges();
    }
    if (Opcion == 2)
    {
        Console.WriteLine("Ingrese el Id del libro a buscar");
        int IdLibro = int.Parse(Console.ReadLine());
        Libro libro = Context.Libros.FirstOrDefault(x => x.Id == IdLibro);
        if (libro != null)
            Console.WriteLine(libro);
        else
            Console.WriteLine($"No se encontro el libro con el id {IdLibro}");
    }
    

}
while (Opcion != 0);