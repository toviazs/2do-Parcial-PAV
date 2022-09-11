using Pav2022.P2.Dominio.Entidades;
using Pav2022.P2.Presentacion.Interfaces;
using Pav2022.P2.Presentacion.Presentadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pav2022.P2.Presentacion.Vistas
{
    public partial class PedidoVista : CrearPedidoVistaConPresentador, IPedidoVista
    {
        public PedidoVista()
        {
            InitializeComponent();
        }
        public void CargarListaPedidosListos(List<Pedido> pedidosListos)
        {
            PedidosListosDGV.DataSource = pedidosListos;
        }
        public void CargarListaPedidosPendientes(List<Pedido> pedidosPendientes)
        {
            PedidosPendientesDGV.DataSource = pedidosPendientes;
        }

        public void Cerrar()
        {
            Dispose();
        }

        protected override void OnLoad(EventArgs e)
        {
            Presentador.InicializarVista();
        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            Presentador.IniciarRegistroPedido();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cerrar();
        }
    }
    public class CrearPedidoVistaConPresentador : VistaBaseGenerica<PedidoPresentador> { }
}
