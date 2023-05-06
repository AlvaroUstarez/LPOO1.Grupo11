﻿using System;
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
            cmd.CommandText += " Cli_DNI as 'dni',";
            cmd.CommandText += " Cli_Apellido as 'apellido',";
            cmd.CommandText += " Cli_Nombre as 'nombre',";
            cmd.CommandText += " Cli_Direccion as 'direccion',";
            cmd.CommandText += " OS_CUIT as 'cuit',";
            cmd.CommandText += " Cli_NroCarnet as 'carnet'";
            cmd.CommandText += " FROM Cliente as C";
            cmd.CommandText += " LEFT JOIN ObraSocial as OS ON (OS.OS_CUIT = C.OS_CUIT)";
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
            cmd.CommandText += " Cli_DNI as 'dni',";
            cmd.CommandText += " Cli_Apellido as 'apellido',";
            cmd.CommandText += " Cli_Nombre as 'nombre',";
            cmd.CommandText += " Cli_Direccion as 'direccion',";
            cmd.CommandText += " OS_CUIT as 'cuit',";
            cmd.CommandText += " Cli_NroCarnet as 'carnet'";
            cmd.CommandText += " FROM Cliente as C";
            cmd.CommandText += " LEFT JOIN ObraSocial as OS ON (OS.OS_CUIT = C.OS_CUIT)";
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
