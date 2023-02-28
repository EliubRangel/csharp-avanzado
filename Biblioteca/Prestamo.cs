using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Prestamo
    {
        public int Id {get;set;}
        public DateTime FechaPrestamo {get;set;}
        public DateTime FechaEntrega {get;set;}
        public string NombrePersona {get;set;}
        public bool Retraso {get;set;}
        public List<Libro>libro{get;set;}

        public Prestamo()
        {

        }
        public override string ToString()
        {
            return ($"{Id.ToString().PadRight(10)}|{FechaPrestamo.ToString("dd-mm-yyyy").PadRight(15)}|{FechaEntrega.ToString("dd-mm-yyyy")}|{Retraso.ToString().PadRight(10)};
        }
    }
}