using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DescuentoSalarioRD;

namespace Leer_Archivo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  El archivo debe tener la siguiente estructura
             *  
                codigo, nombre, Puesto, Departamento, sueldo
                001,Jose Perez,Presidente,Presidencia,250000.00
                003,Ana Santana,Secretaria,Administracion,35000.00
                004,Carlos Manuel Tejada Rodriguez,Tecnologia,Soporte,50000.00
                005,Jose Perez,Mantenimiento,Conserje,20000.00

             */
            string[] lineasArchivo = System.IO.File.ReadAllLines(@"E:\Desktop\nomina.txt");
            char delimador = ',';           
            decimal totalSueldo = 0;
            int nEmpleado = 0;

            foreach (var linea in lineasArchivo)
            {               
                var camposLinea = linea.Split(delimador);
                totalSueldo += decimal.Parse(camposLinea[4]);
                nEmpleado++;                
            }

            Descuentos objD;
            decimal totalPension = 0;
            decimal totalISR = 0;
            decimal totalSeguro = 0;
            decimal totalNeto = 0;

            //Escritura archivo devuelto
            using (System.IO.StreamWriter archivo = new System.IO.StreamWriter(@"E:\Prueba\NOMINA_RPT1.TXT"))
            {
                archivo.Write("EMPRESA ABC");
                archivo.WriteLine(DateTime.Now.ToShortDateString().PadLeft(120) + " " + DateTime.Now.ToShortTimeString());
                archivo.WriteLine("SISTEMA DE NOMINA");
                archivo.WriteLine("NOMINA DEL PERIODO "+" MES " + DateTime.Now.Month + " " + " AÑO " + DateTime.Now.Year);
                archivo.WriteLine();
                archivo.WriteLine("EMPLEADO".PadRight(9) +
                                    "NOMBRE".PadRight(33) +
                                    "PUESTO".PadRight(14) +
                                    "DEPARTAMENTO".PadRight(16) +
                                    "SUELDO".PadRight(14) +
                                    "FPENSION".PadRight(14) +
                                    "ISR".PadRight(14) +
                                    "SEGURO".PadRight(14) +
                                    "NETO");
                archivo.WriteLine("---------------------------------------------------" +
                    "-----------------------------------------------------------------" +
                    "------------------------");


                foreach (var item in lineasArchivo)
                {

                    var campoLineas = item.Split(',');
                    objD = new Descuentos(decimal.Parse(campoLineas[4]));
                    archivo.Write(campoLineas[0].PadRight(9));                                  //Codigo
                    archivo.Write(campoLineas[1].PadRight(33));                                 //Nombre
                    archivo.Write(campoLineas[2].PadRight(14));                                 //Puesto
                    archivo.Write(campoLineas[3].PadRight(16));                                 //Departamento
                    archivo.Write(campoLineas[4].PadRight(14));                                 //Sueldo
                    archivo.Write(objD.CalculaFondoPensiones().ToString("N2").PadRight(14));    //Pesion
                    archivo.Write(objD.CalculaISR().ToString("N2").PadRight(14));               //ISR
                    archivo.Write(objD.CalculaSeguroSalud().ToString("N2").PadRight(14));       //Seguro
                    archivo.Write(objD.CalculaNetoMensual().ToString("N2").PadRight(14));       //ISR
                    archivo.Write("\n");

                    totalPension += objD.CalculaFondoPensiones();
                    totalISR += objD.CalculaISR();
                    totalSeguro += objD.CalculaSeguroSalud();
                    totalNeto += objD.CalculaNetoMensual();

                }

                archivo.Write("...\n".PadRight(75) +
                     "-------------".PadRight(14) +
                    "-------------".PadRight(14) +
                    "-------------".PadRight(14) +
                    "-------------".PadRight(14) +
                    "-------------\n"); ;

                archivo.Write("TOTALES Empleados " + nEmpleado + "".PadRight(53));
                archivo.Write(totalSueldo.ToString("N2").PadRight(14) +
                     totalPension.ToString("N2").PadRight(14) +
                     totalISR.ToString("N2").PadRight(14) +
                     totalSeguro.ToString("N2").PadRight(14) +
                     totalNeto.ToString("N2"));
                archivo.Write("\n===================".PadRight(72));
                archivo.Write("=============".PadRight(14));    // sueldo
                archivo.Write("=============".PadRight(14));    // Pension
                archivo.Write("=============".PadRight(14));    // ISR
                archivo.Write("=============".PadRight(14));    // Seguro
                archivo.Write("=============");      // Neto
            }
            //Console.ReadKey();
        }
    }
}
