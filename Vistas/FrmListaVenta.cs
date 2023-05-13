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
    public partial class FrmListaVenta : Form
    {
        public FrmListaVenta()
        {
            InitializeComponent();
            load_usuers();
            
        }

        private void load_usuers()
        {
            DataTable dt = TrabajarCliente.list_clientes_ventas();

            DataRow dr = dt.NewRow();

            dr["dni_apellido"] = "Seleccionar un cliente";
            dr["id"] = 0;
            dt.Rows.InsertAt(dr, 0);
            cmbListaClientes.DataSource = dt;
            cmbListaClientes.ValueMember = "id";
            cmbListaClientes.DisplayMember = "dni_apellido";
            cmbListaClientes.SelectedIndex = 0;

        }

        private void btnBuscarVenta_Click(object sender, EventArgs e)
        {
            int idcliente = int.Parse(cmbListaClientes.SelectedValue.ToString());
            TrabajarVenta.buscarVenta(idcliente);

            dgwListaVenta.DataSource = TrabajarVenta.buscarVenta(idcliente);

        }

        //Buscar Venta por fecha
        private void btnBuscarFecha_Click(object sender, EventArgs e)
        {
            dgwListaVenta.DataSource = TrabajarVenta.buscarVentaFecha(dtpFechaInicio.Value , dtpFechaFin.Value);
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmPrincipal fPrincipal = new FrmPrincipal();
            this.Hide();
            fPrincipal.Show();
        }

        
    }
}
