using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfi_smo___Control_de_evaluaciones
{
    class Promedio
    {
        public string Nombre { get; set; }
        public double Evaluacion1 { get; set; }
        public double Evaluacion2 { get; set; }
        public double Evaluacion3 { get; set; }
        public double Actitudinal { get; set; }

        public virtual double calculaPromedio()
        {
            return (Evaluacion1 + Evaluacion2 + Evaluacion3 + Actitudinal) / 4;
        }

        public string condicion()
        {
            double promedio = calculaPromedio();

            if (promedio > 12.5)
            {
                return "Aprobado";
            }
            else
            {
                return "Reprobado";
            }
        }
    }
}
