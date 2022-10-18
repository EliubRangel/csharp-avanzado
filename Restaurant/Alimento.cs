using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Alimento
    {
        public int Id {get;set;}
        public string Nombre {get;set;}
        public string Descripcion {get;set;}
        public int Precio {get;set;}

        

        public Alimento ()
        {
            
        }

        public override string ToString()
        {
            return($"{Id.ToString().PadRight(10)}|{Nombre.ToString().PadRight(15)}|{Descripcion.ToString().PadRight(20)}|{Precio.ToString().PadRight(10)}");
        }
    }
}