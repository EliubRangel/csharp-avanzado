namespace csharp_avanzado
{
    public class Empleados
    {
        public string Nombre{get;set;}
        public DateTime FechaNacimiento{get;set;}
        public int SueldoBase{get;set;}
        
        
        public Empleados(string Nombre,DateTime FechaNacimiento, int SueldoBase)
        {

        }

        public virtual int Pagar()
        {
        return SueldoBase;
        } 
    }
    public class Junior:Empleados
    {
        public Junior(string Nombre, DateTime FechaNacimento, int SueldoBase)
        : base(Nombre,FechaNacimento,SueldoBase)
        {


        }
        

    }
    public class Senior:Empleados
    {
        public Senior(string Nombre, DateTime FechaNacimiento, int SueldoBase,int CantidadVentas)
        :base(Nombre,FechaNacimiento,SueldoBase)
        {
        this.CantidadVentas=CantidadVentas;

        }
        public int CantidadVentas { get; set; }
        public override int Pagar()
        {
            return SueldoBase+CantidadVentas*500;
        }


       
    

    }
    public class Directivo:Empleados
    {
        public Directivo(string Nombre,DateTime FechaNacimento,int SueldoBase, bool Metas)
        :base(Nombre,FechaNacimento,SueldoBase)
        {
            this.Metas=Metas;
        }
        public bool Metas{get;set;}
        public override int Pagar()
        {
            if(Metas)
            {
                SueldoBase=SueldoBase+5000;
            }
            return SueldoBase;

        }

    }
    public class Rh
    {
        public void Nominas()
        {
            Junior Jr= new Junior("Eliub",new DateTime(1993,02,19),20000);
            Senior Sr=new Senior("Samuel",new DateTime(1990,08,25),20000,5);
            Directivo D=new Directivo("jesus",new DateTime(1992,01,20),20000,true);
            Console.WriteLine($"El total a pagar a {Jr.Nombre} es {Jr.Pagar()}");
            Console.WriteLine($"El total a pagar a {Sr.Nombre}es{Sr.Pagar()}");
            Console.WriteLine($"El total a pagar a {D.Nombre}es{D.Pagar()}");
        }
    }
    public class Habitacion
    {
        public int NumeroCamas{get;set;}
        public int Precio{get;set;}
        public string Descripcion{get;set;}
        public Habitacion (int NumeroCamas, int Precio, string Descripcion)
        {

        }

        public virtual int Reservar(){
            return Precio;
        }
     
    }
    public class HabitacionSencilla:Habitacion
    {
        public HabitacionSencilla(int NumeroCamas, int Precio,string Descripcion)
        :base(NumeroCamas,Precio,Descripcion)
        {
        }
        public override int Reservar()
        {
            return 800 + base.NumeroCamas * 200;
        }
    }
    public class HabitacionSuite:Habitacion
    {
        
        
            public HabitacionSuite( int NumeroCamas,int precio, string Descripcion,bool VistaMar)
            : base(NumeroCamas,precio,Descripcion)
            {
                this.VistaMar=VistaMar;
            }
            public bool VistaMar{get;set;}

        public override int Reservar()
        {
            int extra = 0;
            if(this.VistaMar)
                extra = 1000;
            return 3000 + extra;
        }
    }
    public class Recepcion
    {
        HabitacionSencilla Hs=new HabitacionSencilla(3,500,"habitacion con 3 camas");
        HabitacionSuite S=new HabitacionSuite(2,3000,"habitacion 5 estrellas",true);

    }
}