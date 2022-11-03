using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerDb
{
    public class Mascota
    {
        public int Id {get;set;}
        public string Nombre {get;set;}
        public int? CantidadVacunas {get;set;}
        public string? TipoAnimal {get;set;}
        public DateTime? FechaNacimiento {get;set;}
        public string? Color {get;set;}
        public int IdCliente {get;set;}
    }
}