using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    class Cliente
    {
        private string cli_DNI;
        private string cli_Apellido;
        private string cli_Nombre;
        private string cli_Direccion;
        private string oS_CUIT;
        private string cli_NroCarnet;

        public string Cli_DNI
        {
            get { return Cli_DNI; }
            set { Cli_DNI = value; }
        }
        
        public string Cli_Apellido
        {
            get { return Cli_Apellido; }
            set { Cli_Apellido = value; }
        }

        public string Cli_Nombre
        {
            get { return Cli_Nombre; }
            set { Cli_Nombre = value; }
        }

        public string Cli_Direccion
        {
            get { return Cli_Direccion; }
            set { Cli_Direccion = value; }
        }

        public string OS_CUIT
        {
            get { return OS_CUIT; }
            set { OS_CUIT = value; }
        }

        public string Cli_NroCarnet
        {
            get { return Cli_NroCarnet; }
            set { Cli_NroCarnet = value; }
        }



    }
}
