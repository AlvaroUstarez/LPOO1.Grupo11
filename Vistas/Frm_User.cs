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
            comboBoxRol.Items.Add("Administrador");
            comboBoxRol.Items.Add("Operador");
            comboBoxRol.Items.Add("Auditor");
        }

        private void dataGridViewFrmUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            Usuario oUser = new Usuario();
        }

        private void buttonBuscarFRM(object sender, EventArgs e)
        {

        }

        private void tbBuscarFRM(object sender, EventArgs e)
        {

        }

        private void comboBoxRol_FRM(object sender, EventArgs e)
        {

        }

        private void textBoxApellido_FRM(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_FRM(object sender, EventArgs e)
        {

        }

        private void textBoxContra_FRM(object sender, EventArgs e)
        {

        }

        private void btnSaveUser_FRM(object sender, EventArgs e)
        {

        }

        private void textBoxName_FRM(object sender, EventArgs e)
        {

        }

        private void textBoxUser_FRM(object sender, EventArgs e)
        {

        }



    }
}
