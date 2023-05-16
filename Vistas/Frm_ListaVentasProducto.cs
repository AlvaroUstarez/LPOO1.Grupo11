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
    public partial class Frm_ListaVentasProducto : Form
    {
        public Frm_ListaVentasProducto()
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
            cmbListaClientesProd.DataSource = dt;
            cmbListaClientesProd.ValueMember = "id";
            cmbListaClientesProd.DisplayMember = "dni_apellido";
            cmbListaClientesProd.SelectedIndex = 0;

        }

        private void btnBuscarVentaProducto_Click(object sender, EventArgs e)
        {
            int idcliente = int.Parse(cmbListaClientesProd.SelectedValue.ToString());
            DataTable dt2 = TrabajarVenta.buscarVenta(idcliente);
            DataTable dt1 = TrabajarVenta.mostrarTablaVentaDetalle();


            // Obtener los valores de la columna "columna2" de dt2
            List<int> valoresColumna2 = dt2.AsEnumerable()
                                            .Select(row => row.Field<int>("Venta Numero"))
                                            .ToList();

            // Filtrar las filas de dt1 que tienen un valor en la columna "columna1"
            // que coincide con los valores de la columna "columna2" de dt2
            DataTable dtResult = dt1.AsEnumerable()
                                    .Where(row => valoresColumna2.Contains(row.Field<int>("Ven_Nro")))
                                    .CopyToDataTable();


            dgwListaVentaProducto.DataSource = dtResult;

            
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmPrincipal fPrincipal = new FrmPrincipal();
            this.Hide();
            fPrincipal.Show();
        }

    }
}
