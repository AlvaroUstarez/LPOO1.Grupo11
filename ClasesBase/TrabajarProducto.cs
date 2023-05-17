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
            cmd.CommandText = "INSERT INTO Producto(Prod_Categoria, Prod_Descripcion, Prod_Precio, Prod_Baja) values(@prodcategoria, @prodescripcion, @prodprecio, @baja)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@prodcategoria", product.Prod_Categoria);
            cmd.Parameters.AddWithValue("@prodescripcion", product.Prod_Descripcion);
            cmd.Parameters.AddWithValue("@prodprecio", product.Prod_Precio);
            cmd.Parameters.AddWithValue("@baja", false);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }

        public static DataTable listar_product()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select";
            cmd.CommandText += " Prod_Codigo as 'Codigo',";
            cmd.CommandText += " Prod_Categoria as 'Categoria',";
            cmd.CommandText += " Prod_Descripcion as 'Descripcion',";
            cmd.CommandText += " Prod_Precio as 'Precio'";

            cmd.CommandText += " FROM Producto as P";
            cmd.CommandText += " WHERE Prod_Baja = 0";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable search_producto(int codigo)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT Prod_Codigo AS 'Codigo', ";
            cmd.CommandText += "Prod_Categoria AS 'Categoria', ";
            cmd.CommandText += "Prod_Descripcion AS 'Descricion', ";
            cmd.CommandText += "Prod_Precio AS 'Precio' ";
            cmd.CommandText += "FROM Producto AS P ";
            cmd.CommandText += "WHERE Prod_Codigo = @codigo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@codigo", codigo);

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable buscarProductoDescripcion(string descripcion)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "Select";
            cmd.CommandText += " Prod_Codigo as 'Codigo',";
            cmd.CommandText += " Prod_Categoria as 'Categoria',";
            cmd.CommandText += " Prod_Descripcion as 'Descripcion',";
            cmd.CommandText += " Prod_Precio as 'Precio'";
            cmd.CommandText += " FROM Producto";
            cmd.CommandText += " WHERE Prod_Descripcion LIKE @descripcion";
            
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@descripcion", "%" + descripcion + "%");

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void modificarProductoSP(int id, Producto producto)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "modificar_producto_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@categoria", producto.Prod_Categoria);
            cmd.Parameters.AddWithValue("@descripcion", producto.Prod_Descripcion);
            cmd.Parameters.AddWithValue("@precio", producto.Prod_Precio);

            // Ejecuta la consulta
            cnn.Open();
            int filasAfectadas = cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void darDeBajaProducto(int id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "baja_producto_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@baja", true);

            // Ejecuta la consulta
            cnn.Open();
            int filasAfectadas = cmd.ExecuteNonQuery();
            cnn.Close();
        }

    }
}
