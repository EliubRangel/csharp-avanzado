using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Materias
{
    public class Curso
    {
        public int Id { get; set; }
        public string NombreCurso { get; set; }
        public DateOnly FechaInicio { get; set; }
        public DateOnly FechaFinal { get; set; }
        public List<Materia> MateriasImpartidas { get; set; }

        public Curso()
        {
            MateriasImpartidas = new List<Materia>();
        }
        public override string ToString()
        {
            IEnumerable<string> MateriatosStr = MateriasImpartidas.Select(x => x.ToString());
            string StrOrden = string.Join("\n", MateriatosStr);


            return ($"{Id.ToString().PadRight(10)}|{NombreCurso.ToString().PadRight(15)}|{FechaInicio.ToLongDateString().PadRight(10)}|{FechaFinal.ToLongDateString().PadRight(10)}|");
        }

    }
}