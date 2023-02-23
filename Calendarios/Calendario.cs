using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendarios
{
    public class Calendario
    {
        public int Id { get; set; }
        public string NombreCalendario { get; set; }
        public string Descripcion { get; set; }

        public Calendario(string NombreCalendario, string Descripcion)
        {

            this.NombreCalendario = NombreCalendario;
            this.Descripcion = Descripcion;
        }
        public override string ToString()
        {
            return $"{Id.ToString().PadRight(10)}|{NombreCalendario.ToString().PadRight(20)}|{Descripcion.ToString().PadRight(100)}";
        }

    }


}