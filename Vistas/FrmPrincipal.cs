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
            Frm_Cliente fAltaCliente = new Frm_Cliente();
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
    }
}
