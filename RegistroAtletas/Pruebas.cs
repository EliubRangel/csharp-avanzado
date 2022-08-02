namespace csharp_avanzado
{
    public class Pruebas
    {
        public decimal puntaje{get;set;}
        public string Descripcion{get;set;}
        public Pruebas(decimal puntaje,string Descripcion)
        {
            this.Descripcion=Descripcion;
            this.puntaje=puntaje;
        }
    }
}