using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromedioDeNotas
{
    class Promedio
    {
        public string alunmo;        
        public int nota1;
        public int nota2;
        public int nota3;
        public int nota4;

        public int MasBaja()
        {
            if (nota1 < nota2 && nota1 < nota3 && nota1 < nota4) return nota1;
            else if (nota2 < nota1 && nota2 < nota3 && nota2 < nota4) return nota2;
            else if (nota3 < nota1 && nota3 < nota2 && nota3 < nota4) return nota3;
            else return nota4;
        }

        public double PromedioNotas()
        {
            return (nota1 + nota2 + nota3 + nota4 - MasBaja()) / 3.0;
        }

        public string Condicion()
        {
            double promedio = PromedioNotas();

            if (promedio <= 10) return "Desaprobado";
            else if (promedio > 10 && promedio <= 12.5) return "Recuperacion";
            else return "Aprobado";
        }

    }
}
