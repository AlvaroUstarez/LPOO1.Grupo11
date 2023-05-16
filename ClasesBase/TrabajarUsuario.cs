using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarUsuario
    {

        public static DataTable list_roles(){
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * From roles";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            //Llena los datos de la consulta en el DataTable
            da.Fill(dt);

            return dt;
        }

        public static DataTable list_roles_sp()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listar_roles_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            //Llena los datos de la consulta en el DataTable
            da.Fill(dt);

            return dt;
        }


        public static void insert_usuario(Usuario user) {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Usuario(rol_Codigo,usu_NombreUsuario,usu_Contraseña,usu_Apellido, usu_Nombre, usu_Email) values(@rol,@nombre_usuario,@contraseña,@apellido, @nombre, @email)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@rol", user.Rol_Codigo);
            cmd.Parameters.AddWithValue("@nombre_usuario", user.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@contraseña", user.Usu_Contraseña);
            cmd.Parameters.AddWithValue("@apellido", user.Usu_Apellido);
            cmd.Parameters.AddWithValue("@nombre", user.Usu_Nombre);
            cmd.Parameters.AddWithValue("@email", user.Usu_Email);


            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }

        public static DataTable list_usuarios()
        {
            //TODO:
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select";
            cmd.CommandText += " rol_descripcion as 'rol', ";
            cmd.CommandText += " usu_NombreUsuario as 'Usuario', usu_Contraseña as 'Contraseña', ";
            cmd.CommandText += " usu_Apellido as 'Apellido',";
            cmd.CommandText += " usu_Nombre as 'Nombre',";
            cmd.CommandText += " Usu_Email as 'Email'";
            cmd.CommandText += " FROM Usuario as U";
            cmd.CommandText += " LEFT JOIN Roles as R ON (R.rol_Codigo=U.rol_Codigo)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            

            //Crear el data set
            DataSet ds = new DataSet();

            //Cargar el data set con el data adapter
            da.Fill(ds);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable list_usuarios_sp()
        {
            //TODO:
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText += "listar_usuarios_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);



            //Crear el data set
            DataSet ds = new DataSet();

            //Cargar el data set con el data adapter
            da.Fill(ds);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable search_usuarios(string sPattern)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select";
            cmd.CommandText += " rol_descripcion as 'Rol', ";
            cmd.CommandText += " usu_NombreUsuario as 'Usuario', usu_Contraseña as 'Contraseña', ";
            cmd.CommandText += " usu_Apellido as 'Apellido',";
            cmd.CommandText += " usu_Nombre as 'Nombre',";
            cmd.CommandText += " Usu_Email as 'Email'";
            cmd.CommandText += " FROM Usuario as U";
            cmd.CommandText += " LEFT JOIN Roles as R ON (R.rol_Codigo=U.rol_Codigo)";

            cmd.CommandText += "WHERE usu_Apellido LIKE @pattern";

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
    }
}
