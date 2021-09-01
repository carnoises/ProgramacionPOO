using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas_Productos_Contado_y_Credito
{
    class Credito:Venta
    {
        public static int x;

        public Credito()
        {
            x++;
        }

        public int getX()
        {
            return x;
        }

        public int Letras { get; set; }

        public decimal calculaMontoInteres()
        {
            switch (Letras)
            {
                case 3: return 5 / 100 * CalculaSubTotal();
                case 6: return 10 / 100 * CalculaSubTotal();
                case 9: return 15 / 100 * CalculaSubTotal();
                case 12: return 25 / 100 * CalculaSubTotal();                
            }
            return 0;
        }

        public decimal calculaMontoMensual()
        {
            return (CalculaSubTotal() + calculaMontoInteres()) / Letras;
        }
    }
}
