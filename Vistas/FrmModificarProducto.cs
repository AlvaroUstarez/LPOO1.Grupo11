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
    public partial class FrmModificarProducto : Form
    {
        public FrmModificarProducto()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dgwProductos.DataSource = TrabajarProducto.buscarProductoDescripcion(txtBuscar.Text);
            }
            else
            {
                load_productos();
            }
        }

        private void load_productos()
        {
            dgwProductos.DataSource = TrabajarProducto.listar_product();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmPrincipal fPrincipal = new FrmPrincipal();
            this.Hide();
            fPrincipal.Show();
        }

    }
}
