namespace csharp_avanzado
{
    public class Colecciones
    {
        public int ImprimirMenu()
        {
            Console.WriteLine("Ocion 1 Buscar elemento en lista");
            int opcion=int.Parse(Console.ReadLine());
            return opcion;
        }
        public List<int> CrearLista()
        {
            List<int> list= new List<int>();  
            Random rdm= new Random();     
            for(int i=1;i<=5;i++)
            {
                list.Add(rdm.Next(1,10));
            } 
            return list;
        }
        public int BuscarEnLista(int x,List<int> list)
        {
            for(int i=0;i<list.Count;i++)
            {
                if(x==list[i])
                {
                    return i;
                }
                
            }
            return -1;
        }
    }
}