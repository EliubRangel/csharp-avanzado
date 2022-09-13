namespace csharp_avanzado
{
    public class RegistroAtletas
    {
        public List<Atletas> ListaAtletas;
        public Pruebas pruebas;
        public RegistroAtletas()
        {
            this.pruebas= new Pruebas();
            this.ListaAtletas= new List<Atletas>();
        }
        public void IniciarRegistro()
        {
           int Opcion=0;
           do
           {
            Console.WriteLine("==============================");
                Console.WriteLine("Que deseas hacer?");
                Console.WriteLine("Opcion 0 Salir");
                Console.WriteLine("Opcion 1 Agregar atleta a la lista");
                Console.WriteLine("Opcion 2 Agregar prueba al atleta");
                Console.WriteLine("Opcion 3 Buscar atleta por ID");
                 Console.WriteLine("==============================");
                Opcion=Convert.ToInt32(Console.ReadLine());
                if(Opcion==1)
                {
                    Console.WriteLine("Agregar atleta");
                    string Nombre= Console.ReadLine();
                    string Direccion= Console.ReadLine();
                    int ID = int.Parse(Console.ReadLine());
                    Atletas atletas= new Atletas(Nombre,Direccion,ID);
                    this.ListaAtletas.Add(atletas);
                }
                else if(Opcion==2)
                {
                    Console.WriteLine("Ingrese prueba");
                    string prueba= Console.ReadLine();
                }

           }
           while(Opcion==0);
        }
    }
}