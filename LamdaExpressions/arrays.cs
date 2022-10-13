using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LamdaExpressions
{
    public class arrays
    {
        public int buscarNumero(int[] numeros, Func<int, bool> condicion){
            foreach (var n in numeros)
            {
                if(condicion(n))
                    return n;
            }
            return -1;
        }
    }
}