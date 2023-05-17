﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;
namespace Vistas
{
    public partial class FrmListaVenta : Form
    {
        public FrmListaVenta()
        {
            InitializeComponent();
        }
        private void FrmListaVenta_Load(object sender, EventArgs e)
        {
            load_usuers();
        }

        private void load_usuers()
        {
            DataTable dt = TrabajarCliente.list_clientes_ventas();

            DataRow dr = dt.NewRow();

            dr["dni_apellido"] = "Seleccionar un cliente";
            dr["id"] = 0;
            dt.Rows.InsertAt(dr, 0);
            cmbListaClientes.DataSource = dt;
            cmbListaClientes.ValueMember = "id";
            cmbListaClientes.DisplayMember = "dni_apellido";
            cmbListaClientes.SelectedIndex = 0;

        }

        private void btnBuscarVenta_Click(object sender, EventArgs e)
        {
            int idcliente = int.Parse(cmbListaClientes.SelectedValue.ToString());
            TrabajarVenta.buscar_venta_cliente_sp(idcliente);

            dgwListaVenta.DataSource = TrabajarVenta.buscar_venta_cliente_sp(idcliente);

        }

        //Buscar Venta por fecha
        private void btnBuscarFecha_Click(object sender, EventArgs e)
        {
            dgwListaVenta.DataSource = TrabajarVenta.buscarVentaFechaSP(dtpFechaInicio.Value , dtpFechaFin.Value);
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmPrincipal fPrincipal = new FrmPrincipal();
            this.Hide();
            fPrincipal.Show();
        }

        

        
    }
}
