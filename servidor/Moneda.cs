using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comun;

namespace servidor
{
    internal class Moneda : MarshalByRefObject, IMoneda
    {
        public static int numInstancias;

        public Moneda() {
            numInstancias++;
        }

        
        public double Convertir(TipoMoneda tipo, double cantidad)
        {
            if (tipo == TipoMoneda.EuroDolar)
            {
                return 1.2 * cantidad;
            }

            else {
                return 0.89 * cantidad;
            }
        }
    }
}
