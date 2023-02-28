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
        public List<Evento> ListaEventos {get;set;}
        
        public Calendario()
        {
            ListaEventos = new List<Evento>();
        }

        public Calendario(string NombreCalendario, string Descripcion)
        {

            this.NombreCalendario = NombreCalendario;
            this.Descripcion = Descripcion;
        }
        public override string ToString()
        {
            IEnumerable<string> evntosr = ListaEventos.Select(x => x.ToString());
            string StrOrden = string.Join("\n", evntosr);


            return $"{Id.ToString().PadRight(10)}|{NombreCalendario.ToString().PadRight(20)}|{Descripcion.ToString().PadRight(100)}";
        }

    }


}