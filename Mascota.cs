namespace csharp_avanzado
{
    public class Mascota
    {
        public string Nombre { get; set; }
        public bool Vacunado { get; set; }
        public bool Desparasitado { get; set; }

        public Mascota(string nombre)
        {
            Console.WriteLine("Costruyendo a la mascota");
            this.Nombre = nombre;
        }

        public void Vacunar()
        {
            this.Vacunado = true;
            Console.WriteLine($"Se vacuno a {this.Nombre}");
        }
    }

    public class Perro : Mascota
    {
        public int LadridosAlDia { get; set; }
        public Perro(string nombre) : base(nombre)
        {
            Console.WriteLine("Construyendo al Perro");
        }

        public Perro(string nombre, int ladridosalDia): this(nombre)
        {
            this.LadridosAlDia = ladridosalDia;
        }
    }

}