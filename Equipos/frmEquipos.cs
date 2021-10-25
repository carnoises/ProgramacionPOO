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

namespace Equipos
{
    public partial class frmEquipos : Form
    {
        ArrayList aEquipo = new ArrayList();        

        public frmEquipos()
        {
            InitializeComponent();
        }

        private void frmEquipos_Load(object sender, EventArgs e)
        {
            lblCodigo.Text = GenerarCodigo();
        }

        private string GenerarCodigo()
        {
            string cod = "";

            if (aEquipo.Count < 1)
            {
                return "P001";
            }
            else
            { 
                foreach (TipoEquipos tipo in aEquipo)
                {
                    cod = tipo.CODIGO.ToString();
                }
                
            }
            return cod = "P" + (int.Parse(cod.Substring(1, 3)) + 1).ToString("000");
    }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            TipoEquipos objT = new TipoEquipos();

            objT.CODIGO = lblCodigo.Text;
            objT.NOMBRE = txtTipo.Text;

            aEquipo.Add(objT);

            Listado();
            lblCodigo.Text = GenerarCodigo();
            txtTipo.Clear();}

        private void Listado()
        {
            lvRegistro.Items.Clear();

            try
            {             

                foreach (TipoEquipos tipo in aEquipo)
                {
                    ListViewItem list = new ListViewItem(tipo.CODIGO);
                    list.SubItems.Add(tipo.NOMBRE);

                    lvRegistro.Items.Add(list);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
