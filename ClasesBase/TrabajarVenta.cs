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
        public static int iniciar_venta(Venta venta)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Venta(Ven_Fecha) OUTPUT INSERTED.Ven_Nro VALUES(@fecha)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@fecha", venta.VentaFecha);

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


        public static void agrear_venta_detalle()
        {
            
        }



    }
}
