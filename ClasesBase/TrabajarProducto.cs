using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarProducto
    {
        public static void insert_product(Producto product)
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Producto(Prod_Codigo, Prod_Categoria, Prod_Descripcion, Prod_Precio) values(@procodigo,@procategoria,@prodescripcion,@proprecio)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

//            cmd.Parameters.AddWithValue("@procodigo", product.Prod_Codigo);
            cmd.Parameters.AddWithValue("@procategoria", product.Prod_Categoria);
            cmd.Parameters.AddWithValue("@prodescripcion", product.Prod_Descripcion);
            cmd.Parameters.AddWithValue("@proprecio", product.Prod_Precio);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }
    }
}
