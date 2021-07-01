using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromedioDeNotas
{
    public partial class frmEvaluacion : Form
    {
        public frmEvaluacion()
        {
            InitializeComponent();
        }

        private void frmEvaluacion_Load(object sender, EventArgs e)
        {
            lblPromedio.Text = "";
            lblNotaBaja.Text = "";
            lblCondicion.Text = "";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Promedio objP = new Promedio();

            objP.nota1 = int.Parse(txtxNota1.Text);
            objP.nota2 = int.Parse(txtxNota2.Text);
            objP.nota3 = int.Parse(txtxNota3.Text);
            objP.nota4 = int.Parse(txtxNota4.Text);

            //Imprimir
            lblPromedio.Text = objP.PromedioNotas().ToString("0.00");
            lblNotaBaja.Text = objP.MasBaja().ToString();
            lblCondicion.Text = objP.Condicion();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de salir.?", "Notas",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
