namespace csharp_avanzado
{
    public class Atletas
    {
        public int ID {get;set;}
        public string Nombre{get;set;}
        public string Direccion{get;set;}
        public List<Pruebas> ListaRendimiento{get;set;}
        
        public Atletas (string Nombre,string Direccion, List<Pruebas> ListaRendimiento,int ID)
        {
            this.Nombre=Nombre;
            this.Direccion=Direccion;
            this.ListaRendimiento=ListaRendimiento;
            this.ID=ID;
        }
        //crear metodo agrfgar prueba 
        // recibe informacion de la prueba
        //crear la prueba y agrgarlo a la lista de pruebas
    }
}