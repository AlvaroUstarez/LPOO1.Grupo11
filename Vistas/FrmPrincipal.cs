using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void agregarNuevosProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Producto fAltaProducto = new Frm_Producto();
            this.Hide();
            fAltaProducto.Show();
            this.Close();
        }

        private void ingresarNuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_AltaCliente fAltaCliente = new Frm_AltaCliente();
            this.Hide();
            fAltaCliente.Show();
            this.Close();
        }

        private void registrarObraSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ObraSocial fAltaObraSocial = new Frm_ObraSocial();
            this.Hide();
            fAltaObraSocial.Show();
            this.Close();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro(a) que desea salir del sistema?",
                 "Consulta",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Frm_User fUser = new Frm_User();
            this.Hide();
            fUser.Show();

        }

        private void listaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaCliente lCliente = new ListaCliente();
            this.Hide();
            lCliente.Show();
        }

        private void listarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaProducto lProducto = new ListaProducto();
            this.Hide();
            lProducto.Show();
        }


        private void agregarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVentas formVenta = new FrmVentas();
            this.Hide();
            formVenta.Show();
        }

        private void listarVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaVenta frmListaVenta = new FrmListaVenta();
            this.Hide();
            frmListaVenta.Show();
        }

        private void modificarProductosExistentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificarProducto frmModificarProducto = new FrmModificarProducto();
            this.Hide();
            frmModificarProducto.Show();
            this.Close();
        }


    }
}
