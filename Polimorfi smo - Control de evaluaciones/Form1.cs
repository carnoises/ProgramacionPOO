using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polimorfi_smo___Control_de_evaluaciones
{
    public partial class frmEvaluaciones : Form
    {
        PromedioProgramacion objP = new PromedioProgramacion();

        public frmEvaluaciones()
        {
            InitializeComponent();
        }

        private void frmEvaluaciones_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Capturar los datos
            objP.Nombre = txtNombre.Text;
            objP.Evaluacion1 = double.Parse(txtEva1.Text);
            objP.Evaluacion2 = double.Parse(txtEva2.Text);
            objP.Evaluacion3 = double.Parse(txtEva3.Text);
            objP.Actitudinal = double.Parse(txtActitudinal.Text);

            // Imprimiendo 
            ListViewItem fila = new ListViewItem(objP.Nombre);
            fila.SubItems.Add(objP.Evaluacion1.ToString("0.00"));
            fila.SubItems.Add(objP.Evaluacion2.ToString("0.00"));
            fila.SubItems.Add(objP.Evaluacion3.ToString("0.00"));
            fila.SubItems.Add(objP.Actitudinal.ToString("0.00"));
            fila.SubItems.Add(objP.calculaPromedio().ToString("0.00"));
            fila.SubItems.Add(objP.condicion());

            //Enviando a ListView
            lvRegistro.Items.Add(fila);

            //Imprime estadistica
            Estadisticas();
        }

        public double sumaPromedio()
        {
            double suma = 0;
            for (int i = 0; i < lvRegistro.Items.Count; i++)
            {
                suma += double.Parse(lvRegistro.Items[i].SubItems[5].Text);
            }
            return suma;
        }

        public double promedioMasAlto()
        {
            double mayor = 0;
            for (int i = 0; i < lvRegistro.Items.Count; i++)
            {
                if (double.Parse(lvRegistro.Items[i].SubItems[5].Text) > mayor)
                {
                    mayor = double.Parse(lvRegistro.Items[i].SubItems[5].Text);
                }
            }
            return mayor;
        }

        public double promedioMasBajo()
        {
            double menor = int.MaxValue;
            for (int i = 0; i < lvRegistro.Items.Count; i++)
            {
                if (double.Parse(lvRegistro.Items[i].SubItems[5].Text) < menor)
                {
                    menor = double.Parse(lvRegistro.Items[i].SubItems[5].Text);
                }
            }
            return menor;
        }

        public int totalAprobado()
        {
            int cAprobado = 0;
            for (int i = 0; i < lvRegistro.Items.Count; i++)
            {
                if (double.Parse(lvRegistro.Items[i].SubItems[5].Text) >= 12.5)
                {
                    cAprobado++;
                }
            }
            return cAprobado;
        }

        public int totalReprobado()
        {
            int cReAprobado = 0;
            for (int i = 0; i < lvRegistro.Items.Count; i++)
            {
                if (double.Parse(lvRegistro.Items[i].SubItems[5].Text) < 12.5)
                {
                    cReAprobado++;
                }
            }
            return cReAprobado;
        }

        public void Estadisticas()
        {
            lbEstadistica.Items.Clear();

            lbEstadistica.Items.Add("Suma de promedios: " + sumaPromedio().ToString("0.00"));
            lbEstadistica.Items.Add("Promedio mas alto: " + promedioMasAlto().ToString("0.00"));
            lbEstadistica.Items.Add("Promedio mas bajo: " + promedioMasBajo().ToString("0.00"));
            lbEstadistica.Items.Add("Total aprobados: " + totalAprobado().ToString("0.00"));
            lbEstadistica.Items.Add("Total reaprobados: " + totalReprobado().ToString("0.00"));
        }
    }
}
