using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescuentoSalarioRD
{
    //public interface ICalculadorDescuento
    //{
    //    CalculadorDescuentoResponseDto CalcularDescuentos(CalculadorDescuentoRequestDto request);
    //}

    //public class CalculadorDescuento : ICalculadorDescuento
    //{
    //    // dto data transfer object

    //    public CalculadorDescuentoResponseDto CalcularDescuentos(CalculadorDescuentoRequestDto request)
    //    {
    //        var objD = new Descuentos(request.Salario);

    //        var result = new CalculadorDescuentoResponseDto();

    //        //Imprime salario mensual
    //        //result.Sa objD.Salario.ToString("N2");
    //        result.Retenciones = objD.Retenciones();
    //        result.CalculaNetoMensual = objD.CalculaNetoMensual();

    //        //Impimir datos Primera Quincena
    //        result.PrimeraQuincena = objD.PrimeraQuincena();


    //        //Impimir datos Segunsa Quincena
    //        result.SegundaQuincena = objD.SegundaQuincena();
    //        result.Seguro = objD.CalculaSeguroSalud();
    //        result.ISR = objD.CalculaISR();
    //        result.Pensiones = objD.CalculaFondoPensiones();
    //        result.SegundaQuincenaRetenciones = objD.SegundaQuincenaRetenciones();

    //        return null;
    //    }
    //}

    public class CalculadorDescuento2
    {
        // dto data transfer object

        public CalculadorDescuentoResponseDto CalcularDescuentos(CalculadorDescuentoRequestDto request)
        {
            var objD = new Descuentos(request.Salario);
            
            var result = new CalculadorDescuentoResponseDto();

            //Imprime salario mensual
            //result.Sa objD.Salario.ToString("N2");
            result.Retenciones = objD.Retenciones();
            result.CalculaNetoMensual = objD.CalculaNetoMensual();

            //Impimir datos Primera Quincena
            result.PrimeraQuincena = objD.PrimeraQuincena();
           

            //Impimir datos Segunsa Quincena
            result.SegundaQuincena = objD.SegundaQuincena();
            result.Seguro = objD.CalculaSeguroSalud();
            result.ISR = objD.CalculaISR();
            result.Pensiones = objD.CalculaFondoPensiones();
            result.SegundaQuincenaRetenciones = objD.SegundaQuincenaRetenciones();

            return null;
        }
    }

    public class CalculadorDescuentoRequestDto
    {
        public string EmpleadoID { get; set; }
        public decimal Salario { get; set; }
    }

    public class CalculadorDescuentoResponseDto
    { 
        public decimal Retenciones { get; set; }

        public decimal CalculaNetoMensual { get; set; }

        public decimal PrimeraQuincena { get; set; }
     
        public decimal SegundaQuincena { get; set; }

        public decimal Seguro { get; set; }
        public decimal ISR { get; set; }
        public decimal Pensiones { get; set; }
        public decimal SegundaQuincenaRetenciones { get; set; }

    }

}
