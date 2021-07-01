using System;
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
        Ventas objV = new Ventas();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
            lblHora.Text = DateTime.Now.ToShortTimeString();
            cobProductos.Text = "--Seleccione un producto--";
            lblPrecio.Text = "0.00";
            lblTotal.Text = "0.00";
        }

        private void cobProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            objV.Producto = cobProductos.Text;
            lblPrecio.Text = objV.Producto.ToString();
        }
    }
}
