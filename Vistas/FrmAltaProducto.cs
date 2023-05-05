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
    public partial class FrmAltaProducto : Form
    {
        public FrmAltaProducto()
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

        private void btnAceptarAltaProd_Click(object sender, EventArgs e)
        {
            int codigo = 0;
            codigo += 1;
            Producto oProd = new Producto();
            oProd.Prod_Codigo = codigo.ToString(); 
            oProd.Prod_Categoria = txtCategoriaProd.Text;
            oProd.Prod_Descripcion = txtDescripcionProd.Text;
            oProd.Prod_Precio =Convert.ToDouble(txtPrecioProd.Text);


            MessageBox.Show("Categoría: " + oProd.Prod_Categoria + "\n"
                            + "Descripción: " + oProd.Prod_Descripcion + "\n"
                            + "Precio: " + oProd.Prod_Precio + "\n"
                            + "Codigo: " + oProd.Prod_Codigo + "\n"
                            , "Producto Agregado");
        }

        private void FrmAltaProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
