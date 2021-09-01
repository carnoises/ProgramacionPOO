using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas_Productos_Contado_y_Credito
{
    public class Venta
    {
        public string NombreCliente { get; set; }
        public string RUC { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }

        public decimal AsignaPrecio()
        {            
            switch(NombreProducto)
            {
                case "Lavadora": return 1500;
                case "Refigeradora": return 3500;
                case "Licuadora": return 500;
                case "Extractora": return 150;
                case "Radiograbadora": return 750;
                case "DVD": return 100;
                case "Blu Ray": return 250;  
            }
            return 0;
        }

        public decimal CalculaSubTotal()
        {
            return AsignaPrecio() * Cantidad;
        }
    }
}
