namespace csharp_avanzado
{
    public class Fruta
    { 
        public int Precio { get; set; }
        protected DateTime FechaCosecha;
    }

    public class Manzana : Fruta
    {
        public void HacerPure()
        {
            this.Precio = this.Precio * 2;
            this.FechaCosecha = DateTime.Today;
        }
    }


    public class Mercado 
    {
        public void Compra()
        {
            Fruta f = new Fruta();
            f.Precio = 25;
        }
    }
    

}