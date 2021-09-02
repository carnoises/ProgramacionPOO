using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfi_smo___Control_de_evaluaciones
{
    class PromedioProgramacion:Promedio
    {
        public override double calculaPromedio()
        {
            return Evaluacion1 * 0.15 + Evaluacion2 * 0.3 + Evaluacion3 * 0.5 + Actitudinal * 0.05;
        }
    }
}
