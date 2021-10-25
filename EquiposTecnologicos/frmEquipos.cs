using System;
using System.Collections;
using System.Windows.Forms;

namespace EquiposTecnologicos
{
    public partial class frmEquipos : Form
    {
        ArrayList aTipo = new ArrayList();        

        public frmEquipos()
        {
            InitializeComponent();
        }

        private void frmEquipos_Load(object sender, EventArgs e)
        {
            lblCodigo.Text = GenerarCodigo();
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            lblCodigo.Text = GenerarCodigo();
            LimpiarControles();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Objeto de la clase TipodeEquipos
                TipoDeEquipo objT = new TipoDeEquipo();

                //Enviando informacion a la clase
                objT.CODIGO = lblCodigo.Text;
                objT.NOMBRE = txtTipo.Text;
                
                aTipo.Add(objT);

                Listado();
                LimpiarControles();
                lblCodigo.Text = GenerarCodigo();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo agregar el registro..");
            }  
        }

        private void LimpiarControles()
        {            
            txtTipo.Clear();
            txtTipo.Focus();
        }

        private void Listado()
        {
            lvRegistro.Items.Clear();

            foreach (TipoDeEquipo t in aTipo)
            {
                ListViewItem list = new ListViewItem(t.CODIGO);
                list.SubItems.Add(t.NOMBRE);

                lvRegistro.Items.Add(list);
            }
        }

        private string GenerarCodigo()
        {
            string cod = "";

            if (aTipo.Count < 1)   
            {               
                return "P001";
            }
            else
            {
                foreach (TipoDeEquipo t in aTipo)
                {
                    cod = t.CODIGO.ToString();
                }
            }
            return "P" + (int.Parse(cod.Substring(1, 3)) + 1).ToString("000");
        }
        
    }
}
