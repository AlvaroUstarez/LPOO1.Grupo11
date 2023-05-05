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
    public partial class FrmAltaCliente : Form
    {
       
        public FrmAltaCliente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmPrincipal fPrincipal = new FrmPrincipal();
            this.Hide();
            fPrincipal.Show();
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Cliente oCliente = new Cliente();

            oCliente.Cli_DNI = txtDni.Text;
            oCliente.Cli_Apellido = txtApellido.Text;
            oCliente.Cli_Nombre = txtNombre.Text;
            oCliente.Cli_Direccion = txtDireccion.Text;
            oCliente.OS_CUIT = txtCuit.Text;
            oCliente.Cli_NroCarnet = txtNroCarnet.Text;

            MessageBox.Show("DNI: " + oCliente.Cli_DNI + "\n"
                           + "Apellido: " + oCliente.Cli_Apellido + "\n"
                           + "Nombre: " + oCliente.Cli_Nombre + "\n"
                           + "Dirección: " + oCliente.Cli_Direccion + "\n"
                           + "Obra Social: " + oCliente.OS_CUIT + "\n"
                           + "Nro de Carnet: " + oCliente.Cli_NroCarnet + "\n"
                           , "Cliente Ingresado");
        }

        private void FrmAltaCliente_Load(object sender, EventArgs e)
        {

        }

      
    }
}
