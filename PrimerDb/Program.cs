using PrimerDb;
var context = new VeterinariaDbContext();
//consultar todos los registros de la tabla clientes 
var clientes = context.Clientes.ToList();
var mascotas = context.Mascotas.ToList();
var mnegro = context.Mascotas.Where(x => x.Color == "negro").ToList();

var mascota = new Mascota
{
    Id = 6,
    Nombre = "firulais",
    CantidadVacunas = 5,
    FechaNacimiento = new DateTime(2022,11,1),
    Color = "negro",
    IdCliente = 2
};
context.Mascotas.Add(mascota);
context.SaveChanges();

Console.WriteLine("Hello word");
/*Console.WriteLine("Ingrese correo");
string Correo = Console.ReadLine();
Console.WriteLine("Ingrese domicio");
string Domicilio = Console.ReadLine();
Console.WriteLine("Ingrese telefono");
string Telefono = Console.ReadLine();
var Cliente = new Cliente
{
    Correo = Correo,
    Domicilio = Domicilio,
    Telefono = Telefono
};
context.Clientes.Add(Cliente);
context.SaveChanges();*/