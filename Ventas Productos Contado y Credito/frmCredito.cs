using System;
using System.Collections;
using System.Windows.Forms;

namespace Ventas_Productos_Contado_y_Credito
{
    public partial class frmCredito : Form
    {
        public frmCredito()
        {
            InitializeComponent();
        }

        Credito objCre = new Credito();

        static string[] productos = {"--Seleccione un producto--", "Lavadora", "Refigeradora",
            "Licuadora", "Extractora", "Radiograbadora", "DVD", "Blu Ray" };

        static int[] letras = {3,6,9,12};

        ArrayList aProducto = new ArrayList(productos);
        ArrayList aLetras = new ArrayList(letras);

        decimal tSubtotal = 0;       

        private void frmCredito_Load_1(object sender, EventArgs e)
        {
            muetraFecha();
            muetraHora();
            cboProducto.DataSource = aProducto;
            cboLetras.DataSource = aLetras;
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

        private void btnAquirir_Click_1(object sender, EventArgs e)
        {
            //Datos del cliente
            objCre.NombreCliente = txtCliente.Text;
            objCre.RUC = txtRuc.Text;
            objCre.Fecha = DateTime.Parse(lblFecha.Text);
            objCre.Hora = DateTime.Parse(lblHora.Text);

            //Datos del producto
            objCre.NombreProducto = cboProducto.Text;
            objCre.Cantidad = int.Parse(txtCantidad.Text);

            //Imprimiendo
            ListViewItem fila = new ListViewItem(objCre.getX().ToString());
            fila.SubItems.Add(objCre.NombreProducto);
            fila.SubItems.Add(objCre.Cantidad.ToString());
            fila.SubItems.Add(objCre.AsignaPrecio().ToString("C"));
            fila.SubItems.Add(objCre.CalculaSubTotal().ToString("C"));

            lvResultados.Items.Add(fila);

            tSubtotal += objCre.CalculaSubTotal();
            lblNetoPagar.Text = tSubtotal.ToString("C");

           // Listado(objCre);

        }

        public void montoLetras(int le)
        {
            
            decimal montoMensual = tSubtotal / le;

            lvLetras.Items.Clear();
            for (int i = 1; i <= le; i++)
            {
                ListViewItem fila = new ListViewItem(i.ToString());
                fila.SubItems.Add(montoMensual.ToString("C"));
                lvLetras.Items.Add(fila);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int letras = int.Parse(cboLetras.Text);

            switch (letras)
            {
                case 3: montoLetras(3); break;
                case 6: montoLetras(6); break;
                case 9: montoLetras(9); break;
                case 12: montoLetras(12); break;
            }
        }
    }
}
