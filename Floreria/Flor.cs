using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Floreria
{
    public class Flor
    {
        public int Id {get;set;}
        public string NombreFlor {get;set;}
        public string Descripcion {get;set;}
        public int Precio {get;set;} 

        public Flor (int Id, string NombreFlor, string Descripcion, int Precio)
    {
        this.Id = Id;
        this.NombreFlor = NombreFlor;
        this.Descripcion = Descripcion;
        this.Precio = Precio;
    }

        public override string ToString()
        {
            return $"{Id.ToString().PadRight(10)}|{NombreFlor.ToString().PadRight(20)}|{Descripcion.ToString().PadRight(50)}|{Precio.ToString().PadRight(10)}";
        }
    }

    
}