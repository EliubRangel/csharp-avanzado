using System;
using csharp_avanzado.Finanzas;
using Finanzas;

Presupuesto Presupuesto = new Presupuesto();
List<Gastos> ListaGastos = new List<Gastos>();
var Context = new FinanzasDbcontext();

int Opcion = 0;
do
{

    Console.WriteLine("==============================");
    Console.WriteLine("Que deseas hacer?");
    Console.WriteLine("Opcion 0 Salir");
    Console.WriteLine("Opcion 1 Regitrar ingreso");
    Console.WriteLine("Opcion 2 Registrar gasto");
    Console.WriteLine("Opcion 3 Ver gasto");
    Console.WriteLine("Opcion 4 Ver ingreso");
    Console.WriteLine("==============================");
    Opcion = Convert.ToInt32(Console.ReadLine());

    if (Opcion == 1)
    {
        Console.WriteLine("Importe del ingreso");
        decimal Ingreso = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Descripcion del ingreso");
        string Descripcion = Console.ReadLine();
        Presupuesto.AgregarIngreso(Ingreso, Descripcion);

    }
    else if (Opcion == 2)
    {
        Console.WriteLine("Importe del gasto");
        decimal gasto = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Descreipcion del gasto");
        string Descripcion = Console.ReadLine();
        Gastos gastos = new Gastos(DateTime.Now, gasto, Descripcion);
        Context.Gastos.Add(gastos);
        Presupuesto.AplicarGasto(gasto);
        Context.SaveChanges();
    }
    else if (Opcion == 3)
    {
       Console.WriteLine("Ver ingreso");

        for (int i = 0; i < Context.Gastos.Count(); i++)
        {
            Console.WriteLine(ListaGastos[i]);
        }

    }
    else if (Opcion == 4)
    {
        Console.WriteLine(Presupuesto);

        ///////////////////////////////////////////////
        // hacer una aplicacion para registrar atletas y su rendimiento fisico. del atleta se regitrara el nombre
        // direccion y su lista de rendimiento en  diversas pruebas.
        // cada prueba que haga llevara una descripcion y un puntaje.
        // la aplicacion debe permitir registrar atletas, registrar pruebas para el atleta, consultar el rendimiento de un atleta
        // la consulta consta de mostrar la informacion del atleta y de sus pruebas 
    }

}
while (Opcion != 0);