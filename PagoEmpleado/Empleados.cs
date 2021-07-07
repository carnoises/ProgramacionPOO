using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoEmpleado
{
    public class Empleados
    {
        //private Empleados()
        //{

        //}

        public static double CostoHoras(string categoria)
        {
            switch (categoria)
            {
                case "CAS": return 15.00;
                case "CAP": return 25.00;
            }
            return 0;
        }

        public static double SueldoBruto(string categoria, int hrs)
        {
            return CostoHoras(categoria) * hrs; 
        }

        public static double Descuento(string categoria, int hrs)
        {
            return SueldoBruto(categoria, hrs) * 12 / 100;
        }

        public static double Neto(string categoria, int hrs)
        {
            return SueldoBruto(categoria, hrs) - Descuento(categoria, hrs);
        }

    }
}
