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

        private void label7_Click(object sender, EventArgs e)
        {

        }




        private void dgwCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwCliente.CurrentRow != null)
            {
                txtIdCliente.Text = dgwCliente.CurrentRow.Cells["Id"].Value.ToString();
                txtDniCliente.Text = dgwCliente.CurrentRow.Cells["DNI"].Value.ToString();
                txtApellidoCliente.Text = dgwCliente.CurrentRow.Cells["Apellido"].Value.ToString();
                txtNombreCliente.Text = dgwCliente.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDireCliente.Text = dgwCliente.CurrentRow.Cells["Direccion"].Value.ToString();
                txtCarnet.Text = dgwCliente.CurrentRow.Cells["Carnet"].Value.ToString();
                txtCuitOS.Text = dgwCliente.CurrentRow.Cells["Cuit"].Value.ToString();
                

                
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {

            if (txtApellidoCliente.Text == "" || txtDniCliente.Text == "" || txtNombreCliente.Text == "" || txtDireCliente.Text == "" || txtCarnet.Text == "" || txtCuitOS.Text == "")
            {
                MessageBox.Show("Los campos tienen que estar completos");

            }
            else
            {
                Cliente oCliente = new Cliente();
                oCliente.Cli_DNI = txtDniCliente.Text;
                oCliente.Cli_Apellido = txtApellidoCliente.Text;
                oCliente.Cli_Nombre = txtNombreCliente.Text;
                oCliente.Cli_Direccion = txtDireCliente.Text;
                oCliente.Cli_NroCarnet = txtCarnet.Text;
                oCliente.OS_CUIT = txtCuitOS.Text;
                TrabajarCliente.modificar_Cliente( int.Parse(txtIdCliente.Text), oCliente);

                load_clientes();
                limpiarCampos();


            }
           

        }

        public void limpiarCampos(){
            txtIdCliente.Clear();
            txtDniCliente.Clear();
            txtApellidoCliente.Clear();
            txtNombreCliente.Clear();
            txtDireCliente.Clear();
            txtCarnet.Clear();
            txtCuitOS.Clear();
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }
        

 
    }
}
