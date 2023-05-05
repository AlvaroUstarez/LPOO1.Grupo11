using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class Frm_ObraSocial : Form
    {
        public Frm_ObraSocial()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //FrmPrincipal fPrincipal = new FrmPrincipal();
            this.Hide();
            //fPrincipal.Show();
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ObraSocial oObraSocial = new ObraSocial();

            oObraSocial.Os_Cuit = txtCuit.Text;
            oObraSocial.Os_RazonSocial = txtRazonSocial.Text;
            oObraSocial.Os_Direccion = txtDireccion.Text;
            oObraSocial.Os_Telefono = txtTelefono.Text;

            MessageBox.Show("CUIT: " + oObraSocial.Os_Cuit + "\n"
                           + "Razón Social: " + oObraSocial.Os_RazonSocial + "\n"
                           + "Dirección: " + oObraSocial.Os_Direccion + "\n"
                           + "Teléfono: " + oObraSocial.Os_Telefono + "\n"
                           , "Obra Social Registrada");
        }
    }
}
