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
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error al registrar.");
            }
        }

        private void limpiarControles()
        {
            throw new NotImplementedException();
        }

        private void listado()
        {
            throw new NotImplementedException();
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
    }
}
