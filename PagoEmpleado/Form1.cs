using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoEmpleado
{
    public partial class frmEmpleado : Form
    {
        static string[] categorias = { "CAS", "CAP" };

        ArrayList _categoria = new ArrayList(categorias);

        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            llenarCategoria();
        }

        private void LimpiarCampos()
        {
            txtEmpleado.Clear();
            cobCategoria.Text = "--Seleccione una categoria--";
            txtHoras.Clear();
            txtEmpleado.Focus();
        }

        private void llenarCategoria()
        {
            foreach (var c in _categoria)
            {
                cobCategoria.Items.Add(c);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Capturando valores
            string empleado = txtEmpleado.Text;
            string categoria = cobCategoria.Text;
            int horasTrab = int.Parse(txtHoras.Text);

            //Imprimiendo valores
            ListViewItem fila = new ListViewItem(empleado);
            fila.SubItems.Add(categoria);
            fila.SubItems.Add(horasTrab.ToString());
            fila.SubItems.Add(Empleados.CostoHoras(categoria).ToString("C"));
            fila.SubItems.Add(Empleados.SueldoBruto(categoria, horasTrab).ToString("C"));
            fila.SubItems.Add(Empleados.Descuento(categoria, horasTrab).ToString("C"));
            fila.SubItems.Add(Empleados.Neto(categoria, horasTrab).ToString("C"));
            lvRegistrar.Items.Add(fila);

            //Limpiar
            LimpiarCampos();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de salir..?", "Pago empleados",
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
    }
}
