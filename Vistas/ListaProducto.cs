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
    public partial class ListaProducto : Form
    {
        public ListaProducto()
        {
            InitializeComponent();
            load_product();
        }
        private void load_product()
        {
            dgwProd.DataSource = TrabajarProducto.listar_product();
        }

        private void btnSalirP_Click(object sender, EventArgs e)
        {
            FrmPrincipal fPrincipal = new FrmPrincipal();
            this.Hide();
            fPrincipal.Show();

        }

        private void btnBuscarP_Click(object sender, EventArgs e)
        {
            if (txtBuscarProd.Text != "")
            {
                dgwProd.DataSource = TrabajarProducto.search_producto(int.Parse(txtBuscarProd.Text));
            }
            else
            {
                load_product();
            }
        }

        private void rbtnDes_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = TrabajarProducto.listar_product();


            // Obtener el nombre de la columna por la cual se desea ordenar
            string nombreColumna = "Descripcion";

            // Ordenar el DataTable
            dt.DefaultView.Sort = nombreColumna + " ASC";

            // Actualizar el DataGridView con los datos ordenados
            dgwProd.DataSource = dt;
        }

        private void rbtnCategoria_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = TrabajarProducto.listar_product();

            // Obtener el nombre de la columna por la cual se desea ordenar
            string nombreColumna = "Categoria";

            // Ordenar el DataTable
            dt.DefaultView.Sort = nombreColumna + " ASC";

            // Actualizar el DataGridView con los datos ordenados
            dgwProd.DataSource = dt;
        }

        private void rbtnPDef_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = TrabajarProducto.listar_product();

            // Obtener el nombre de la columna por la cual se desea ordenar
            string nombreColumna = "Codigo";

            // Ordenar el DataTable
            dt.DefaultView.Sort = nombreColumna + " ASC";

            // Actualizar el DataGridView con los datos ordenados
            dgwProd.DataSource = dt;
        }

    }
}
