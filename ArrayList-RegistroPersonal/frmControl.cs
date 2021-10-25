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

namespace ArrayList_RegistroPersonal
{
    public partial class frmPrincipal : Form
    {
        //Objeto de la clase 
        ArrayList aPersonal = new ArrayList();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblCodigo.Text = generarCodigo();
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Objeto de la clase Personal
                Personal objP = new Personal();

                //Enviando informacion a la clase
                objP.Codigo = lblCodigo.Text;
                objP.Paterno = txtPaterno.Text;
                objP.Materno = txtMaterno.Text;
                objP.Nombres = txtNombres.Text;
                objP.FechaNacimiento = DateTime.Parse(txtFechaNac.Text);
                objP.FechaContrato = DateTime.Parse(txtFechaCont.Text);

                //Agregando al arraylist
                aPersonal.Add(objP);

                listado();
                limpiarControles();
                lblCodigo.Text = generarCodigo();
                    
            }
            catch (Exception m)
            {

                MessageBox.Show("Ocurrio un error al registrar.");
            }
        }

        private void limpiarControles()
        {
            txtPaterno.Clear();
            txtMaterno.Clear();
            txtNombres.Clear();
            txtFechaNac.Clear();
            txtFechaCont.Clear();
            txtPaterno.Focus();
        }

        private void listado()
        {
           lvListado.Items.Clear();
            foreach (Personal p in aPersonal)
            {
                ListViewItem fila = new ListViewItem(p.Codigo);
                fila.SubItems.Add(p.Paterno);
                fila.SubItems.Add(p.Materno);
                fila.SubItems.Add(p.Nombres);
                fila.SubItems.Add(p.FechaNacimiento.ToString());
                fila.SubItems.Add(p.FechaContrato.ToString());

                lvListado.Items.Add(fila);

            }
        }

        private string generarCodigo()
        {
            string cod = "";
            if (aPersonal.Count < 1)
            {
                return "P001";
            }
            else
            {
                foreach (Personal p in aPersonal)
                {
                    cod = p.Codigo.ToString();                    
                }
            }
            return "P" + (int.Parse(cod.Substring(1, 3)) + 1).ToString("000");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Personal p in aPersonal)
                {
                    if (p.Codigo == lblCodigo.Text)
                    {
                        p.Paterno = txtPaterno.Text;
                        p.Materno = txtMaterno.Text;
                        p.Nombres = txtNombres.Text;
                        p.FechaNacimiento = DateTime.Parse(txtFechaNac.Text);
                        p.FechaContrato = DateTime.Parse(txtFechaCont.Text);
                        break;
                    }
                }
                listado();
                generarCodigo();
                limpiarControles();
            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error modificando");
            }
        }

        private void lvListado_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem elemento = lvListado.GetItemAt(e.X, e.Y);

            if (elemento != null)
            {
                lblCodigo.Text = elemento.Text;
                txtPaterno.Text = elemento.SubItems[1].Text;
                txtMaterno.Text = elemento.SubItems[2].Text;
                txtNombres.Text = elemento.SubItems[3].Text;
                txtFechaNac.Text = elemento.SubItems[4].Text;
                txtFechaCont.Text = elemento.SubItems[5].Text;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Personal p in aPersonal)
                {
                    if (p.Codigo == lblCodigo.Text)
                    {
                        aPersonal.Remove(p);
                        break;
                    }
                }
                listado();
            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error elimiando");
            }
        }
    }
}
