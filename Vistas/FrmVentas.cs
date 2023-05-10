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
    public partial class FrmVentas : Form
    {

        public FrmVentas()
        {
            InitializeComponent();
            load_product();
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            
            DataTable dt = TrabajarCliente.list_clientes_ventas();

            DataRow dr = dt.NewRow();

            dr["dni_apellido"] = "Seleccionar un cliente";
            dr["id"] = 0;
            dt.Rows.InsertAt(dr, 0);
            cbmVC.DataSource = dt;
            cbmVC.ValueMember = "id";
            cbmVC.DisplayMember = "dni_apellido";
            cbmVC.SelectedIndex = 0;
        }

        private void load_product()
        {
            dgwListProd.DataSource = TrabajarProducto.listar_product();
        }

        private void btnSalirV_Click(object sender, EventArgs e)
        {
            FrmPrincipal fPrincipal = new FrmPrincipal();
            this.Hide();
            fPrincipal.Show();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

        }

        private void dgwListProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }





    }
}
