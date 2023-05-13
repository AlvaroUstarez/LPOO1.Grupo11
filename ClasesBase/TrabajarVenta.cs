using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;


namespace ClasesBase
{
    public class TrabajarVenta
    {
        private static BindingList<VentaDetalle> detallesVenta = new BindingList<VentaDetalle>();

        public static void agregar_detalle(VentaDetalle detalle)
        {
            detallesVenta.Add(detalle);
        }

        public static BindingList<VentaDetalle> obtenerDetalles()
        {
            return detallesVenta;
        }

        //TODO Agregar venta al iniciar el formulario
        /**Se agrega la vanta a la bd para obtener el numero de venta,
         * Luege se agregan los detalles con el numero de venta
         */
        public static int iniciar_venta()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT TOP 1 Ven_Nro FROM Venta ORDER BY Ven_Nro desc";            
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cnn.Open();
            int numeroVenta = (int)cmd.ExecuteScalar();
            cnn.Close();

            //Devuelve el número de Venta
            return numeroVenta+1;
        }

        public static int guardarVenta(Venta venta) {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Venta(Ven_Fecha, Cli_Id) OUTPUT INSERTED.Ven_Nro VALUES(@fecha, @ClienteId)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@fecha", venta.VentaFecha);
            cmd.Parameters.AddWithValue("@ClienteId", venta.ClienteId);


            cnn.Open();
            int numeroVenta = (int)cmd.ExecuteScalar();
            cnn.Close();

            // Utiliza el número de venta como necesites
            return numeroVenta;
        }

        public static void guardarDetalle(VentaDetalle detalle)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO VentaDetalle(Ven_Nro, Prod_Codigo, Det_Precio, Det_Cantidad, Det_Total) values(@venta_numero, @producto_codigo, @detalle_precio ,@detalle_cantidad, @detalle_total)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@venta_numero", detalle.VentaNumero);
            cmd.Parameters.AddWithValue("@producto_codigo", detalle.ProdCodigo);
            cmd.Parameters.AddWithValue("@detalle_precio", detalle.DetallePrecio);
            cmd.Parameters.AddWithValue("@detalle_cantidad", detalle.DetalleCantidad);
            cmd.Parameters.AddWithValue("@detalle_total", detalle.DetalleTotal);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }


        public static void agrear_venta_detalle(Venta venta)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Venta SET Cli_Id = @id";
            cmd.CommandText += " WHERE Cli_Id = @id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", venta.ClienteId);
  
            cnn.Open();
            int filasAfectadas = cmd.ExecuteNonQuery();
            cnn.Close();

            
        }

        //Busca Venta por id de cliente
        public static DataTable buscarVenta(int id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select";
            cmd.CommandText += " Ven_Nro as 'Venta Número',";
            cmd.CommandText += " Ven_Fecha as 'Fecha',";
            cmd.CommandText += " Cli_Id as 'IdCliente'";

            cmd.CommandText += " FROM Venta";
            cmd.CommandText += " WHERE Cli_Id LIKE @id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", id);

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        //Busca una Venta entre dos Fechas
        public static DataTable buscarVentaFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            fechaInicio = fechaInicio.AddDays(-1);
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select";
            cmd.CommandText += " Ven_Nro as 'Venta Número',";
            cmd.CommandText += " Ven_Fecha as 'Fecha',";
            cmd.CommandText += " Cli_Id as 'IdCliente'";

            cmd.CommandText += " FROM Venta";
            cmd.CommandText += " WHERE Ven_Fecha >= @fechaInicio AND Ven_Fecha <= @fechaFin";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
            cmd.Parameters.AddWithValue("@fechaFin", fechaFin);

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }



    }
}
