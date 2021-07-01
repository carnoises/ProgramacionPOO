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

namespace ControlDeVentas
{
    public partial class Form1 : Form
    {
        static string[] productos = { "Impresora", "Mouse", "Monitor", "Parlante", "Teclado" };

        ArrayList aProdcutos = new ArrayList(productos);

        Ventas objV = new Ventas();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarFecha();
            MostrarHora();
            LlenarProductos();
            LimpiarCampos();
        }

        private void cobProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            objV.Producto = cobProductos.Text;
            lblPrecio.Text = objV.AsignarPrecio().ToString("C");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de salir.?", "Ventas",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void MostrarFecha()
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }
        private void MostrarHora()
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void LimpiarCampos()
        {
            cobProductos.Text = "--Seleccione un producto--";
            lblPrecio.Text = "0.00";
            lblTotal.Text = "0.00";
            txtCliente.Clear();
            txtCantidad.Clear();
            txtCliente.Focus();
        }

        private void LlenarProductos()
        {
            foreach (var p in aProdcutos)
            {
                cobProductos.Items.Add(p);
            }
        }
    }
}
