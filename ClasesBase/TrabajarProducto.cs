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
            cmd.CommandText = "INSERT INTO Producto(Prod_Categoria, Prod_Descripcion, Prod_Precio) values(@procategoria, @prodescripcion, @proprecio)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //cmd.Parameters.AddWithValue("@procodigo", product.Prod_Codigo);
            cmd.Parameters.AddWithValue("@procategoria", product.Prod_Categoria);
            cmd.Parameters.AddWithValue("@prodescripcion", product.Prod_Descripcion);
            cmd.Parameters.AddWithValue("@proprecio", product.Prod_Precio);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }

        public static DataTable listar_product()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select";
            cmd.CommandText += " Prod_Codigo as 'cod',";
            cmd.CommandText += " Prod_Categoria as 'cat',";
            cmd.CommandText += " Prod_Descripcion as 'desc',";
            cmd.CommandText += " Prod_Precio as 'precio'";

            cmd.CommandText += " FROM Producto as P";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable search_producto(int sPattern)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT Prod_Codigo AS 'cod', ";
            cmd.CommandText += "Prod_Categoria AS 'cat', ";
            cmd.CommandText += "Prod_Descripcion AS 'desc', ";
            cmd.CommandText += "Prod_Precio AS 'precio' ";
            cmd.CommandText += "FROM Producto AS P ";
            cmd.CommandText += "WHERE Prod_Codigo = @pattern";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pattern", sPattern);

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static Producto search_producto_venta(int sPattern)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT Prod_Codigo, Prod_Categoria, Prod_Descripcion, Prod_Precio FROM Producto WHERE Prod_Codigo = @pattern";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pattern", sPattern);

            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            Producto producto = null;

            if (reader.Read())
            {
                producto = new Producto();
                //producto.Prod_Codigo = (string)reader["Prod_Codigo"];
                producto.Prod_Categoria = (string)reader["Prod_Categoria"];
                producto.Prod_Descripcion = (string)reader["Prod_Descripcion"];
                producto.Prod_Precio = (float)reader["Prod_Precio"];
            }

            reader.Close();
            cnn.Close();

            return producto;
        }
    }
}
