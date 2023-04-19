using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    class Cliente
    {
        private string Cli_DNI;
        private string Cli_Apellido;
        private string Cli_Nombre;
        private string Cli_Direccion;
        private string OS_CUIT;
        private string Cli_NroCarnet;

        public string Cli_DNI1
        {
            get { return Cli_DNI; }
            set { Cli_DNI = value; }
        }
        
        public string Cli_Apellido1
        {
            get { return Cli_Apellido; }
            set { Cli_Apellido = value; }
        }

        public string Cli_Nombre1
        {
            get { return Cli_Nombre; }
            set { Cli_Nombre = value; }
        }

        public string Cli_Direccion1
        {
            get { return Cli_Direccion; }
            set { Cli_Direccion = value; }
        }

        public string OS_CUIT1
        {
            get { return OS_CUIT; }
            set { OS_CUIT = value; }
        }

        public string Cli_NroCarnet1
        {
            get { return Cli_NroCarnet; }
            set { Cli_NroCarnet = value; }
        }



    }
}
