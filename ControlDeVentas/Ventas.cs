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
        private int _cantidad;

        public string Producto
        {
            get { return _producto; }
            set { _producto = value; }
        }

        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
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

        public double CalcularMontoBruto()
        {
            return AsignarPrecio() * Cantidad;
        }

        public double CalcularDescuento()
        {
            double monto = CalcularMontoBruto();
            if (monto <= 300) return 5 / 100 * monto;
            else if (monto > 300 && monto <= 500) return 10 / 100 * monto;
            else if (monto > 500) return 12.5 / 100 * monto;
            else return 0;
        }

        public double CalcularNeto()
        {
            return CalcularMontoBruto() - CalcularDescuento();
        }
    }
}
