using csharp_avanzado;
Console.WriteLine("Bienvenidos a c# avanzado");
int opcion = 0;
do
{
    Console.WriteLine("Que decea hacer");
    Console.WriteLine("Opcion 0 salir");
    Console.WriteLine("Opcion 1 Colecciones");
    Console.WriteLine("Opcion 2 Fundamentos POO");
    Console.WriteLine("Opcion 3 Entrar al punto de venta");
    Console.WriteLine("Opcion 4 Entrar a finanzas");

    try
    {
        opcion = int.Parse(Console.ReadLine());
        if (opcion == 1)
        {
            Colecciones objColecciones = new Colecciones();
            opcion = objColecciones.ImprimirMenu();
            if (opcion == 1)
            {
                List<int> list = objColecciones.CrearLista();
                int found = objColecciones.BuscarEnLista(5, list);
                if (found > -1)
                {
                    Console.WriteLine($"Se encontro el numero 5 e la pocision {found} de la lista");
                }
                else
                {
                    Console.WriteLine("No se encontro");
                }
            }

        }
        else if (opcion == 2)
        {
            FundamentosPOO objPOO = new FundamentosPOO();
            opcion = objPOO.ImprimirMenu();
            if (opcion == 1)
            {
                objPOO.ImprimirObjetos();
            }
            else if(opcion == 3){
                string nombreMascota = Console.ReadLine();
                Mascota mascota = new Mascota(nombreMascota);
                Perro perro = new Perro(nombreMascota, 250);
                mascota.Vacunar();
                perro.Vacunar();
                

            }
            else if (opcion == 4)
            {
                Tienda oxxo = new Tienda();
                oxxo.VentasJunio();
            }
        }
    }
    catch(Exception e)
    {
        Console.WriteLine("Algo salio mal, intente de nuevo");

    }

}
while (opcion != 0);

