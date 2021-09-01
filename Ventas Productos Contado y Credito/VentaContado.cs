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

namespace Ventas_Productos_Contado_y_Credito
{
    public partial class frmContado : Form
    {
        Contado objC = new Contado();

        static string[] productos = {"--Seleccione un producto--", "Lavadora", "Refigeradora",
            "Licuadora", "Extractora", "Radiograbadora", "DVD", "Blu Ray" };

        ArrayList aProducto = new ArrayList(productos);

        decimal tSubtotal = 0;

        public frmContado()
        {
            InitializeComponent();
           
        }

        private void frmContado_Load(object sender, EventArgs e)
        {
            muetraFecha();
            muetraHora();
            cboProducto.DataSource = aProducto;
            lblNetoPagar.Text = "0.00";
        }

        public void muetraFecha()
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        public void muetraHora()
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            //Datos del cliente
            objC.NombreCliente = txtCliente.Text;
            objC.RUC = txtRuc.Text;
            objC.Fecha =DateTime.Parse(lblFecha.Text);
            objC.Hora = DateTime.Parse(lblHora.Text);

            //Datos del producto
            objC.NombreProducto = cboProducto.Text;
            objC.Cantidad =int.Parse(txtCantidad.Text);

            //Imprimiendo
            ListViewItem fila = new ListViewItem(objC.getN().ToString());
            fila.SubItems.Add(objC.NombreProducto);
            fila.SubItems.Add(objC.Cantidad.ToString());
            fila.SubItems.Add(objC.AsignaPrecio().ToString("C"));
            fila.SubItems.Add(objC.CalculaSubTotal().ToString("C"));

            lvResultados.Items.Add(fila);

            Listado(objC);

        }

        public void Listado(Contado objC)
        {
            tSubtotal += objC.CalculaSubTotal();
            lstListado.Items.Clear();
            lstListado.Items.Add("** RESUMEN DE VENTA **");
            lstListado.Items.Add("-------------------------------------------------------");
            lstListado.Items.Add("CLIENTE: " + objC.NombreCliente);
            lstListado.Items.Add("RUC: " + objC.RUC);
            lstListado.Items.Add("FECHA: " + objC.Fecha.ToShortDateString());
            lstListado.Items.Add("HORA: " + objC.Hora);
            lstListado.Items.Add("-------------------------------------------------------");
            lstListado.Items.Add("SUBTOTAL: " + tSubtotal.ToString("C"));

            decimal descuento = objC.calcularDescuento(tSubtotal);
            decimal neto = objC.calculaNeto(tSubtotal, descuento);

            lstListado.Items.Add("DESCUENTO: " + descuento.ToString("C"));
            lstListado.Items.Add("NETO: " + neto.ToString("C"));

            //Hallar el monto sin descuento
            lblNetoPagar.Text = neto.ToString("C");
        }
    }
}
