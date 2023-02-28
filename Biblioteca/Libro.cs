using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Libro
    {
        public int Id {get;set;}
        public string Nombre {get;set;}
        public string Autor {get;set;}
        public DateTime FechaImpresion {get;set;}
    
        public List<Prestamo> Prestamo {get;set;}


        public Libro()
        {

        }
        public override string ToString()
        {
            return($"{Id.ToString().PadRight(10)}|{Nombre.ToString().PadRight(20)}|{Autor.ToString().PadRight(20)}|{FechaImpresion.ToString("dd-mm-yyyy").PadRight(20)}");
        }
    }


}