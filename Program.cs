using csharp_avanzado;
Console.WriteLine("Bienvenidos a c# avanzado");
int opcion = 0;
do
{
    Console.WriteLine("Que decea hacer");
    Console.WriteLine("Opcion 0 salir");
    Console.WriteLine("Opcion 1 Colecciones");

    try
    {
        opcion = int.Parse(Console.ReadLine());
        if (opcion == 1)
        {
            Colecciones objColecciones = new Colecciones();
            opcion = objColecciones.ImprimirMenu();
            if(opcion==1)
            {
                List<int> list= objColecciones.CrearLista();
                int found= objColecciones.BuscarEnLista(5,list);
                if(found>-1)
                {
                    Console.WriteLine($"Se encontro el numero 5 e la pocision {found} de la lista");
                }
                else
                {
                    Console.WriteLine("No se encontro");
                }
            }
        }
    }
    catch
    {
        Console.WriteLine("Algo salio mal, intente de nuevo");

    }

}
while (opcion != 0);

