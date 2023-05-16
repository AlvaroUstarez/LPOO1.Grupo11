using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarCliente
    {
        
        public static void insert_cliente(Cliente client)
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Cliente(Cli_DNI,Cli_Apellido, Cli_Nombre, Cli_Direccion, OS_Cuit, Cli_NroCarnet) values(@dni,@apellido,@nombre,@direccion, @os_cuit, @nro_carnet)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", client.Cli_DNI);
            cmd.Parameters.AddWithValue("@apellido", client.Cli_Apellido);
            cmd.Parameters.AddWithValue("@nombre", client.Cli_Nombre);
            cmd.Parameters.AddWithValue("@direccion", client.Cli_Direccion);
            cmd.Parameters.AddWithValue("@os_cuit", client.OS_CUIT);
            cmd.Parameters.AddWithValue("@nro_carnet", client.Cli_NroCarnet);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }

        public static DataTable list_clientes()
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select";
            cmd.CommandText += " Cli_Id as 'id',";
            cmd.CommandText += " Cli_DNI as 'dni',";
            cmd.CommandText += " Cli_Apellido as 'apellido',";
            cmd.CommandText += " Cli_Nombre as 'nombre',";
            cmd.CommandText += " Cli_Direccion as 'direccion',";
            cmd.CommandText += " Cli_NroCarnet as 'carnet',";
            cmd.CommandText += " C.OS_CUIT as 'cuit',";
            cmd.CommandText += " Cli_NroCarnet as 'carnet'";
            cmd.CommandText += " FROM Cliente as C LEFT JOIN ObraSocial as OS ON (OS.OS_CUIT = C.OS_CUIT)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable list_clientes_apellido_sp()
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listar_clientes_apellido_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable list_clientes_ventas()
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select";
            cmd.CommandText += " Cli_Id as 'id',";
            cmd.CommandText += " Cli_DNI as 'dni',";
            cmd.CommandText += " Cli_Apellido as 'apellido',";
            cmd.CommandText += " Cli_DNI + ', ' + Cli_Apellido as 'dni_apellido'";
            cmd.CommandText += " FROM Cliente as C LEFT JOIN ObraSocial as OS ON (OS.OS_CUIT = C.OS_CUIT)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }


        public static DataTable search_clientes(string sPattern)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select";
            cmd.CommandText += " Cli_Id as 'id',";
            cmd.CommandText += " Cli_DNI as 'dni',";
            cmd.CommandText += " Cli_Apellido as 'apellido',";
            cmd.CommandText += " Cli_Nombre as 'nombre',";
            cmd.CommandText += " Cli_Direccion as 'direccion',";
            cmd.CommandText += " Cli_NroCarnet as 'carnet',";
            cmd.CommandText += " C.OS_CUIT as 'cuit',";
            cmd.CommandText += " Cli_NroCarnet as 'carnet'";
            cmd.CommandText += " FROM Cliente as C LEFT JOIN ObraSocial as OS ON (OS.OS_CUIT = C.OS_CUIT)";
            cmd.CommandText += "WHERE Cli_DNI LIKE @pattern";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pattern", "%" + sPattern + "%");

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void modificar_Cliente(int id, Cliente cliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Cliente SET Cli_DNI = @dni, Cli_Apellido = @apellido, Cli_Nombre = @nombre, Cli_Direccion = @direccion, OS_CUIT = @cuit, Cli_NroCarnet = @carnet";
            cmd.CommandText += " WHERE Cli_Id = @id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@dni", cliente.Cli_DNI);
            cmd.Parameters.AddWithValue("@apellido", cliente.Cli_Apellido);
            cmd.Parameters.AddWithValue("@nombre", cliente.Cli_Nombre);
            cmd.Parameters.AddWithValue("@direccion", cliente.Cli_Direccion);
            cmd.Parameters.AddWithValue("@cuit", cliente.OS_CUIT);
            cmd.Parameters.AddWithValue("@carnet", cliente.Cli_NroCarnet);

            // Ejecuta la consulta
            cnn.Open();
            int filasAfectadas = cmd.ExecuteNonQuery();
            cnn.Close();
        }



    }
}
