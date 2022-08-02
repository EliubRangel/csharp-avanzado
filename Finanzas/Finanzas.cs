namespace csharp_avanzado.Finanzas
{
    public class Finanzas
    {
        private Presupuesto Presupuesto;
        private List<Gastos> ListaGastos;
        public Finanzas()
        {
            this.Presupuesto= new Presupuesto();
            this.ListaGastos= new List<Gastos>();
        }

        public void AdministrarFinanzas()
        {
            int Opcion=0;
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
                Opcion=Convert.ToInt32(Console.ReadLine());

                if(Opcion==1)
                {
                    Console.WriteLine("Importe del ingreso");
                    decimal Ingreso= decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Descripcion del ingreso");
                    string Descripcion= Console.ReadLine();
                    Presupuesto.AgregarIngreso(Ingreso,Descripcion);
                    
                }
                else if(Opcion==2)
                {
                    Console.WriteLine("Importe del gasto");
                    decimal gasto= decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Descreipcion del gasto");
                    string Descripcion= Console.ReadLine();
                    Gastos gastos=new Gastos(DateTime.Now,gasto,Descripcion);
                    this.ListaGastos.Add(gastos);
                    Presupuesto.AplicarGasto(gasto);
                }
                else if(Opcion == 3){
                   for(int i=0; i<this.ListaGastos.Count();i++)
                   {
                    Console.WriteLine(this.ListaGastos[i]);
                   }
                   
                }
                else if(Opcion == 4)
                {
                    Console.WriteLine(this.Presupuesto);
                   
                    ///////////////////////////////////////////////
                    // hacer una aplicacion para registrar atletas y su rendimiento fisico. del atleta se regitrara el nombre
                    // direccion y su lista de rendimiento en  diversas pruebas.
                    // cada prueba que haga llevara una descripcion y un puntaje.
                    // la aplicacion debe permitir registrar atletas, registrar pruebas para el atleta, consultar el rendimiento de un atleta
                    // la consulta consta de mostrar la informacion del atleta y de sus pruebas 
                }

            }
            while(Opcion==0);
        }
    }
}