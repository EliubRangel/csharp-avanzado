using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Materias
{
    public class Materia
    {
        public int Id {get;set;}
        public string NombreMateria {get;set;}
        public string Profesor {get;set;}
        public int Aula {get;set;}

        public Materia ()
        {

        }

        public override string ToString()
        {
            return($"{Id.ToString().PadRight(10)}|{NombreMateria.ToString().PadRight(10)}|{Profesor.ToString().PadRight(10)}|{Aula.ToString().PadRight(10)}");
        }
    }
}