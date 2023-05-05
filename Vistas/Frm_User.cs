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
    public partial class Frm_User : Form
    {
        public Frm_User()
        {
            InitializeComponent();
        }

        private void comboBoxRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbRol.Items.Add("Administrador");
            cmbRol.Items.Add("Operador");
            cmbRol.Items.Add("Auditor");
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            Usuario oUser = new Usuario();
            oUser.Rol_Codigo = (int)cmbRol.SelectedValue;
            oUser.Usu_NombreUsuario = txtUsuario.Text;
            oUser.Usu_ApellidoNombre = txtNombre.Text + txtApellido.Text;
            oUser.Usu_Email = txtEmail.Text;
            oUser.Usu_Contraseña = txtContraseña.Text;

            TrabajarUsuario.insert_usuario(oUser);


        }

        //public int valorRol(){
        //if(cmbRol.SelectedValue == "Administrador")
        //{
        //    return 2;
        //}
        //return 3;

        private void Frm_User_Load(object sender, EventArgs e)
        {
            load_combo_roles();
            load_usuarios();

        }

        private void load_combo_roles()
        {
            cmbRol.DisplayMember = "rol_Descripcion";
            cmbRol.ValueMember = "rol_Codigo";
            cmbRol.DataSource = TrabajarUsuario.list_roles();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtSearchUser.Text != "")
            {
                dgwUsuarios.DataSource = TrabajarUsuario.search_usuarios(txtSearchUser.Text);
            }
            else
            {
                load_usuarios();
            }
        }

        private void load_usuarios()
        {
            dgwUsuarios.DataSource = TrabajarUsuario.list_usuarios();
        }
        
        
        //TODO:
        private void dgwUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (dgwUsuarios.CurrentRow != null)
                {
                    //cmbRol.SelectedValue = dgwUsuarios.CurrentRow.Cells["rol"].Value.ToString();

                    //txtApellido.Text = dgwUsuarios.CurrentRow.Cells["Apellido"].Value.ToString();
                    //txtNombre.Text = dgwUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
                    txtEmail.Text = dgwUsuarios.CurrentRow.Cells["Email"].Value.ToString();
                    txtUsuario.Text = dgwUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();
                    txtContraseña.Text = dgwUsuarios.CurrentRow.Cells["Contraseña"].Value.ToString();
                }
            }
        }








    }
}
