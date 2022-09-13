using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MisEventos
{
    public class Invitado
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }

        public Invitado(string Nombre, string Direccion, string Telefono)
        {
            this.Direccion = Direccion;
            this.Nombre = Nombre;
            this.Telefono = Telefono;
            int.MaxValue
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }

}