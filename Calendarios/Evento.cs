using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendarios
{
    public class Evento
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string DescripcionEvento { get; set; }
        public DateTime Fecha { get; set; }
        public int HoraInicio { get; set; }
        public int HoraFin { get; set; }
        public bool NotificacionActiva { get; set; }
        public Calendario Calendario {get;set;}
      

        public Evento()
        {

        }


        public Evento(string Titulo, string DescripcionEvento, DateTime Fecha, int HoraInicio, int HoraFin, bool NotificacionActiva)
        {
            this.Titulo = Titulo;
            this.DescripcionEvento = DescripcionEvento;
            this.Fecha = Fecha;
            this.HoraInicio = HoraInicio;
            this.HoraFin = HoraFin;
            this.NotificacionActiva = NotificacionActiva;
        }

        public override string ToString()
        {
            return $"{Id.ToString().PadRight(10)}|{Titulo.ToString().PadRight(20)}|{DescripcionEvento.ToString().PadRight(100)}|{Fecha.ToString().PadRight(20)}|{HoraInicio.ToString().PadRight(10)}|{HoraFin.ToString().PadRight(10)}|{NotificacionActiva.ToString().PadRight(10)}";
        }
    }
}