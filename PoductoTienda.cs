namespace csharp_avanzado
{
    public class Producto
    {
        public Producto(string descripcion, int precio, string codigoBarras)
        {
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.CodigoBarra = codigoBarras;
        }
        protected string Descripcion { get; set; }
        protected int Precio { get; set; }
        private string CodigoBarra { get; set; }

        public virtual void Vender()
        {
            Console.WriteLine($"Se vendio {this.Descripcion} con un precio de {this.Precio}");
        }
    }
    public class Alimentos : Producto
    {
        public DateTime Caducidad;

        public Alimentos(string descripcion, int precio, string codigoBarras, DateTime caducidad)
            : base(descripcion, precio, codigoBarras)
        {
            this.Caducidad = caducidad;
        }
        public void RevisarCaducidad()
        {
            if (this.Caducidad <= DateTime.Today)
            {
                this.Precio = this.Precio / 2;
            }
        }
    }
    public class Medicamentos : Producto
    {
        public Medicamentos(string descripcion, int precio, string codigoBarras, bool receta)
            : base(descripcion, precio, codigoBarras)
        {
            this.Receta = receta;
        }

        public bool Receta { get; set; }

        public override void Vender()
        {
            if (!Receta)
                Console.WriteLine($"No se puede vender {this.Descripcion} porque es un Medicamento controlado y no hay receta");
            else
                base.Vender();
        }
    }


    public class Tienda
    {
        public void VentasJunio()
        {
            Producto p = new Producto("Desodorante", 55, "1234");
            Alimentos a = new Alimentos("Carne de res", 100, "1235", DateTime.Today.AddDays(-1));
            Medicamentos m = new Medicamentos("Penicilina", 150, "1236", false);
            p.Vender();
            a.RevisarCaducidad();
            a.Vender();
            m.Vender();
        }
    }
    public class Automovil
    {
        public int Anio { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Kilometraje { get; set; }
        public Automovil(int Anio, string marca, string modelo, int kilometraje)
        {

        }

        public virtual int Servicio()
        {
            return this.Kilometraje / 10 + 1500;
        }

    }
    public class Compacto : Automovil
    {
        public Compacto(int Anio, string marca, string modelo, int kilometraje)
        : base(Anio, marca, modelo, kilometraje)
        {

        }
    }
    public class Camioneta : Automovil
    {
        public Camioneta(int Anio, string marca, string modelo, int kilometraje, bool TodoTerreno)
        : base(Anio, marca, modelo, kilometraje)
        {
            this.TodoTerreno = TodoTerreno;
        }
        public bool TodoTerreno { get; set; }
        public override int Servicio()
        {
            int CostoServicio;
            if(TodoTerreno==true)
            {
                CostoServicio= base.Servicio()+1000;
            }
            else
            {
                CostoServicio=base.Servicio();
            }
            return CostoServicio;
        }
      
    }
    public class Limosina : Automovil
    {
        public Limosina(int Anio, string marca, string modelo, int kilometraje, int AsientosExtras)
        : base(Anio, marca, modelo, kilometraje)
        {
            this.AsientosExtras = AsientosExtras;
        }
        int AsientosExtras { get; set; }
        public override int Servicio()

        {
            int CostoServicio=0;
            if(this.Kilometraje<50000)
            {
               CostoServicio= 5000;
            }
            else
            {
               CostoServicio= 8000;
            }
            return CostoServicio;

        }
    }

    public class Agencia
    {
        public void VentasMes()
        {
            Compacto c = new Compacto(2018, "kia", "rio", 15000);
            Camioneta p= new Camioneta(2022,"chevrolett","cheyenne",50000,true );
            Limosina l= new Limosina(2015,"hummer","h2",25000,8);


        }

    }
}