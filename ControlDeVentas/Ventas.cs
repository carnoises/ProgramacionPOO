using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeVentas
{
    class Ventas
    {
        private string _producto;

        public string Producto
        {
            get { return _producto; }
            set { _producto = value; }
        }


        public double AsignarPrecio()
        {
            switch (Producto)
            {
                case "Impresora": return 350.00;
                case "Mouse": return 20;
                case "Monitor": return 550;
                case "Parlante": return 50;
                case "Teclado": return 35;
            }
            return 0;
        }

        public double AsignarDescuento()
        {
            return 0;
        }
    }
}
