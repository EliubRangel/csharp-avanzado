using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Floreria
{
    public class Pedidos
    {
        public int Id {get;set;}
        public string Destinatario {get;set;}
        public string Direccion {get; set;}
        public string TelefonoContacto {get;set;}
        public List<Flor> Flores { get; set; }

        public Pedidos (int Id, string Destinatario, string Direccion, string TelefonoContacto)
        {
            this.Id = Id;
            this.Destinatario = Destinatario;
            this.Direccion = Direccion;
            this.TelefonoContacto = TelefonoContacto;
            this.Flores = new List<Flor>();
        }
        public override string ToString()
        {
            string strFlores = string.Join("\n", Flores.Select(x => x.ToString()));

            return $"{Id.ToString().PadRight(10)}|{Destinatario.ToString().PadRight(10)}|{Direccion.ToString().PadRight(20)}|{TelefonoContacto.ToString().PadRight(12)} \n {strFlores.ToString()}";
        }

    }
}