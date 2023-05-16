using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
<<<<<<< HEAD
=======
using ClasesBase;
>>>>>>> dr-da

namespace Vistas
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
=======

        private void btnAceptarLogin_Click(object sender, EventArgs e)
        {
            Boolean existe = false;
            Usuario oAdministrador = new Usuario("admin", "admin");
            Usuario oOperador = new Usuario("Operador", "operador");
            Usuario oAuditor = new Usuario("Auditor", "auditor");
            FrmPrincipal fPrincipal = new FrmPrincipal();

            List<Usuario> usuarios = new List<Usuario>();
            usuarios.Add(oAdministrador);
            usuarios.Add(oOperador);
            usuarios.Add(oAuditor);


            foreach(Usuario usuAux in usuarios)
            {
                if(usuAux.Usu_NombreUsuario == txtUsuario.Text & usuAux.Usu_Contraseña == txtPass.Text)
                {
                    existe = true;
                }
            }

            if (existe)
            {
                MessageBox.Show("Bienvenido");
                this.Hide();
                fPrincipal.Show();
                //this.Close();

            }
            else
            {
                MessageBox.Show("No ingresó correctamente el usuario o contraseña");
            }
        }

        private void btnAceptarLogin_MouseHover(object sender, EventArgs e)
        {
            btnAceptarLogin.BackColor = Color.LightGreen;
            btnAceptarLogin.Size = new Size(140, 35); 
        }

        private void btnAceptarLogin_MouseLeave(object sender, EventArgs e)
        {
            btnAceptarLogin.BackColor = Color.Empty;
            btnAceptarLogin.Size = new Size(135, 30); 
        }


>>>>>>> dr-da
    }
}
