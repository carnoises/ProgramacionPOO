using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leer_Archivo
{
    class Program
    {
        static void Main(string[] args)
        {
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

            using (System.IO.StreamWriter archivo = new System.IO.StreamWriter(@"E:\Prueba\NOMINA_RPT1.TXT"))
            {
                archivo.Write("EMPRESA ABC");
                archivo.WriteLine("\t\t\t\t\t\t" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());
                archivo.WriteLine("SISTEMA DE NOMINA");
                archivo.WriteLine("NOMINA DEL PERIODO "+" MES " + DateTime.Now.Month + " " + " AÑO " + DateTime.Now.Year);
                archivo.WriteLine();
                archivo.WriteLine("EMPLEADO NOMBRE  PUESTO      DEPARTAMENTO     SUELDO  FPENSION       ISR    SEGURO           NETO");
                archivo.WriteLine("---------------------------------------------------------------------------------------------------");

                // Environment.NewLine();

                foreach (var item in lineasArchivo)
                {
                    //var camposLinea = item.Split(delimador);
                    //for (int i = 0; i < camposLinea.Length; i++)
                    //{
                    //    archivo.Write(camposLinea[i]+"\n");

                    //}
                    archivo.Write(item.Replace(',', ' ') +"      " + "\n");

                }

                archivo.Write("TOTALES Empleados " + nEmpleado);
                archivo.Write("                        ------------\n");
                archivo.Write("                                            " +totalSueldo);

            }

            Console.WriteLine(totalSueldo);

            Console.ReadKey();
        }
    }
}
