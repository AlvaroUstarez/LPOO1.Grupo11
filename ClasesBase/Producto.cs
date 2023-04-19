using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    class Producto
    {
        private string Prod_Codigo;
        private string Prod_Categoria;
        private string Prod_Descripcion;
        private decimal Prod_Precio;

        public string Prod_Codigo1
        {
            get { return Prod_Codigo; }
            set { Prod_Codigo = value; }
        }

        public string Prod_Categoria1
        {
            get { return Prod_Categoria; }
            set { Prod_Categoria = value; }
        }

        public string Prod_Descripcion1
        {
            get { return Prod_Descripcion; }
            set { Prod_Descripcion = value; }
        }

        public decimal Prod_Precio1
        {
            get { return Prod_Precio; }
            set { Prod_Precio = value; }
        }
    }
}
