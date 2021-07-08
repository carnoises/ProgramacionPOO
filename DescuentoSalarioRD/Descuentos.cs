using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescuentoSalarioRD
{
    class Descuentos
    {
       readonly private decimal _salario;

        public Descuentos(decimal salario)
        {
            _salario = salario;
        }

        public decimal Salario
        {
            get { return _salario; }
        }

        public decimal CalculaSeguroSalud()
        {
            return _salario * 3.04M / 100;
        }

        public decimal CalculaFondoPensiones()
        {
            return _salario * 2.87M / 100;
        }

        public decimal CalculaISR()
        {
            decimal subTotal = Salario - CalculaSeguroSalud() - CalculaFondoPensiones();
            decimal totalAnual = subTotal * 12;            
            decimal excedente = 0;
            decimal isr = 0;

            if (totalAnual < 416220)
            {
                return isr;
            }
            else if (totalAnual > 416220.01M && totalAnual <= 624329.00M)
            {
                //montoMesual = ;
                excedente = totalAnual - 416220;
                isr = excedente * 15 / 100;
                return isr /12;
            }
            else if(totalAnual > 624329.01M && totalAnual <= 867123.00M)
            {
                excedente = totalAnual - 624329;
                isr = (excedente * 20 / 100) + 31216;
                return isr / 12;
            }
            else
            {
                excedente = totalAnual - 867123;
                isr = (excedente * 25 / 100) + 79776.20M;
                return isr / 12;
            }
            
        }

        public decimal Retenciones()
        {
            return CalculaSeguroSalud() + CalculaFondoPensiones() + CalculaISR();
        }

        public decimal CalculaNetoMensual()
        {
            return Salario - CalculaSeguroSalud() - CalculaFondoPensiones() - CalculaISR();
        }

        public decimal PrimeraQuincena()
        {
            return Salario / 2;
        }

        public decimal SegundaQuincena()
        {
            return Salario / 2 - Retenciones();
        }
    }
}
