using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas_Productos_Contado_y_Credito
{
   public class Contado : Venta
    {
        public static int n;

        public Contado()
        {
            n++;
        }

        public int getN()
        {
            return n;
        }

        public decimal calcularDescuento(decimal subtotal)
        {
            if (subtotal < 1000)
            {
                return (2M / 100) * subtotal;
            }
            else if(subtotal >= 1000 && subtotal <= 3000)
            {
                return (5M / 100) * subtotal;
            }
            else
            {
                return (12M / 100) * subtotal;
            }            
        }

        public decimal calculaNeto(decimal subtotal, decimal descuento)
        {
            return subtotal - descuento;
        }
    }
}
