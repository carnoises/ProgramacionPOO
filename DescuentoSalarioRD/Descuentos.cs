using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescuentoSalarioRD
{
    public class Descuentos
    {
        readonly private decimal _salario;

        //Escala retención asalariados 2021​
        private const decimal RANGO_INICIAL = 416220;
        private const decimal RANGO_UNO_INICIO = 416220.01M;
        private const decimal RANGO_UNO_FINAL = 624329M;
        private const decimal RANGO_DOS_INICIO = 624329.01M;
        private const decimal RANGO_DOS_FINAL = 867123M;
        private const decimal RANGO_TRES_INICIO = 867123.01M;

        //Rango de tasas retención de Impuesto de las Personas Físicas
        private const decimal TASA_RANGO_UNO = 0.15M;
        private const decimal TASA_RANGO_DOS = 0.20M;
        private const decimal TASA_RANGO_TRES = 0.25M;

        //Rango tasas AFP y SFS
        private const decimal TASA_SFS = 0.0304M;
        private const decimal TASA_AFP = 0.0287M;

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
            return Salario * TASA_SFS;
        }

        public decimal CalculaFondoPensiones()
        {
            return Salario * TASA_AFP;
        }

        public decimal CalculaISR()
        {
            decimal subTotal = Salario - CalculaSeguroSalud() - CalculaFondoPensiones();
            decimal totalAnual = subTotal * 12;            
            decimal excedente = 0;
            decimal isr = 0;

            if (totalAnual < RANGO_INICIAL)
            {
                return isr;
            }
            else if (totalAnual > RANGO_UNO_INICIO && totalAnual <= RANGO_UNO_FINAL)
            {
                //montoMesual = ;
                excedente = totalAnual - RANGO_UNO_INICIO;
                isr = excedente * TASA_RANGO_UNO;
                return isr /12;
            }
            else if(totalAnual > RANGO_DOS_INICIO && totalAnual <= RANGO_DOS_FINAL)
            {
                excedente = totalAnual - RANGO_UNO_FINAL;
                isr = (excedente * TASA_RANGO_DOS) + 31216;
                return isr / 12;
            }
            else
            {
                excedente = totalAnual - RANGO_TRES_INICIO;
                isr = (excedente * TASA_RANGO_TRES) + 79776.20M;
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
            return Salario / 2;
        }

        public decimal SegundaQuincenaRetenciones()
        {
            return Salario / 2 - Retenciones();
        }
    }
}
