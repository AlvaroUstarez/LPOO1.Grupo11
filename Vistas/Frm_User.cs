using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    public partial class Frm_User : Form
    {
        public Frm_User()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        
        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void label2_Click(object sender, EventArgs e)
        {
        
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void label3_Click(object sender, EventArgs e)
        {
        
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void label4_Click(object sender, EventArgs e)
        {
        
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void label5_Click(object sender, EventArgs e)
        {
        
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBoxContra_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void label6_Click(object sender, EventArgs e)
        {
        
        }

       

        
}
