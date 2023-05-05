﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {
        private int usu_ID;

        public int Usu_ID
        {
            get { return usu_ID; }
            set { usu_ID = value; }
        }
        private string usu_NombreUsuario;

        public string Usu_NombreUsuario
        {
            get { return usu_NombreUsuario; }
            set { usu_NombreUsuario = value; }
        }
        private string usu_Contraseña;

        public string Usu_Contraseña
        {
            get { return usu_Contraseña; }
            set { usu_Contraseña = value; }
        }
        private string usu_ApellidoNombre;

        public string Usu_ApellidoNombre
        {
            get { return usu_ApellidoNombre; }
            set { usu_ApellidoNombre = value; }
        }

        private string usu_Email;

        public string Usu_Email
        {
            get { return usu_Email; }
            set { usu_Email = value; }
        }

        private int rol_Codigo;

        public int Rol_Codigo
        {
            get { return rol_Codigo; }
            set { rol_Codigo = value; }
        }

        public Usuario(String nombreUsuario, String password)
        {
            usu_NombreUsuario = nombreUsuario;
            usu_Contraseña = password;
        }

    }

}
