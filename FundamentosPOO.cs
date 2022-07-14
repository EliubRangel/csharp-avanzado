namespace csharp_avanzado
{
    public class FundamentosPOO
    {

        private string MsjSaludo = "Hello world";
        private int Descuento = 10;

        public int ImprimirMenu()
        {
            Console.WriteLine(this.MsjSaludo);
            Console.WriteLine("Ocion 1 Imprimir objeto telefono"); 
            Console.WriteLine("Ocion 2 Imprimir objeto Aautomovil"); 
            Console.WriteLine("Opcion 3 Registrar mascota y vacunarla");
            Console.WriteLine("Opcion 4 Venta de productos");
            Console.WriteLine("Opcion 5 Nominas de empleados");
            int opcion = int.Parse(Console.ReadLine());
            return opcion;
        }

        public void ImprimirObjetos()
        {
            
            Telefono oneplus = new Telefono("Oneplus","7 Pro");
            Console.WriteLine(oneplus);
            Telefono iphone = new Telefono("Apple", "Iphone X");
            Console.WriteLine(iphone);
        }

    }
    public class Telefono
    {
        public Telefono()
        {
        }

        public Telefono(string marca, string modelo)
            : this()
        {
            this.Marca = marca;
            this.Modelo = modelo;
        }

        public Telefono(string marca, string modelo, int ram, string pantalla)
            :this(marca, modelo)
        {
            this.Ram = ram;
            this.Pantalla = pantalla;
        }

        public string Marca { get; set; }
        public string Modelo { get; set; }        
        public int Ram { get; set; }
        public string Pantalla { get; set; }

        public override string ToString()
        {
            return $"Marca :{this.Marca} | Modelo: {this.Modelo} | Memoria Ram: {this.Ram}";
        }
    }
}