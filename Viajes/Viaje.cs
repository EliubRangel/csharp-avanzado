using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Viajes
{
    public class Viaje
    {
        public int Id {get;set;}
        public int Distancia {get;set;}
        public int Tarifa {get;set;}
        public DateTime Fecha {get;set;}
        public string Pasajero {get;set;}
        

        public Viaje (int Id, int Distancia,int Tarifa,DateTime Fecha, string Pasajero)
        {
            this.Id = Id;
            this.Distancia = Distancia;
            this.Tarifa = Tarifa;
            this.Fecha = Fecha;
            this.Pasajero = Pasajero;
            

        }
        public override string ToString()
        {
            return $"{Id.ToString().PadRight(10)}|{Distancia.ToString().PadRight(10)}|{Tarifa.ToString().PadRight(10)}|{Fecha.ToString("dd-MM-yyyy").PadRight(20)}|{Pasajero.PadRight(20)}";
        }
    }
}