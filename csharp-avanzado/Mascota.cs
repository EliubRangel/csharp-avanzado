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
    public class perico : Mascota
    {
        public perico(string nombre): base(nombre)
        {
            if(this.LargoGarras == null)
                this.LargoGarras = "muy largas";
        }
        public int NumeroPlumas{get;set;}
        public string LargoGarras{get;set;}

    }
    public class persona
    {
        public string Nombre{get;set;}
        public string Direccion{get;set;}
    }
    public class Alumno:persona
    {
        public int Matricula{get;set;}
    }

}