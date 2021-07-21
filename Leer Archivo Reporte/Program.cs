using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DescuentoSalarioRD;

namespace Leer_Archivo_Reporte
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lineasArchivo = System.IO.File.ReadAllLines(@"E:\Desktop\nomina.txt");
            char delimador = ',';

            int EmplPresidencia = 0;
            decimal totalSueldoPre = 0;
            decimal totalPensionPres = 0;
            decimal totalIsrPres = 0;
            decimal totalSeguroPres = 0;
            decimal totalnetoPres = 0;

            int EmplAdmini = 0;
            decimal totalSueldoAdmin = 0;
            int empMant = 0;
            int empTecn = 0;
            decimal totalSueldoTecn = 0;
            decimal totalEmpMant = 0;
            decimal totalSueldo = 0;
            int nEmpleado = 0;
            int totalEmpl = 0;
            decimal sueldoGlobal = 0;

            foreach (var linea in lineasArchivo)
            {
                var camposLinea = linea.Split(delimador);
                totalSueldo += decimal.Parse(camposLinea[4]);
                nEmpleado++;
            }


            using (System.IO.StreamWriter archivo = new System.IO.StreamWriter(@"E:\Prueba\NOMINA_RPT2.TXT"))
            {
                archivo.Write("EMPRESA ABC");
                archivo.WriteLine(DateTime.Now.ToShortDateString().PadLeft(120) + " " + DateTime.Now.ToShortTimeString());
                archivo.WriteLine("SISTEMA DE NOMINA");
                archivo.WriteLine("NOMINA DEL PERIODO " + " MES " + DateTime.Now.Month + " " + " AÑO " + DateTime.Now.Year);
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

                //Presidencia
                archivo.Write("Departamento: PRESIDENCIA\n");
                foreach (var item in lineasArchivo)
                {                    
                    var campoLineas = item.Split(',');                    
                    Descuentos objDP = new Descuentos(decimal.Parse(campoLineas[4]));
                    if (campoLineas[3] == "Presidencia")
                    {                        
                        archivo.Write(campoLineas[0].PadRight(9));                                  //Codigo
                        archivo.Write(campoLineas[1].PadRight(33));                                 //Nombre
                        archivo.Write(campoLineas[2].PadRight(14));                                 //Puesto
                        archivo.Write(campoLineas[3].PadRight(16));                                 //Departamento
                        archivo.Write(campoLineas[4].PadRight(14));
                        //archivo.Write(campoLineas[4].PadRight(8));
                        archivo.Write(objDP.CalculaFondoPensiones().ToString("N2").PadRight(14));
                        archivo.Write(objDP.CalculaSeguroSalud().ToString("N2").PadRight(14));
                        archivo.Write(objDP.CalculaISR().ToString("N2").PadRight(14));                        
                        archivo.Write(objDP.CalculaNetoMensual().ToString("N2").PadRight(14));
                        archivo.Write("\n");
                        EmplPresidencia++;
                        totalSueldoPre += decimal.Parse(campoLineas[4]);
                        totalPensionPres += objDP.CalculaFondoPensiones();
                        totalIsrPres += objDP.CalculaISR();
                        totalSeguroPres += objDP.CalculaSeguroSalud();
                        totalnetoPres += objDP.CalculaNetoMensual();
                    }                   

                }

                archivo.Write("".PadRight(72) +
                     "-------------".PadRight(14) +
                    "-------------".PadRight(14) +
                    "-------------".PadRight(14) +
                    "-------------".PadRight(14) +
                    "-------------\n"); ;
                archivo.Write("TOTALES: PRESIDENCIA " + EmplPresidencia + "".PadRight(50));
                archivo.Write(totalSueldoPre.ToString("N2").PadRight(14));
                archivo.Write(totalPensionPres.ToString("N2").PadRight(14));
                archivo.Write(totalIsrPres.ToString("N2").PadRight(14));
                archivo.Write(totalSeguroPres.ToString("N2").PadRight(14));
                archivo.Write(totalnetoPres.ToString("N2"));

                //Administracion
                archivo.Write("\n\nDepartamento: ADMINISTRACION\n");
                foreach (var item in lineasArchivo)
                {
                    var campoLineas = item.Split(',');
                    Descuentos objA = new Descuentos(decimal.Parse(campoLineas[4]));
                    if (campoLineas[3] == "Administracion")
                    {
                        archivo.Write(campoLineas[0].PadRight(9));                                  //Codigo
                        archivo.Write(campoLineas[1].PadRight(33));                                 //Nombre
                        archivo.Write(campoLineas[2].PadRight(14));                                 //Puesto
                        archivo.Write(campoLineas[3].PadRight(16));                                 //Departamento
                        archivo.Write(campoLineas[4].PadRight(8));
                        archivo.Write(objA.CalculaFondoPensiones().ToString("N2").PadRight(14));
                        archivo.Write(objA.CalculaSeguroSalud().ToString("N2").PadRight(14));
                        archivo.Write(objA.CalculaISR().ToString("N2").PadRight(14));
                        archivo.Write(objA.CalculaNetoMensual().ToString("N2").PadRight(14));
                        archivo.Write("\n");
                        EmplAdmini++;
                        totalSueldoAdmin += decimal.Parse(campoLineas[4]);
                    }

                }

                archivo.Write("".PadRight(72) +
                     "-------------".PadRight(14) +
                    "-------------".PadRight(14) +
                    "-------------".PadRight(14) +
                    "-------------".PadRight(14) +
                    "-------------\n"); ;
                archivo.Write("TOTALES: ADMINISTRACION " + EmplAdmini + "".PadRight(47));
                archivo.Write(totalSueldoAdmin.ToString("N2").PadRight(14));

                //Mantenimiento
                archivo.Write("\n\nDepartamento: MANTENIMIENTO\n");
                foreach (var item in lineasArchivo)
                {
                    var campoLineas = item.Split(',');
                    //objD = new Descuentos(decimal.Parse(campoLineas[4]));
                    if (campoLineas[3] == "Mantenimiento")
                    {
                        archivo.Write(campoLineas[0].PadRight(9));                                  //Codigo
                        archivo.Write(campoLineas[1].PadRight(33));                                 //Nombre
                        archivo.Write(campoLineas[2].PadRight(14));                                 //Puesto
                        archivo.Write(campoLineas[3].PadRight(16));                                 //Departamento
                        archivo.Write(campoLineas[4].PadRight(8));
                        archivo.Write("\n");
                        empMant++;
                        totalEmpMant += decimal.Parse(campoLineas[4]);
                    }

                }

                archivo.Write("".PadRight(72) +
                     "-------------".PadRight(14) +
                    "-------------".PadRight(14) +
                    "-------------".PadRight(14) +
                    "-------------".PadRight(14) +
                    "-------------\n"); ;
                archivo.Write("TOTALES: MANTENIMIENTO " + empMant + "".PadRight(48));
                archivo.Write(totalEmpMant.ToString("N2").PadRight(14));


                //Tecnologia
                archivo.Write("\n\nDepartamento: TECNOLOGIA\n");
                foreach (var item in lineasArchivo)
                {
                    var campoLineas = item.Split(',');
                    //objD = new Descuentos(decimal.Parse(campoLineas[4]));
                    if (campoLineas[3] == "Tecnologia")
                    {
                        archivo.Write(campoLineas[0].PadRight(9));                                  //Codigo
                        archivo.Write(campoLineas[1].PadRight(33));                                 //Nombre
                        archivo.Write(campoLineas[2].PadRight(14));                                 //Puesto
                        archivo.Write(campoLineas[3].PadRight(16));                                 //Departamento
                        archivo.Write(campoLineas[4].PadRight(8));
                        archivo.Write("\n");
                        empTecn++;
                       totalSueldoTecn += decimal.Parse(campoLineas[4]);
                    }

                }

                archivo.Write("".PadRight(72) +
                     "-------------".PadRight(14) +
                    "-------------".PadRight(14) +
                    "-------------".PadRight(14) +
                    "-------------".PadRight(14) +
                    "-------------\n"); 
                archivo.Write("TOTALES: TECNOLOGIA " + empTecn + "".PadRight(51));
                archivo.Write(totalSueldoTecn.ToString("N2").PadRight(14));

                archivo.Write("\n".PadRight(72) +
                     "-------------".PadRight(14) +
                    "-------------".PadRight(14) +
                    "-------------".PadRight(14) +
                    "-------------".PadRight(14) +
                    "-------------\n");

                totalEmpl = EmplPresidencia + EmplAdmini + empMant + empTecn;
                sueldoGlobal = totalSueldoPre + totalSueldoAdmin + totalEmpMant + totalSueldoTecn;

                archivo.Write("\nTOTAL GENERAL: " + totalEmpl + "".PadRight(56));
                archivo.Write(sueldoGlobal.ToString("N2").PadRight(14));
                archivo.Write("\n".PadRight(72));
                archivo.Write("=============".PadRight(14));    // sueldo
                archivo.Write("=============".PadRight(14));    // Pension
                archivo.Write("=============".PadRight(14));    // ISR
                archivo.Write("=============".PadRight(14));    // Seguro
                archivo.Write("=============");      // Neto
            }
        }
    }
}
