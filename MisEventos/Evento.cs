using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MisEventos
{
    public class Evento

    {
        public List<Invitado> ListaInvitados { get; set; }
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }

        public Evento(int ID, string Nombre, string Descripcion, DateTime Fecha)
        {
            this.ID = ID;
            this.Descripcion = Descripcion;
            this.Fecha = Fecha;
            this.Nombre=Nombre;
            
        }
        public void AgregarInvitado(string Nombre, string Direccion, string Telefono)
        {
            
            Invitado Inv =new Invitado(Nombre,Direccion,Telefono);
            this.ListaInvitados= new List<Invitado>();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}