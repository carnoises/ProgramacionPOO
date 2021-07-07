using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlFacturas
{
    public partial class frmFacturas : Form
    {
        public frmFacturas()
        {
            InitializeComponent();
        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            lblFecha.Text = MuestraFecha();
        }

        Func<string> MuestraFecha = () => DateTime.Now.ToShortDateString();

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Obtener datos
            int numFact = int.Parse(txtNumFact.Text);
            DateTime fechaFact = dtpFechaFact.Value;
            decimal monto = decimal.Parse(txtMontoFact.Text);

            Factura objF = new Factura(numFact, fechaFact, monto);

            // Imprimiendo valores
            ListViewItem list = new ListViewItem(objF.GetNumFact.ToString());
            list.SubItems.Add(objF.GetFechaFact.ToShortDateString());
            list.SubItems.Add(objF.GetMontFact.ToString("C"));

            lvRegistro.Items.Add(list);

            lblTotalFact.Text = objF.totalFacturas().ToString();
            lblTotalSub.Text = objF.CalculaTotalSubtotal().ToString("C");
            lblComision.Text = objF.CalculaComision().ToString("C");

        }
    }
}
