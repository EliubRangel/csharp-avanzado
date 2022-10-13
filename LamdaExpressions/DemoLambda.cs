using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LamdaExpressions
{
    public class DemoLambda
    {
        
        public void Saludar(Action ejecutarSaludo)
        {
            Console.WriteLine("Saludos");
            ejecutarSaludo();
        }

        public void SaludosPagados(Action<int,string> ejSaludo)
        {
            int pago = 100;
            ejSaludo(pago, "Luis Miguel");
        }

        public void vender(Func<int> calcularImpuesto)
        {
            int totalVenta = 100;
            int impuesto = calcularImpuesto();
            Console.WriteLine($"El total de la venta es {totalVenta}");
            Console.WriteLine($"El impuesto de la venta es {impuesto}");
        }

        public void vender2(Func<int,double> calcularImpuesto)
        {
            int totalVenta = 100;
            double impuesto = calcularImpuesto(totalVenta);
            Console.WriteLine($"El total de la venta es {totalVenta}");
            Console.WriteLine($"El impuesto de la venta es {impuesto}");
        }
    }
}