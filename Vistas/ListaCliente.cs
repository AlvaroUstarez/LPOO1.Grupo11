using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;
using System.Data;
using System.Data.SqlClient;

namespace Vistas
{
    public partial class ListaCliente : Form
    {
        public ListaCliente()
        {
            InitializeComponent();
            load_clientes();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            if (txtBuscarCliente.Text != "")
            {
                dgwCliente.DataSource = TrabajarCliente.search_clientes(txtBuscarCliente.Text);
            }
            else
            {
                load_clientes();
            }
        }

        private void load_clientes()
        {
            dgwCliente.DataSource = TrabajarCliente.list_clientes();
        }

        private void btnClienteSalir_Click(object sender, EventArgs e)
        {
            FrmPrincipal fPrincipal = new FrmPrincipal();
            this.Hide();
            fPrincipal.Show();

        }
        

        

 
    }
}
