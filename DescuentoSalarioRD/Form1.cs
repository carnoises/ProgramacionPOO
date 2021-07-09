using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DescuentoSalarioRD
{
    public partial class frmDescuentoSalario : Form
    {
        public frmDescuentoSalario()
        {
            InitializeComponent();
            tHora.Enabled = true;
        }       

        private void frmDescuentoSalario_Load(object sender, EventArgs e)
        {
            MostrarFecha();           
            LimpiarCampos();
        }       

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            decimal salario;           

            #region Validar Campos
            //Validar
            if (txtSalario.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un salario..", "Salario",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSalario.Focus();
                return;
            }
            else if (!Information.IsNumeric(txtSalario.Text))
            {
                MessageBox.Show("Solo es permitido números..", "Salario",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSalario.Focus();
                return;
            }
            else
            {
                salario = decimal.Parse(txtSalario.Text);
            }
            #endregion           

            //Objeto de la clase descuento
            Descuentos objD = new Descuentos(salario);

            //Imprime salario mensual
            txtSalarioMens.Text = objD.Salario.ToString("N2");
            txtRetenciones.Text = objD.Retenciones().ToString("N2");
            txtNetoMensual.Text = objD.CalculaNetoMensual().ToString("N2");

            //Impimir datos Primera Quincena
            txtSalarioPrimera.Text = objD.PrimeraQuincena().ToString("N2");
            txtNetoPrimero.Text = objD.PrimeraQuincena().ToString("N2");

            //Impimir datos Segunsa Quincena
            txtSalarioSegundo.Text = objD.PrimeraQuincena().ToString("N2");
            txtSeguroSegundo.Text = "-" + objD.CalculaSeguroSalud().ToString("N2");
            txtImpSegundo.Text = "-" + objD.CalculaISR().ToString("N2");
            txtFondoSegundo.Text = "-" + objD.CalculaFondoPensiones().ToString("N2");
            txtNetoSegundo.Text = objD.SegundaQuincena().ToString("N2");

            //Limpiar campo salario
            txtSalario.Clear();
            txtSalario.Focus();            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de salir..?", "Ingreso y Descuento",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                LimpiarCampos();
            }
        }
        
        private void tHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("h:mm:ss");
        }

        void MostrarFecha()
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }        

        private void LimpiarCampos()
        {
            txtSalario.Clear();
            txtSalarioMens.Clear();
            txtRetenciones.Clear();
            txtNetoMensual.Clear(); 
            
            txtSalarioPrimera.Text = "0.00"; 
            txtNetoPrimero.Text = "0.00";

            txtSalarioSegundo.Text = "0.00";
            txtSeguroSegundo.Text = "0.00";
            txtImpSegundo.Text = "0.00";
            txtFondoSegundo.Text = "0.00";
            txtNetoSegundo.Text = "0.00";
            txtSalario.Focus();
        }       
    }
}
