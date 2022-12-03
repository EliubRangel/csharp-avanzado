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
    
    }


}