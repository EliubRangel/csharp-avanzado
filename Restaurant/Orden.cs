using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Orden
    {
        public int Id {get;set;}
        public int NumeroMesa {get;set;}
        public string Nombrecomensal {get;set;}
        public List<Alimento> Alimentos {get;set;}

        public Orden ()
        {
            Alimentos = new List<Alimento>();
        }

        public override string ToString()
        {
            IEnumerable<string> alimentosStr = Alimentos.Select(x => x.ToString());
            string StrOrden = string.Join("\n", alimentosStr);

            return ($"{Id.ToString().PadRight(10)}|{NumeroMesa.ToString().PadRight(10)}|{Nombrecomensal.ToString().PadRight(10)}\n{StrOrden}");
        }
    }
}