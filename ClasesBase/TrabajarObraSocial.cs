using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ClasesBase
{
    public class TrabajarObraSocial
    {
        public static void insert_obrasocial(ObraSocial obraSocial)
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO ObraSocial(OS_CUIT, OS_RazonSocial, OS_Direccion, OS_Telefono) values(@oscuit,@osrazonsocial,@osdireccion,@ostelefono)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@oscuit", obraSocial.Os_Cuit);
            cmd.Parameters.AddWithValue("@osrazonsocial", obraSocial.Os_RazonSocial);
            cmd.Parameters.AddWithValue("@osdireccion", obraSocial.Os_Direccion);
            cmd.Parameters.AddWithValue("@ostelefono", obraSocial.Os_Telefono);


            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

        }
    }
}
