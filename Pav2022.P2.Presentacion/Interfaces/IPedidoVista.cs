using Pav2022.P2.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pav2022.P2.Presentacion.Interfaces
{
    public interface IPedidoVista : IVista
    {
        public void CargarListaPedidosListos(List<Pedido> pedidosListos);
        public void CargarListaPedidosPendientes(List<Pedido> pedidosPendientes);
        public void Cerrar();
    }
}
