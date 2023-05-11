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

        //TODO
        public static void iniciar_venta()
        {
            
        }



    }
}
