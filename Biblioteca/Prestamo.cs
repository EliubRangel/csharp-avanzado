using System;
using System.Collections.Generic;
using System.Linq
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Prestamo
    {
        public int Id {get;set;}
        public DateTime FechaPrestamo {get;set;}
        public DateTime FechaEntrga {get;set;}
        public string NombrePersona {get;set;}
        public bool Retraso {get;set;}
        public List<Libro>libro{get;set;}
    }
}