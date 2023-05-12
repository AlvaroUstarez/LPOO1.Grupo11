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
            DateTimePicker fecha = dtpFechaVenta; 
            InitializeComponent();
            load_product();

            //TODO
            load_venta();
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            load_usuers();
        }

        private void agregar_venta()
        {
            
        }

        private void load_product()
        {
            dgwListProd.DataSource = TrabajarProducto.listar_product();
        }

        private void load_usuers()
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

        private void btnSalirV_Click(object sender, EventArgs e)
        {
            FrmPrincipal fPrincipal = new FrmPrincipal();
            this.Hide();
            fPrincipal.Show();
        }

        private void dgwListProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwListProd.CurrentRow != null)
            {
                txtCodigoProd.Text = dgwListProd.CurrentRow.Cells["Codigo"].Value.ToString();
                txtCategoriaProd.Text = dgwListProd.CurrentRow.Cells["Categoria"].Value.ToString();
                txtDescripcionProd.Text = dgwListProd.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtPrecioProd.Text = dgwListProd.CurrentRow.Cells["Precio"].Value.ToString();
            }
        }

        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            VentaDetalle detalle = new VentaDetalle();

            detalle.ProdCodigo = int.Parse(txtCodigoProd.Text);
            detalle.DetallePrecio = float.Parse(txtPrecioProd.Text);
            detalle.DetalleCantidad = float.Parse(txtPrecioProd.Text);
            detalle.DetalleTotal = detalle.DetallePrecio * detalle.DetalleCantidad;


            MessageBox.Show("Código: " + txtCodigoProd.Text+ "\n"
                           + "Categoría: " + txtCategoriaProd.Text + "\n"
                           + "Descripción: " + txtDescripcionProd.Text + "\n"
                           + "Precio: " + txtPrecioProd.Text + "\n"
                           + "Cantidad: " + txtCantidadProd.Text + "\n"
                           + "Total: " + detalle.DetalleTotal + "\n"
                           , "Producto Agregado");

            TrabajarVenta.agregar_detalle(detalle);

            dgwDetalleVenta.DataSource = TrabajarVenta.obtenerDetalles();

            dgwDetalleVenta.Columns["ProdCodigo"].HeaderText = "Código";
            dgwDetalleVenta.Columns["DetallePrecio"].HeaderText = "Categoría";
            dgwDetalleVenta.Columns["DetalleCantidad"].HeaderText = "Descripción";
            dgwDetalleVenta.Columns["DetalleTotal"].HeaderText = "Precio";


        }

        //Agrega una venta con la fecha y asigna Ven_Nro al textbox
        private void load_venta()
        {
            Venta venta = new Venta();
            venta.VentaFecha = dtpFechaVenta.Value;
            int nroVenta = TrabajarVenta.iniciar_venta(venta);
            txtNroVenta.Text = Convert.ToString(nroVenta);
        }

        //Agregar Lista de detalles de venta
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (int.Parse(cbmVC.ValueMember) == 0)
            {
                MessageBox.Show("No se puede Agregar la venta sin un cliente");
            }
            else
            {
                BindingList<VentaDetalle> detalles = TrabajarVenta.obtenerDetalles();

                foreach (VentaDetalle detalle in detalles)
                {
                    detalle.VentaNumero = int.Parse(txtNroVenta.Text);
                    TrabajarVenta.guardarDetalle(detalle);
                }

                FrmPrincipal fPrincipal = new FrmPrincipal();
                this.Hide();
                fPrincipal.Show();
            }
            
            
            
        }


        







    }
}
